using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System;
using Merwer.Chronicle.Dungeoneering.Tracker.ViewModels.Draft;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Drawing;
using System.IO;
using System.Drawing.Text;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    [Authorize]
    [RoutePrefix("Drafts")]
    public class DraftController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [Route("my")]
        public ActionResult Index()
        {
            return List(User.Identity.Name);
        }

        [AllowAnonymous]
        [Route("u/{username}")]
        public ActionResult List(string username)
        {
            var user = UserManager.FindByNameAsync(username).Result;
            if(user == null)
            {
                return HttpNotFound("Invalid username");
            }

            //TODO: Paging?
            var playerDrafts = db.Drafts
                .Where(d => d.OwnerId == user.Id)
                .OrderByDescending(d => d.CreatedOn)
                .ThenByDescending(d => d.Id).ToList();
            return View("List", new ListView
            {
                Username = username,
                Drafts = playerDrafts,
                IsSelf = User.Identity.IsAuthenticated && User.Identity.GetUserId() == user.Id,
                ShowNewDraft = playerDrafts.All(draft => draft.Complete)
            });
        }

        [Route("current")]
        public ActionResult CurrentDraft()
        {
            Draft draft = db.Drafts.Include(d => d.Rounds).Where(d => d.OwnerId == UserId).ToList().SingleOrDefault(d => !d.Complete);
            if (draft == null)
            {
                return HttpNotFound("No current draft");
            }
            else
            {
                return RedirectToAction("View", new { id = draft.Id });
            }
        }

        [AllowAnonymous]
        [Route("{id:long}")]
        public ActionResult View(long id)
        {
            Draft draft = null;
            draft = db.Drafts.Include(d => d.Rounds).FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (User.Identity.IsAuthenticated && UserId.Equals(draft.OwnerId))
            {
                return View("Edit", draft);
            }
            return View("View", draft);
        }

        [AllowAnonymous]
        [Route("{id:long}/thumb")]
        public ActionResult Image(long id)
        {
            Draft draft = null;
            draft = db.Drafts.Include(d => d.Rounds).FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            return CreateDraftImage(draft);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Archetype archetype)
        {
            Draft draft = new Draft();
            draft.OwnerId = UserId;
            draft.Archetype = archetype;

            var playerDrafts = db.Drafts.Where(d => d.OwnerId == UserId).ToList();
            var currentDraft = playerDrafts.SingleOrDefault(d => !d.Complete);
            if (currentDraft != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Another dungeon run is currently active");
            }
            db.Drafts.Add(draft);
            db.SaveChanges();
            return RedirectToAction("View", new { id = draft.Id });
        }

        [Route("{id:long}/skip")]
        [HttpPost]
        public ActionResult Skip(long id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerId != UserId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            draft.DraftSkipped = true;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("{id:long}")]
        [HttpDelete]
        public ActionResult Delete(long id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerId != UserId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            db.Drafts.Remove(draft);
            db.SaveChanges();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [Route("{id:long}/Abandon")]
        [HttpPatch]
        public ActionResult Abandon(long id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerId != UserId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            draft.Abandoned = true;
            db.SaveChanges();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [Route("{id:long}/Restore")]
        [HttpPatch]
        public ActionResult Restore(long id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerId != UserId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            draft.Abandoned = false;
            db.SaveChanges();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        const int IMAGE_WIDTH = 250;
        const int IMAGE_HEADER_HEIGHT = 125;
        const int IMAGE_SECTION_HEADER_HEIGHT = 20;
        const int IMAGE_SEPARATOR_BETWEEN_SECTIONS = 20;
        const int IMAGE_SECTION_BUFFER = 5;
        const int IMAGE_LINE_HEIGHT = 20;
        const int IMAGE_HEADER_OFFSET = 50;
        private static readonly Font itemFont = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
        private static readonly Font headerFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);

        private ActionResult CreateDraftImage(Draft draft)
        {
            var cardIds = draft.Rounds.SelectMany(r => r.Selected).ToList();
            var cards = db.Cards.Include(c => c.Parent)
                    .Where(c => cardIds.Contains((int)c.Id)).ToList();
            var supports = cards.Where(c => c.Type == CardType.Support).OrderBy(c => c.Cost);
            var creatures = cards.Where(c => c.Type == CardType.Combat).OrderBy(c => c.Health);
            using (Bitmap image = new Bitmap(IMAGE_WIDTH, (cards.Count() * IMAGE_LINE_HEIGHT) + IMAGE_HEADER_HEIGHT))
            {
                using (Graphics g = Graphics.FromImage(image))
                {
                    g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    g.Clear(Color.White);
                    CreateSummary(g, draft, 0, 0);
                    CreateSupports(g, supports, 0, 60);
                    CreateCombats(g, creatures, 0, 80 + ((supports.Count() + 1) * IMAGE_LINE_HEIGHT));
                }

                MemoryStream ms = new MemoryStream();

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return File(ms.ToArray(), "image/png");
            }
        }

        private void CreateSummary(Graphics g, Draft d, int x, int y)
        {
            Brush drawBrush = new SolidBrush(Color.Black);
            string text1, text2;
            var wins = d.Matches.Count(m => m.Win);
            var losses = d.Matches.Count(m => !m.Win);
            if (d.Complete) {
                text1 = "Dungeon Run (" + d.Archetype + ")";
                text2 = wins + " Wins, " + losses + " Losses";
            } else {
                text1 = "Dungeon Draft (" + d.Archetype + ")";
                text2 = "Still Drafting";
            }
            g.DrawString("chroniclecompass.com/Drafts/" + d.Id, headerFont, drawBrush, new PointF(x, y));
            g.DrawString(text1, itemFont, drawBrush, new PointF(x, y + IMAGE_LINE_HEIGHT));
            g.DrawString(text2, itemFont, drawBrush, new PointF(x, y + (IMAGE_LINE_HEIGHT * 2)));
        }

        private void CreateSupports(Graphics g, IEnumerable<Card> supports, int x, int y)
        {
            int count = supports.Count();
            string text = "     Support";
            DrawSupport(g, headerFont, text, count, x, y);
            int currY = y + IMAGE_SECTION_BUFFER;
            foreach(Card card in supports)
            {
                currY += IMAGE_LINE_HEIGHT;
                DrawSupport(g, itemFont, card.Name, 1, x, currY);
            }
        }

        private void DrawSupport(Graphics g, Font font, string text, int count, int x, int y)
        {
            Brush pen = new SolidBrush(Color.Blue);
            g.FillRectangle(pen, x, y, IMAGE_WIDTH, IMAGE_LINE_HEIGHT);

            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString(text, font, drawBrush, new PointF(x, y));
            g.DrawString("x" + count.ToString(), font, drawBrush, new PointF(IMAGE_WIDTH - 30, y));
        }

        private void CreateCombats(Graphics g, IEnumerable<Card> combats, int x, int y)
        {
            int count = combats.Count();
            string text = "      Creatures";
            DrawCombat(g, headerFont, text, count, x, y);
            int currY = y + IMAGE_SECTION_BUFFER;
            foreach (Card card in combats)
            {
                currY += IMAGE_LINE_HEIGHT;
                DrawCombat(g, itemFont, card.Name, 1, x, currY);
            }
        }

        private void DrawCombat(Graphics g, Font font, string text, int count, int x, int y)
        {
            Brush pen = new SolidBrush(Color.Red);
            g.FillRectangle(pen, x, y, IMAGE_WIDTH, IMAGE_LINE_HEIGHT);

            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString(text, font, drawBrush, new PointF(x, y));
            g.DrawString("x" + count.ToString(), font, drawBrush, new PointF(IMAGE_WIDTH - 30, y));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

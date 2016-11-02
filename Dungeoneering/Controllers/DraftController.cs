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
using Merwer.Chronicle.Dungeoneering.Tracker.Helpers;

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
            var cardIds = draft.Rounds.SelectMany(r => r.Selected);
            var cards = db.Cards.Include(c => c.Parent)
                    .Where(c => cardIds.Contains((int)c.Id))
                    .ToDictionary(card => card, card => cardIds.Count(c => c == card.Id));
            return File(new DraftImageCreator().CreateDraftImage(draft, cards), "image/png");
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

using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public class DraftsController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Drafts
        public ActionResult Index()
        {
            //TODO: Paging?
            var playerDrafts = db.Drafts
                .Where(d => d.OwnerName == User.Identity.Name)
                .OrderByDescending(d => d.CreatedOn)
                .ThenByDescending(d => d.Id).ToList();
            return View(playerDrafts);
        }

        // GET: Drafts/Drafting/5
        public ActionResult Drafting(long id)
        {
            Draft draft = db.Drafts.Include(d => d.Rounds).FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerName != User.Identity.Name)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            return View(draft);
        }

        [HttpPost]
        public ActionResult Round(int? draftId, int? roundId, List<int> options, List<int> selected)
        {
            if (draftId == null || roundId == null || options.Count != 5 || selected.Count != 2)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Missing information");
            }
            Draft draft = db.Drafts.Include(d => d.Rounds).FirstOrDefault(d => d.Id == draftId.Value);
            if(draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerName != User.Identity.Name)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            if (draft.Rounds.Any(r => r.RoundId == roundId.Value))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Already data for this round");
            }
            var round = new Round
            {
                Draft = draft,
                RoundId = roundId.Value,
                Options = options,
                Selected = selected,
                OwnerName = User.Identity.Name
            };
            db.Rounds.Add(round);
            db.SaveChanges();
            dynamic data = round.Id;
            if (draft.DraftComplete)
            {
                data = new { redirect = Url.Action("Index", null, null, Request.Url.Scheme) };
            }
            return Json(data);
        }

        // GET: Drafts/Create
        public ActionResult Create()
        {
            var playerDrafts = db.Drafts.Where(d => d.OwnerName == User.Identity.Name).ToList();
            var currentDraft = playerDrafts.SingleOrDefault(d => !d.Complete);
            if(currentDraft != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Dungeon run is currently active");
            }
            return View();
        }

        // POST: Drafts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Archetype")] Draft draft)
        {
            draft.OwnerName = User.Identity.Name;
            ModelState.Clear();
            TryValidateModel(draft);
            if (!ModelState.IsValid)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(err => err.ErrorMessage).ToList();
                return View(draft);
            }

            var playerDrafts = db.Drafts.Where(d => d.OwnerName == User.Identity.Name).ToList();
            var currentDraft = playerDrafts.SingleOrDefault(d => !d.Complete);
            if (currentDraft != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Another dungeon run is currently active");
            }
            db.Drafts.Add(draft);
            db.SaveChanges();
            return RedirectToAction("Drafting", new { id = draft.Id });
        }

        [HttpPost]
        public ActionResult Match([Bind(Exclude ="Draft")]Match match, int draftId)
        {
            Draft draft = db.Drafts.FirstOrDefault(d => d.Id == draftId);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerName != User.Identity.Name)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            match.Draft = draft;
            TryValidateModel(match);
            if (!ModelState.IsValid)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(err => err.ErrorMessage).ToList();
            }
            db.Matches.Add(match);
            
            if(match.Draft.Matches.Count(m => !m.Win) >= 3)
            {
                match.Draft.Complete = true;
            }
            db.SaveChanges();

            return Json(match.Id);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if(draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if(draft.OwnerName != User.Identity.Name)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            db.Drafts.Remove(draft);
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

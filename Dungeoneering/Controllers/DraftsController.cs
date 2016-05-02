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
    public class DraftsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Drafts
        public ActionResult Index()
        {
            //TODO: Paging?
            var playerDrafts = db.Drafts.Where(d => d.OwnerName == User.Identity.Name).ToList();
            return View(playerDrafts);
        }

        // GET: Drafts/Drafting/5
        public ActionResult Drafting(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Draft draft = db.Drafts.Include(d => d.Rounds).FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound();
            }
            return View(draft);
        }

        [HttpPost]
        public ActionResult Round(int? draftId, int? roundId, List<int> options, List<int> selected)
        {
            if (draftId == null || roundId == null || options.Count != 5 || selected.Count != 2)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var draft = db.Drafts.Find(draftId.Value);
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
            return new JsonResult
            {
                Data = round.Id
            };
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

            var playerDrafts = db.Drafts.Where(d => d.OwnerName == User.Identity.Name).ToList();
            var currentDraft = playerDrafts.SingleOrDefault(d => !d.Complete);
            if (currentDraft != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Dungeon run is currently active");
            }
            if (ModelState.IsValid)
            {
                db.Drafts.Add(draft);
                db.SaveChanges();
                return RedirectToAction("Drafting", new { id = draft.Id });
            }
            else
            {
                ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(err => err.ErrorMessage).ToList();
            }
            return View(draft);
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

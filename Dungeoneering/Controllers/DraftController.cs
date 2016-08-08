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
    [Route("Draft")]
    public class DraftController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        [Route("")]
        public ActionResult Index()
        {
            //TODO: Paging?
            var playerDrafts = db.Drafts
                .Where(d => d.OwnerName == Username)
                .OrderByDescending(d => d.CreatedOn)
                .ThenByDescending(d => d.Id).ToList();
            return View(playerDrafts);
        }
        
        [Route("{id:int}")]
        public ActionResult Drafting(long? id)
        {
            Draft draft = null;
            if (! id.HasValue)
            {
                draft = db.Drafts.Include(d => d.Rounds).Where(d => d.OwnerName == Username).ToList().SingleOrDefault(d => !d.Complete);
                if(draft == null)
                {
                    return HttpNotFound("No current draft");
                } else
                {
                    return RedirectToAction("Drafting", new { id = draft.Id });
                }
            }
            draft = db.Drafts.Include(d => d.Rounds).FirstOrDefault(d => d.Id == id.Value);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerName != Username)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            return View(draft);
        }

        [Route("Create")]
        public ActionResult Create()
        {
            var playerDrafts = db.Drafts.Where(d => d.OwnerName == Username).ToList();
            var currentDraft = playerDrafts.SingleOrDefault(d => !d.Complete);
            if(currentDraft != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Dungeon run is currently active");
            }
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Archetype archetype)
        {
            Draft draft = new Draft();
            draft.OwnerName = Username;
            draft.Archetype = archetype;

            var playerDrafts = db.Drafts.Where(d => d.OwnerName == Username).ToList();
            var currentDraft = playerDrafts.SingleOrDefault(d => !d.Complete);
            if (currentDraft != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Another dungeon run is currently active");
            }
            db.Drafts.Add(draft);
            db.SaveChanges();
            return RedirectToAction("Drafting", new { id = draft.Id });
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerName != Username)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            db.Drafts.Remove(draft);
            db.SaveChanges();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPatch]
        public ActionResult Abandon(int id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerName != Username)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            draft.Abandoned = true;
            db.SaveChanges();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPatch]
        public ActionResult Restore(int id)
        {
            var draft = db.Drafts.FirstOrDefault(d => d.Id == id);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerName != Username)
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

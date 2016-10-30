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
    [Authorize]
    [RoutePrefix("Drafts/{draftId:long}/Match")]
    public class DraftMatchController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route]
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Draft")]Match match, long draftId)
        {
            Draft draft = db.Drafts.FirstOrDefault(d => d.Id == draftId);
            if (draft == null)
            {
                return HttpNotFound("Invalid draft ID");
            }
            if (draft.OwnerId != UserId)
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
            
            db.SaveChanges();

            return Json(match.Id);
        }

        [Route("{id:long}")]
        [HttpPut]
        public ActionResult Edit(long id, [Bind(Exclude = "Draft")]Match match)
        {
            Match dbMatch = db.Matches.Include(m => m.Draft.Matches).FirstOrDefault(m => m.Id == id);
            if (dbMatch == null)
            {
                return HttpNotFound("Invalid match ID");
            }
            if (dbMatch.Draft.OwnerId != UserId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(err => err.ErrorMessage).ToList();
            }

            dbMatch.OpponentArchetype = match.OpponentArchetype;
            dbMatch.First = match.First;
            dbMatch.Win = match.Win;
            if (dbMatch.Win)
            {
                dbMatch.Rewards = match.Rewards;
            }
            else
            {
                dbMatch.Rewards.Copper = 0;
                dbMatch.Rewards.Shards = 0;
                dbMatch.Rewards.Packs = 0;
            }

            db.SaveChanges();

            return Json(match.Id);
        }

        [Route("{id:long}")]
        [HttpDelete]
        public ActionResult Delete(long id)
        {
            var match = db.Matches.FirstOrDefault(d => d.Id == id);
            if (match == null)
            {
                return HttpNotFound("Invalid match ID");
            }
            if (match.Draft.OwnerId != UserId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
            db.Matches.Remove(match);
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

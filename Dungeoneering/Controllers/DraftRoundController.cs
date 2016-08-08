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
    [Route("Draft/{draftId:int}/Round")]
    public class DraftRoundController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("{roundId:int}")]
        [HttpPost]
        public ActionResult Create(int? draftId, int? roundId, List<int> options, List<int> selected)
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
            if (draft.OwnerName != Username)
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
                OwnerName = Username
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

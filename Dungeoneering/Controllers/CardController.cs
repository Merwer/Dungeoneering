﻿using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    [RoutePrefix("Cards")]
    public class CardController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("{archetype}")]
        public ActionResult Index(Archetype archetype)
        {
            return Json(GetCards(archetype));
        }
        [Route("TierList")]
        public ActionResult TierList()
        {
            return View();
        }

        public List<Card> GetCards(Archetype archetype)
        {
            var list = db.CardScores.Where(cs => cs.Archetype == archetype)
                .Select(cs => cs.Card)
                .Where(c => c.Active)
                .Include(c => c.Parent)
                .Include(c => c.Scores)
                .ToList();

            list.ForEach(c =>
            {
                c.Score = c.Scores.Single(s => s.Archetype == archetype).Score;
            });
            return list;
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

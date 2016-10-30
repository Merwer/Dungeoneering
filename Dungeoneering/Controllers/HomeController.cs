using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public class HomeController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(
                Request.IsAuthenticated &&
                db.Drafts.Where(d => d.OwnerId == UserId).ToList().All(d => d.Complete)
            );
        }

        public ActionResult Privacy()
        {
            return View();
        }
    }
}
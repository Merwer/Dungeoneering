using Merwer.Chronicle.Dungeoneering.Tracker.Models;
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
                db.Drafts.Where(d => d.OwnerName == Username).ToList().All(d => d.Complete)
            );
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Data;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public class StatsController : BaseController
    {
        private StatsRepository repo = new StatsRepository();

        // GET: Stats
        public ActionResult Global()
        {
            var data = repo.GetCurrentGlobalStats();

            return View(data);
        }

        [Authorize]
        public ActionResult My()
        {
            var data = repo.SinglePlayer(Username);

            return View(data);
        }
    }
}
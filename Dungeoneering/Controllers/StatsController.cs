using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Data;
using System;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public class StatsController : BaseController
    {
        private const int ONE_HOUR = 3600;
        private StatsRepository repo = new StatsRepository();

        // GET: Stats
        [OutputCache(Duration = ONE_HOUR, VaryByParam = "start;end")]
        public ActionResult Global(long start = 0, long end = 0)
        {
            DateTime startDate = start == 0 ? DateTime.UtcNow.AddMonths(-1) : new DateTime(start);
            DateTime endDate = end == 0 ? DateTime.UtcNow : new DateTime(end);
            var data = repo.GetCurrentGlobalStats(startDate, endDate);
            data.StartDate = startDate;
            data.EndDate = endDate;
            data.LastUpdated = DateTime.UtcNow;
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
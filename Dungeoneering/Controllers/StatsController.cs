using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Data;
using System;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public class StatsController : BaseController
    {
        private const int ONE_DAY = 60 * 60 * 24;
        private StatsRepository repo = new StatsRepository();

        // GET: Stats
        [OutputCache(Duration = ONE_DAY, VaryByParam = "startDate;endDate")]
        public ActionResult Global(DateTime? startDate = null, DateTime? endDate = null)
        {
            DateTime start = startDate.HasValue ? startDate.Value : DateTime.UtcNow.AddMonths(-2);
            DateTime end = endDate.HasValue ? endDate.Value : DateTime.UtcNow;
            var data = repo.GetCurrentGlobalStats(start, end);
            data.StartDate = start;
            data.EndDate = end;
            data.LastUpdated = DateTime.UtcNow;
            return View(data);
        }

        [Authorize]
        public ActionResult My()
        {
            var data = repo.SinglePlayer(UserId);

            return View(data);
        }
    }
}
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    [RoutePrefix("News")]
    public class NewsController : BaseController
    {
        private ApplicationDbContext db = ApplicationDbContext.Create();
        
        [Route]
        public ActionResult List()
        {
            IEnumerable<NewsArticle> news = db.News.OrderByDescending(n => n.CreatedOn).Take(3).ToList();
            return View(news);
        }
    }
}
using Merwer.Chronicle.Dungeoneering.Tracker.Helpers;
using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public abstract class BaseController : Controller
    {
        public new ActionResult Json(object data)
        {
            JsonNetResult result = new JsonNetResult();
            result.Data = data;
            return new JsonNetResult
            {
                Data = data
            };
        }
    }
}
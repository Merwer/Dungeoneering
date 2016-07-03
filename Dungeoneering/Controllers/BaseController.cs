using Merwer.Chronicle.Dungeoneering.Tracker.Helpers;
using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public abstract class BaseController : Controller
    {
        private string _username;
        protected string Username
        {
            get
            {
                return _username ?? (_username = User.Identity.Name);
            }
        }

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
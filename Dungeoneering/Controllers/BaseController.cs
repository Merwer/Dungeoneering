using Merwer.Chronicle.Dungeoneering.Tracker.Helpers;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public abstract class BaseController : Controller
    {
        private string _username = "ZB7QP06KS0KCIZL";
        protected string Username
        {
            get
            {
                if(_username == null)
                {
                    if(User.Identity.IsAuthenticated)
                    {
                        _username = User.Identity.Name;
                    }
                    else
                    {
                        throw new HttpException((int)HttpStatusCode.Unauthorized, HttpStatusCode.Unauthorized.ToString());
                    }
                }
                return _username;
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
using Merwer.Chronicle.Dungeoneering.Tracker.Helpers;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public abstract class BaseController : Controller
    {
        private string _userid;
        protected string UserId
        {
            get
            {
                if (_userid == null)
                {
                    if (User.Identity.IsAuthenticated)
                    {
                        _userid = User.Identity.GetUserId();
                    }
                    else
                    {
                        throw new HttpException((int)HttpStatusCode.Unauthorized, HttpStatusCode.Unauthorized.ToString());
                    }
                }
                return _userid;
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
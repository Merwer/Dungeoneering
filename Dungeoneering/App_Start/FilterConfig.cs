using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

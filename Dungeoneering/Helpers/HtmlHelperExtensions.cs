using Newtonsoft.Json;
using System.Web.Mvc;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Helpers
{
    public static class HtmlHelperExtensions
    {
        private static readonly JsonSerializerSettings settings;

        static HtmlHelperExtensions()
        {
            settings = new JsonSerializerSettings();
            settings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
        }

        public static MvcHtmlString ToJson(this HtmlHelper html, object value)
        {
            return MvcHtmlString.Create(JsonConvert.SerializeObject(value, Formatting.None, settings));
        }
    }
}
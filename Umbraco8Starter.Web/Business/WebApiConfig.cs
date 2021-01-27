using System.Linq;
using System.Web.Http;

namespace Umbraco8Starter.Web.Business
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Currently allowing everything. May want to lock this down at some point.
            config.EnableCors();

            // Remove XML since it seems to be the default for Umbraco. Now it will return JSON, yay
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
using System.Web;
using System.Web.Http;
using FGV.TechnicalEvaluation.WebApi.Areas.HelpPage;

namespace FGV.TechnicalEvaluation.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.SetDocumentationProvider(new XmlDocumentationProvider(HttpContext.Current.Server.MapPath("~/App_Data/FGV.TechnicalEvaluation.WebApi.xml")));
        }
    }
}

using System.Web.Mvc;
using System.Web.Routing;

namespace Dot.Net.Framework.Prototype
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "NotFound",
                url: "{*any}",
                defaults: new { controller = "ErrorHandler", action = "NotFound" }
            );
        }
    }
}

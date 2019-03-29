using Dot.Net.Framework.Prototype.Helper;
using System.Web.Http;

namespace Dot.Net.Framework.Prototype
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Implements dynamic url routing for any controller.
            config.MapHttpAttributeRoutes(new ApiGlobalPrefixRouteProvider("api"));
        }
    }
}

using Dot.Net.Framework.Prototype.App_Start;
using Dot.Net.Framework.Prototype.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dot.Net.Framework.Prototype
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            // Sets global configuration.
            GlobalConfiguration.Configure(config =>
            {
                WebApiConfig.Register(config);
                WindsorConfig.Register(config);
                ApiFilterConfig.Register(config.Filters);
            });
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            MvcFilterConfig.Register(GlobalFilters.Filters);
        }

        /// <summary>
        /// Handles global errors.
        /// </summary>
        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();

            // LOG:
            ILogger logger = WindsorConfig.CONTAINER.Resolve<ILogger>();
            logger.Error(exception, $"{ConfigurationManager.AppSettings["AppName"]} has an error occurred.");
        }

        /// <summary>
        /// Handles incoming request.
        /// </summary>
        protected void Application_BeginRequest()
        {
            // Creates new session for logging on every new request had come.
            WindsorConfig.CONTAINER.Resolve<ILogger>().CreateNewSession(HttpContext.Current);

            // LOG:
            ILogger logger = WindsorConfig.CONTAINER.Resolve<ILogger>();
            logger.Debug($"The request has begun, Session ID: {NLog.MappedDiagnosticsContext.Get("session-id")}");
        }

    }
}
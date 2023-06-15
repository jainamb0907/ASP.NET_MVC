using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Collections.Generic;

namespace Practical9
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Test1", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

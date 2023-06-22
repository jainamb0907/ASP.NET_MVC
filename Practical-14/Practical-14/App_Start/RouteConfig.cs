﻿using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Collections.Generic;

namespace Practical_14
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

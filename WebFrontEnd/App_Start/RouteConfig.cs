﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebFrontEnd
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            if (SimpleBatchStuff.BadInit)
            {
                routes.MapRoute(
                name: "Default",
                url: "{a}/{b}/{id}",
                defaults: new
                    {
                        controller = "BadConfig",
                        action = "Index",
                        a = UrlParameter.Optional,
                        b = UrlParameter.Optional,
                        id = UrlParameter.Optional
                    }
                );

                return;
            }

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "Log", action = "ListAllInstances", id = UrlParameter.Optional }
            );
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNetOpenSourceTutorials
{
    public class RouteConfig

    /// <summary>
    /// This file fires up at App Start time and dictates how the requests go.
    /// </summary>
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Allows you to customize your URLs and set default URLs.

            //If I run the app right now, it will go like this -

            //HomeController -> Index Method

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace R.MessageBus.PublicWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Installer",
                url: "downloads/installer",
                defaults: new { controller = "Downloads", action = "installer" }
            );
            routes.MapRoute(
                name: "Release",
                url: "downloads/release",
                defaults: new { controller = "Downloads", action = "release" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace URLAndRoutes.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Shop",
                url: "Shop/{action}",
                defaults: new { Controller = "Home"}
                );
        

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}"
                );
        }
    }
}

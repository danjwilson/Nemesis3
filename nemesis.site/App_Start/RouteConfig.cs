using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nemesis.Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                "default", 
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Welcome", id = UrlParameter.Optional });

            routes.MapRoute(
                "postcodeSearch",
                "home/welcome/{search}",
                new { controller = "Home", action = "Welcome" });
        }
    }
}

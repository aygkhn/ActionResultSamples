using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ActionresultSamples
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    "Blog",
            //    "{Archive}/{action}/{date}",
            //    new { controller = "Archive", action = "Entry", date = UrlParameter.Optional }
            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "View", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapMvcAttributeRoutes();
        }
    }
}

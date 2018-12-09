using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aiko
{
    public class RouteConfig
    {
        //routing engine
        // - core part of asp .net (not tied to mvc fw)
        // - directs requests to controllers by following a map (a pattern it can use and apply to find out where to send the request
        //and to find parameters in the URL)
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //map allows (for the route)
            // - providing a friendly name
            // - a pattern
            // - default parameters

            routes.MapRoute( //adds entry to the routing table
                name: "Cuisine",
                url: "Cuisine/{action}/{name}",
                defaults: new { controller = "Example1", action = "Search", name = UrlParameter.Optional }
            );
            //the first route that matches the URL will "win"
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

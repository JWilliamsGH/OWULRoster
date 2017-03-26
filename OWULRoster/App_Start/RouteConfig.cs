using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OWULRoster
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Teams",
                url: "Teams/{teamId}",
                defaults: new { controller = "Team", action = "GetTeams", teamId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Players",
                url: "Players/{playerId}",
                defaults: new { controller = "Player", action = "GetPlayers", playerId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

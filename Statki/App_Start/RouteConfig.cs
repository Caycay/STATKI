using System.Web.Mvc;
using System.Web.Routing;

namespace Battle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{player1}/{player2}",
                defaults: new
                {
                    controller = "Log",
                    action = "Login",
                    player1 = UrlParameter.Optional,
                    player2 = UrlParameter.Optional


                }
                );

            routes.MapRoute(
               name: "Default2",
               url: "{controller}/{action}/{id}"
               
               );
        }
    }
}


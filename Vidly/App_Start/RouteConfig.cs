using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute Routing
            routes.MapMvcAttributeRoutes();

            // Convention way of routing 
            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "{controller}/released/{year}/{month}",
                defaults: new { controller = "Movies", action = "ByReleaseDate" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

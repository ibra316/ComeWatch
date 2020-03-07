using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ComeWatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            routes.MapMvcAttributeRoutes();
            // routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "Movie/release/{year}/{month}",
            //    defaults: new { controller = "Movie", action = "ByReleaseDate" },
            //     new { year = ("2120|2121"), month = @"\d{2}" }

            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //url2: "{controller}/{action}/{pageIndex}/{sortBy}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                 );
            routes.MapMvcAttributeRoutes();

        }
    }
}

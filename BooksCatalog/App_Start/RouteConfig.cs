using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BooksCatalog.Controllers;
using MvcCodeRouting;

namespace BooksCatalog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapCodeRoutes(typeof(BooksController), new CodeRoutingSettings
            {
                UseImplicitIdToken = true
            });

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Books", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

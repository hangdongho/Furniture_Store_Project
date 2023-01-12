using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BTL_CHNT
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BTL_CHNT.Controllers" }
            );
            routes.MapRoute(
               name: "Add Cart",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
               namespaces: new[] { "BTL_CHNT.Controllers" }
           );
            routes.MapRoute(
                name: "Cart",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BTL_CHNT.Controllers" }
            );
            routes.MapRoute(
                name: "Payment",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional },
                namespaces: new[] { "BTL_CHNT.Controllers" }
            );
            routes.MapRoute(
                name: "Payment Done",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional },
                namespaces: new[] { "BTL_CHNT.Controllers" }
            );

        }
    }
}

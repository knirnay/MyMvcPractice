using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMvcPractice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Route request for any file that has extension .axd will be ignored by the below line. This can be expained by adding tracing in the web config file under System.Web tag.
            // which generates trace.axd file if we remove the line below and try to browse the trace.axd file we will get HTTP 404 The resource cannot be found. This is because, this
            // axd file should not go in to the rount for mapping since, it cannot find this physical file because route mapping are done for controller and action methods. And for
            // this reason we need the below line.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HelloWorld", action = "GetMessage", id = UrlParameter.Optional }
            );
        }
    }
}

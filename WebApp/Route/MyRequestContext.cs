using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebApp.Route
{
    public class MyRequestContext
    {
        public MyRequestContext()
        {

        }

        public MyRequestContext(HttpContextBase httpContext,MyRoute routeData)
        {

        }


        public virtual HttpContextBase HttpContext { get; set; }

        public virtual MyRouteData MyRouteData { get; set; }
    }
}
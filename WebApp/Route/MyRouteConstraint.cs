using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebApp.Route
{
    public class MyRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            throw new NotImplementedException();
        }
    }
}
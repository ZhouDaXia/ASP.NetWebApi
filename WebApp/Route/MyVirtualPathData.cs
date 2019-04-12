using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebApp.Route
{
    public class MyVirtualPathData:VirtualPathData
    {
        public MyVirtualPathData(RouteBase route, string virtualPath) : base(route, virtualPath)
        {

        }

        public RouteValueDictionary DataTokens { get; }

        public RouteBase MyRoute { get; set; }

        public string VirtualPath { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebApp.Route
{
    /// <summary>
    ///  封装有关路由信息
    /// </summary>
    public class MyRouteData:RouteData
    {
        public MyRouteData()
        {

        }

        public MyRouteData(RouteBase route, IRouteHandler routeHandler)
        {

        }

        public string GetRequiredString(string valueName)
        {
            return "";
        }


        public RouteBase MyRoute { get; set; }

        public IRouteHandler RouteHandler { get; set; }
        /// <summary>
        /// DataTokens属性则是直接附加到Route上的自定义变量
        /// </summary>
        public RouteValueDictionary DataTokens { get; }
        /// <summary>
        /// Values属性中的路由变量是Route通过对请求URL的解析得到的
        /// </summary>
        public RouteValueDictionary Values { get; }
    }
}
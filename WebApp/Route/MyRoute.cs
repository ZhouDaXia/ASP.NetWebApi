using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebApp.Route
{
    /// <summary>
    ///  继承抽象类RouteBase
    /// </summary>
    public class MyRoute : RouteBase
    {
        public MyRoute()
        {
            base.RouteExistingFiles = true;
        }
        /// <summary>
        ///  路由模板模式与代表请求地址的URL进行匹配
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 路由变量列表与URL模板进行匹配
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            throw new NotImplementedException();
        }

        public MyRoute(string url, IRouteHandler routeHandler)
        {

        }

        public MyRoute(string url, RouteValueDictionary defaults, IRouteHandler routeHandler)
        {

        }

        public MyRoute(string url, RouteValueDictionary defaults, RouteValueDictionary constraints, IRouteHandler routeHandler)
        {

        }

        public MyRoute(string url, RouteValueDictionary defaults, RouteValueDictionary constrains, RouteValueDictionary datatokens, IRouteHandler routeHandler)
        {

        }
        /// <summary>
        ///  约束条件
        /// </summary>
        public RouteValueDictionary Constraints { get; set; }
        /// <summary>
        ///  默认值
        /// </summary>
        public RouteValueDictionary Defaults { get; set; }
        /// <summary>
        ///  附加值
        /// </summary>
        public RouteValueDictionary DataTokens { get; set; }

        public IRouteHandler RouteHandler { get; set; }

        public string Url { get; set; }
    }
}
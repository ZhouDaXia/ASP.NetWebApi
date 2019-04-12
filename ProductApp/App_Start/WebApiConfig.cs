using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            //属性路由
            config.MapHttpAttributeRoutes();
            //基于约定的路由
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

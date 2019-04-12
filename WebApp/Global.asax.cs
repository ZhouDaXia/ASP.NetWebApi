using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using WebApp.Route;
namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //相当于全局注册
            //MyRoute myRoute = new MyRoute();
            //RouteTable.Routes.Add(myRoute);

            //RouteBase->Route

            RouteValueDictionary defaults = new RouteValueDictionary {
                { "areacode","010"},
                { "days",2}
            };

            RouteValueDictionary constaints = new RouteValueDictionary {
                { "areacode",@"0\d{2,3}"},
                {"days",@"[1-3]" }
            };

            RouteValueDictionary dataTokens = new RouteValueDictionary {
                { "defaultCity","BeiJing"},
                {"defaultDays",2 }
            };

            RouteTable.Routes.MapPageRoute("default", "{areacode}/{days}", "~/weather.aspx", false, defaults, constaints, dataTokens);
        }
    }
}
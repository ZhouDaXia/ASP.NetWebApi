using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RouteLib
{
   public abstract class RouteBase
    {
        /// <summary>
        ///  是否对现有的物理文件实施路由默认值True
        /// </summary>
        public bool RouteExistingFiles { get; set; }
        /// <summary>
        ///  根据路由模板的模式与代表请求地址的URL进行匹配
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public abstract RouteData GetRouteData(HttpContextBase httpContext);
        /// <summary>
        /// 指定的路由变量列表与URL模板进行匹配
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public abstract VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values);
    }

    public class RouteData
    {
        public RouteData() { }
        public RouteData(RouteBase route, IRouteHandler routeHandler) { }

        public string GetRequiredString(string valueName);

        public RouteBase Route { get; set; }

        public IRouteHandler RouteHandler { get; set; }

        public RouteValueDictionary DataTokens { get; }

        public RouteValueDictionary Values { get; }

    }

    public interface IRouteHandler
    {
        IHttpHandler GetHttpHandler(RequestContext requestContext);
    }



    public class RouteValueDictionary : IDictionary<string, object>
    {
        public object this[string key]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<string> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<object> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public void Add(string key, object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(string key, out object value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }



    public class VirtualPathData
    {

    }


    public class RequestContext
    {

    }


    public class Route : RouteBase
    {
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            throw new NotImplementedException();
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            throw new NotImplementedException();
        }
    }

    public class RouteTable
    { }


    public class RouteCollection : Collection<RouteBase>
    { }






}

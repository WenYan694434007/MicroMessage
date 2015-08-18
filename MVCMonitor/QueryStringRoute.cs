using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVCMonitor
{
    public abstract class RouteBase
    {
        public abstract RouteData GetRouteData(HttpContextBase httpContext);
    }
    public class QueryStringRoute:RouteBase
    {
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            if (httpContext.Request.QueryString.AllKeys.Contains("controller") &&
                httpContext.Request.QueryString.AllKeys.Contains("action"))
            {
                string controller = httpContext.Request.QueryString["controller"];
                string action = httpContext.Request.QueryString["action"];
                IRouteHandler routeHandler=new MvcRouteHandler();
                return new RouteData(controller,action,routeHandler);
            }
            return null;
        }

    }

    public class MvcRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new MvcHandler(requestContext);
        }
    }

}
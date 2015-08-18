using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;


namespace MVCMonitor
{
    public class MvcHandler:IHttpHandler
    {
        public RequestContext RequestContext { get; private set; }

        public MvcHandler(RequestContext requestContext)
        {
            this.RequestContext = requestContext;
        }

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            System.Web.Routing.RouteData routeData = this.RequestContext.RouteData;
            
        }
    }
}
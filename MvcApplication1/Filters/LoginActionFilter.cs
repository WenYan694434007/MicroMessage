using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Filters
{
    public class LoginActionFilter : ActionFilterAttribute
    {
        public string LogMessage { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write(@"在Action执行之后执行" + LogMessage + "<br />");
            base.OnActionExecuted(filterContext);
        }
    }
}
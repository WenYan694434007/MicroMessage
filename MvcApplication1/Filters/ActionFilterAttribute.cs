using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public abstract class ActionFilterAttribute : FilterAttribute, IActionFilter, IResultFilter
    {

        public virtual void OnActionExecuting(ActionExecutingContext filterContext) { }

        public virtual void OnActionExecuted(ActionExecutedContext filterContext) { }


        public virtual void OnResultExecuting(ResultExecutingContext filterContext) { }


        public virtual void OnResultExecuted(ResultExecutedContext filterContext) { }

    }




}
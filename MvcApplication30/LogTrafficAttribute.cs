using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication30.Controllers;


namespace MvcApplication30
{
    public class LogTrafficAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            TrafficManager.Log(filterContext.HttpContext.Request.UserAgent);
            base.OnActionExecuting(filterContext);
        }
    }
}
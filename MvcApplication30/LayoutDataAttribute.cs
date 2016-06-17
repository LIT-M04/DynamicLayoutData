using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication30
{
    public class LayoutDataAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.Number = GetRandomNumber();
            base.OnActionExecuting(filterContext);
        }

        private int GetRandomNumber()
        {
            return new Random().Next(1, 100000);
        }
    }
}
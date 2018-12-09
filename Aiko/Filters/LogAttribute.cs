using System.Web.Mvc;

namespace Aiko.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        //Called by the ASP.NET MVC framework before the action method executes
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        //Called by the ASP.NET MVC framework after the action method executes
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        //Called by the ASP.NET MVC framework before the action result executes (for instance before a view renders)
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        //Called by the ASP.NET MVC framework after the action result executes
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}
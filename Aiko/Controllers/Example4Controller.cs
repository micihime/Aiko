using Aiko.Filters;
using System.Web.Mvc;

namespace Aiko.Controllers
{
    //Action Filter
    // - apply pre and post processing logic to a controller action and its result
    // - used to apply cross-cutting logic - logic that has to execute across multiple controller actions but you don't want to duplicate the code inside of 
    //each individual controller
    // - can be applied to action, controller or to whole app (in Global.asax.cs -> FilterConfig.cs)

    //OutputCache
    // - tells the run time that it's allowed to cash the final output of some action and to use that cashed result to service future requests
    // - can dramatically increase the throughput and scalability of an application
    //ValidateInput
    // - turn off request validation and allow dangerous input
    //Authorize
    // - ensures that a user is logged in, perhaps in a specific role, before the action is allowed to process that user's request
    //ValidateAntiForgeryToken
    // - helps prevent cross site request forgeries
    //HandleError
    // - can specify a view to render in the event of an unhandled exception
    public class Example4Controller : Controller
    {
        // GET: Example4
        [Log]
        //URL to the browser -> OnActionExecuting -> action method -> OnActionExecuted -> View is rendered -> OnResultExecuted
        public ActionResult Index()
        {
            int a = 5 * 5;
            //throw new Exception();
            return View();
        }
    }
}
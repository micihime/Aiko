using System.Web.Mvc;

namespace Aiko.Controllers
{
    //Action Selector attributes
    // - when the mvc fw is selecting one of the controller's public methods to invoke as an action it will use any action selector attributes 
    //(that might be present) to find the correct action to invoke

    //[ActionName("Alias")] 
    // - specifies the action name for the method
    // - action is accessible by its action name specified here (no longer by its method name - creating aliases for actions)
    //[HttpGet] 
    // - specify the http verb that is allowed to reach a particular action
    // - action method is only reachable with the specified type of HTTP request 
    public class Example3Controller : Controller
    {
        // GET: Example3
        [HttpGet] //default action selector
        public ActionResult Index()
        {
            return View();
        }

        //not accessible by /Example3/Something, only by /Example3/lalala
        [ActionName("lalala")]
        public ActionResult Something()
        {
            return View(); //searches for lalala view
        }

        // - if there are 2 action methods with the same name but different signature, the fw throws an error 
        //The current request for action 'Contact' on controller type 'HomeController' is ambiguous between the following action methods:
        //System.Web.Mvc.ActionResult Contact() on type Aiko.Controllers.HomeController
        //System.Web.Mvc.ActionResult Contact(Int32) on type Aiko.Controllers.HomeController
        // - different HTTP verbs can be used to make it possible - one method responds to one HTTP verb and the other to the second verb
        //public ActionResult Index(int id)
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}
using System;
using System.Web.Mvc;

namespace Aiko.Controllers
{
    //Action Result
    // - type of the object that is produced in return from an action
    // - many classes derive from it - all of them have a factory method that can be invoked to construct the particular result

    //ContentResult
    // - returns a string literal
    //EmptyResult
    // - no response
    //FileContentResult/FilePathResult/FileStreamResult
    // - return the contents of a file
    //HttpUnauthorizedResult
    // - returns an HTTP 403 status
    //JavaScriptResult
    // - returns a script to execute
    //JsonResult
    // - returns data in JSON format
    //RedirectResult
    // - redirects the client to a new URL
    //RedirectToRouteResult
    // - redirect to another action or another controller's action
    //ViewResult/PartialViewResult
    // - response is the responsibility of a view engine
    public class Example2Controller : Controller
    {
        // GET: Recipe
        public ActionResult Index()
        {
            return View();
        }

        //returns 301 status code
        public ActionResult PermanentRedirect()
        {
            return RedirectPermanent("https://pinchofyum.com/");
        }

        //returns 302 status code
        public ActionResult TemporaryRedirect()
        {
            //redirect to action in this controller
            return RedirectToAction("Index");
        }

        //returns 302 status code
        public ActionResult TemporaryRedirect1()
        {
            //redirect to action in this app

            //coordinates with routing engine - if I want to go to Index action in Home controller, what would the action look like?
            //- the routing engine returns the URL
            return RedirectToAction("Index", "Home");
        }

        //returns 302 status code
        public ActionResult TemporaryRedirect2()
        {
            //redirect to action in this app

            //coordinates with routing engine 
            //possible to pass along parameters in an anonymously-typed object
            return RedirectToAction("Search", "Example1", new { name = "french" });
        }

        //returns 302 status code
        public ActionResult TemporaryRedirect3()
        {
            //redirect to action in this app

            //coordinates with routing engine 
            //call by route name and pass action name and controller as anonymously-typed object
            return RedirectToRoute("Default", new { controller = "Home", action = "About" });
        }

        public ActionResult FileResult()
        {
            //tilde represents the root of the application - it's common to use a tilde everywhere you specify a path (within the app)
            //because without the tilde you have to know the name of the directory where the app is deployed in order to hand out correct links
            return File(Server.MapPath("~/Content/site.css"), "text/css");
        }

        public ActionResult JsonResult(string message)
        {
            return Json(new { Message = message, SomeProp = 123, Today = DateTime.Now.Date }, JsonRequestBehavior.AllowGet);
        }
    }
}
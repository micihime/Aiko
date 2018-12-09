using System.Web.Mvc;

namespace Aiko.Controllers
{
    //every public method is URL-addressable (depending on routing settings)
    public class Example1Controller : Controller
    {
        // GET: Cuisine
        // MVC fw is looking into different places to search for the input parameter (inspectiong route data, query string and posted form values)
        // - I can get here by /Cuisine/french or also by query string Cuisine?name=french
        public ActionResult Search(string name)
        {
            //you never directly inspect route data or query string - it is taken care of by MVC fw 
            //RouteData.Values
            //Request.QueryString

            //encoding value because we are returning string content - if the user snuck through some malicious sctipt tag or something
            var message = Server.HtmlEncode(name); //it will render as text and it will prevent a cross-site scripting attack (Razor engine does this automatically)

            return Content(message); //string literal
        }
    }
}
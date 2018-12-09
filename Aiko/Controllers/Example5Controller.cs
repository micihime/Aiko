using Aiko.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aiko.Controllers
{
    public class Example5Controller : Controller
    {
        private List<Example> exampleList = new List<Example>
        {
            new Example { Name = "Zlatovlaska", City = "Za siedmymi horami", Country = "Neverland", Rating = 5 },
            new Example { Name = "Sipova Ruzenka", City = "Za siedmymi dolami", Country = "Neverland", Rating = 4 },
            new Example { Name = "Kocur v cizmach", City = "Kde sa voda sypala", Country = "Neverland", Rating = 10 },
            new Example { Name = "Ententiky", City = "A piesok sa lial", Country = "Neverland", Rating = 7 },
            new Example { Name = "2 spendliky", City = "<script>alert('xss');</script>", Country = "Atlantida", Rating = 1 } //Razor HTML encodes data by default
        };

        // GET: Example5
        public ActionResult Index()
        {
            return View(exampleList);
        }
    }
}
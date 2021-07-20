using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNet.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            // return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            ViewBag.person = name;
            return View();
        }
    }
}

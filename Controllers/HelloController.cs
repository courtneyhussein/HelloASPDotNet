using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNet.Controllers
{
    [Route("/helloworld")]
    public class HelloController1 : Controller
    {
       

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    string html = "<form method='post' action='/helloworld'>" + 
        //        "<input type='text' name='name' />" + 
        //        "<input type='submit' value='Greet Me!' />" +
        //        "</form>";

        //    return Content(html, "text/html");
        //}

        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='1' selected>English</option><option value='2'>Pashto</option>" +
                "<option value='3'>Arabic</option><option value='4'>French</option><option value='5'>Spanish</option></select>" +
                "<input type='submit' value='greet me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        //[HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Name(int language, string name = "World")
        {
            
            if (language == 1)
            {
                return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            }
            else if (language == 2)
            {
                return Content("<h1>Puh kheir raghulay, " + name + "!</h1>", "text/html");
            }
            else if (language == 3)
            {
                return Content("<h1>Salaam, " + name + "!</h1>", "text/html");
            }
            else if (language == 4)
            {
                return Content("<h1>Bonjour, " + name + "!</h1>", "text/html");
            }
            else
            {
                return Content("<h1>Buenas dias, " + name + "!</h1>", "text/html");
            }

        }

        //[HttpGet("welcome/{name?}")]
        //[HttpPost]
        //public IActionResult Name(string name = "World")
        //{
        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");

        //}
    }
}

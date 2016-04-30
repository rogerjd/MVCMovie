using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Controllers
{
    public class HelloWorldController: Controller
    {

        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome/
        public string Welcome(string name)
        {
            return HtmlEncoder.Default.HtmlEncode("Hello " + name + ", NumTimes is: "   );

        }

        //GET: /HelloWorld/Welcome/
        public string Tst()
        {
            return "this is tst";

        }

    }
}

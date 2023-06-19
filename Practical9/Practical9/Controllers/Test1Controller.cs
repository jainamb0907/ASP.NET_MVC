using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Practical9.Controllers
{
    public class DisplayStringController : Controller
    {
        // GET: Test1
        public ActionResult Index()
        {
            ViewBag.message = "Hello World";
            return View();
        }
    }
}
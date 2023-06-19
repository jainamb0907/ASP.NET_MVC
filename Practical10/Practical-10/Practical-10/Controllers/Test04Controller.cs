using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using Practical_10.Filters;
using System.Collections.Generic;

namespace Practical_10.Controllers
{
    public class Test04Controller : Controller
    {
        
        public ActionResult test4()
        {
            return View();
        }

        [HttpPost]
        [DivideByZeroExceptionFilter]
        public ActionResult test4(int num1, int num2)
        {
            int result = num1 / num2;
            ViewBag.Result = result;

            return View();
        }
    }
}
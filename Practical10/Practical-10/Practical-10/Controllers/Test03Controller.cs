using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Practical_10.Controllers
{
    public class Test03Controller : Controller
    {
        // GET: Test03
        [OutputCache(Duration = 300, VaryByParam = "*")]
        public ActionResult CurrentDateTime()
        {
            return View(DateTime.Now);
        }
    }
}
using Practical_15.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_15.Controllers
{
    public class LoginController : Controller
    {
        private AuthenticationDB db = new AuthenticationDB();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login user)
        {
            var existingUser = db.login.FirstOrDefault(u => u.userName == user.userName && u.password == user.password);

            if (existingUser != null)
            {
                
                System.Web.Security.FormsAuthentication.SetAuthCookie(existingUser.userName, false);
                return RedirectToAction("Index", "Home"); 
            }


            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }
        // POST: Account/Register
        [HttpPost]
        public ActionResult Register(Login user)
        {
            if (ModelState.IsValid)
            {
                    db.login.Add(user);
                    db.SaveChanges();
                
                return RedirectToAction("Login"); 
            }

            return View(user);
        }
        public ActionResult Register()
        {
            return View();
        }

    }
}
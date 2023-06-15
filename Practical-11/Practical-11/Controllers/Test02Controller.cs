using Practical_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_11.Controllers
{
    public class Test02Controller : Controller
    {
      
        private static List<User> userList = new List<User>();

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            user.Id = userList.Count + 1;
            userList.Add(user);

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View(userList);
        }

        public ActionResult Edit(int id)
        {
            User user = userList.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Edit", user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            User existingUser = userList.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser == null)
            {
                return HttpNotFound();
            }

            existingUser.Name = user.Name;
            existingUser.DOB = user.DOB;
            existingUser.Address = user.Address;

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            User user = userList.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Delete", user);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = userList.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            userList.Remove(user);

            return RedirectToAction("Index");
        }
    }

}

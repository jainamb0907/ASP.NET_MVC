using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Practical_13.Models;

namespace Practical_13.Controllers
{
    public class Test02Controller : Controller
    {
        private EmployeeDB db = new EmployeeDB();

        // GET: Test02
        public ActionResult Index()
        {
            var emp = db.Emp.Include(e => e.Designation);
            return View(emp.ToList());
        }

        // GET: Test02/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeTest02 employeTest02 = db.Emp.Find(id);
            if (employeTest02 == null)
            {
                return HttpNotFound();
            }
            return View(employeTest02);
        }

        // GET: Test02/Create
        public ActionResult Create()
        {
            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "DesignationName");
            return View();
        }

        // POST: Test02/Create
  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,MiddleName,LastName,DOB,MobileNumber,Address,salary,DesignationId")] EmployeTest02 employeTest02)
        {
            if (ModelState.IsValid)
            {
                db.Emp.Add(employeTest02);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "DesignationName", employeTest02.DesignationId);
            return View(employeTest02);
        }

        // GET: Test02/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeTest02 employeTest02 = db.Emp.Find(id);
            if (employeTest02 == null)
            {
                return HttpNotFound();
            }
            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "DesignationName", employeTest02.DesignationId);
            return View(employeTest02);
        }

        // POST: Test02/Edit/5

        [HttpPost]

        public ActionResult Edit([Bind(Include = "Id,FirstName,MiddleName,LastName,DOB,MobileNumber,Address,salary,DesignationId")] EmployeTest02 employeTest02)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeTest02).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "DesignationName", employeTest02.DesignationId);
            return View(employeTest02);
        }

        // GET: Test02/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeTest02 employeTest02 = db.Emp.Find(id);
            if (employeTest02 == null)
            {
                return HttpNotFound();
            }
            return View(employeTest02);
        }

        // POST: Test02/Delete/5
        [HttpPost, ActionName("Delete")]
        
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeTest02 employeTest02 = db.Emp.Find(id);
            db.Emp.Remove(employeTest02);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

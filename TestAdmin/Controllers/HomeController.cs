using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAdmin.Controllers
{
    public class HomeController : Controller
    {
        private CommonCRMEntities db = new CommonCRMEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var employee = db.Employee.Include(e => e.Department).Include(e => e.Role);
            return View(employee.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            ViewBag.empDepId = new SelectList(db.Department, "depId", "depName");
            ViewBag.empRoleId = new SelectList(db.Role, "roleId", "roleName");
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.empDepId = new SelectList(db.Department, "depId", "depName", employee.empDepId);
            ViewBag.empRoleId = new SelectList(db.Role, "roleId", "roleName", employee.empRoleId);
            return View(employee);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.empDepId = new SelectList(db.Department, "depId", "depName", employee.empDepId);
            ViewBag.empRoleId = new SelectList(db.Role, "roleId", "roleName", employee.empRoleId);
            return View(employee);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.empDepId = new SelectList(db.Department, "depId", "depName", employee.empDepId);
            ViewBag.empRoleId = new SelectList(db.Role, "roleId", "roleName", employee.empRoleId);
            return View(employee);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employee.Find(id);
            db.Employee.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
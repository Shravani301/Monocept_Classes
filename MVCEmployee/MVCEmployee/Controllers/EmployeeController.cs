using MVCEmployee.Data;
using MVCEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        private EmpContext _context;
        public EmployeeController()
        {
            _context = new EmpContext();
        }
        // GET: Employee
        
        public ActionResult Index()
        {
            return View(_context.employees);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var emp = _context.employees.Where(employee => employee.Id == id).FirstOrDefault();
            return View(emp);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            _context.employees.Add(emp);
            _context.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var emp=_context.employees.Where(employee=>employee.Id == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var emp1 = _context.employees.Where(employee => employee.Id == emp.Id).FirstOrDefault();
            emp1.Name = emp.Name;
            emp1.Email = emp.Email;
            _context.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var emp=_context.employees.Where(employee=>employee.Id==id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            var emp=_context.employees.Where(e=>e.Id==employee.Id).FirstOrDefault();
            _context.employees.Remove(emp);
            _context.SaveChanges();
            return View();
        }

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteRecord(int id)
        //{
        //    var emp = _context.employees.Where(e => e.Id == id).FirstOrDefault();
        //    _context.employees.Remove(emp);
        //    _context.SaveChanges();
        //    return View();
        //}

    }
}
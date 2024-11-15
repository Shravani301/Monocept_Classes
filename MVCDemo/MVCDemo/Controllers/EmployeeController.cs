using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public static List<Employee> employees=new List<Employee>()
        {
            new Employee(){Id=101,Name="Shravani", Email="shravani@gmail.com" },
            new Employee(){Id=102, Name="Shirisha", Email="shirisha@gmail.com" },
            new Employee(){Id=103, Name="Chandana", Email="chandana@gmail.com"},
            new Employee(){ Id=104, Name="Manisha", Email="manisha@gmail.com"},
        };
        public ActionResult Index()
        {
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            var emp = employees.Where(employee=>employee.Id == id).FirstOrDefault();
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
            employees.Add(emp);
            return View();  
        }

        public ActionResult Edit(int id)
        {
            var emp=employees.Where(e=>e.Id == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var oldEmp = employees.Where(employee => employee.Id == emp.Id).FirstOrDefault();
            oldEmp.Name = emp.Name;
            oldEmp.Email = emp.Email;
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var emp = employees.Where(e => e.Id == id).FirstOrDefault();
            return View(emp);
        }

        [HttpPost]
        public ActionResult Delete(Employee emp)
        {
            var employee = employees.Where(e => e.Id == emp.Id).FirstOrDefault();
            employees.Remove(employee);
            return View();
        }

        //public Employee GetEmployee()
        //{
        //    return new Employee() {Id=101,Name="shravani",Email="shravani@gmail.com"};
        //}
    }
}
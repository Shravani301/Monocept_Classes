using Microsoft.AspNetCore.Mvc;
using MVCWithCore.Models;
using System.Diagnostics;

namespace MVCWithCore.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> employees;
        public EmployeeController()
        {
            employees = new List<Employee>()
            {
                new Employee(){ Id=101,Name="shravani",Email="shravani@gmail.com"},
                new Employee(){ Id=102, Name="shirisha",Email="shirisha@gmail.com"},
            };
        }
        public IActionResult Index()
        {
            return Content("Employee View");
        }
        public IActionResult GetAllEmployees()
        {
            return View(employees);
        }
    }
}

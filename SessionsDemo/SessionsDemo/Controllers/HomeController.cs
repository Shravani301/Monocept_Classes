using SessionsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionsDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var student = new Student()
            {
                Id = 1,
                Name = "shravani",
                Email = "shravani@gmail.com",
            };
            int randomNumber = new Random().Next(1,10);
            if(randomNumber >=6)
                return Json (student, JsonRequestBehavior.AllowGet);
            return HttpNotFound("Not a valid number" + randomNumber);
        }

        public ActionResult StudentCollegesList()
        { 
            List<Student> students = new List<Student>()
            {
                new Student(){Id=101, Name="shravani",Email="shravani@gmail.com"},
                new Student(){Id=102, Name="shirisha", Email="shirisha@gmail.com"},
                new Student(){ Id=103, Name="Sneha", Email="sneha@gmail.com"}
            };
            List<College> colleges = new List<College>()
            {
                new College(){Id=11,Name="C1",Location="Hyd"},
                new College(){ Id=22, Name="C2",Location="Wgl"},
                new College(){ Id=33, Name="C3",Location="Hyd"}
            };
            var studentCollegeData = new StudentCollegeVM() { Students = students, Colleges = colleges };

            return View(studentCollegeData);
        }
    }
}
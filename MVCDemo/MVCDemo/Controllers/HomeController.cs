using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();  
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }


        //public string Index()
        //{
        //    return "Hello Welcome to MVC";
        //}
        //public string Welcome(string name)
        //{
        //    return "Hai " + name;
        //}
    }
}
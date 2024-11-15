using LoginVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login loginVM)
        {
            //if (string.IsNullOrEmpty(loginVM.UserName) || string.IsNullOrEmpty(loginVM.Password))
            //{
            //    loginVM.ErrorMessage = "Username and Password must be entered";
            //    return View();
            //}

            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            Session["UName"]=loginVM.UserName;
            return RedirectToAction("Index", "Welcome");
        }
    }
}
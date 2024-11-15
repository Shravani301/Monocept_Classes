using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPassingData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewDataAccess()
        {
            ViewData["Message"] = "ViewData transfers data from the Controller to View, not vice-versa\n" +
                "ViewData is a dictionary type.\nViewData's life only lasts during the current HTTP request. ViewData values will be cleared if redirection occurs.\nViewData value must be typecast to an appropriate type before using it.";
            return View();
        }
        public ActionResult ViewBagAccess()
        {
            ViewBag.Message = "ViewBag is also similar to ViewData.\n" +
                " It is used to transfer data from Controller to View.\n" +
                " It is a type of Dynamic object, that means you can add new fields to viewbag dynamically and access these fields in the View. \n" +
                "You need to initialize the object of viewbag at the time of creating new fields.";
            return View();
        }
        public ActionResult TempDataAccess()
        {
            TempData["Message"] = "TempData is a dictionary object derived from TempDataDictionary.\n" +
                "It is for subsequent HTTP requests; unlike ViewBag and ViewData, those stay only for current request.\n" +
                "It can be used to maintain data between controller actions as well as redirects.";
            return View();
        }
        public ActionResult TempDataDisplay()
        {
            string message=TempData["Message"].ToString();
            ViewBag.Message1= message;
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id=1)
        {
            ViewBag.NumberOfTimes = id;
            return View();
        }

        public ActionResult About(string myName = "Bob", int myNumber = 1)
        {
            ViewBag.Message = "Hello " + myName + " and you typed in the number " + myNumber ;

            return View();
        }

        public ActionResult Contact(int id = 5)
        {
            ViewBag.Message = "You Choose " + id;

            return View();
        }
    }
}
using PartyInvite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult rsvpForm()
        {

            return View();
        }

        [HttpPost]
        public ViewResult rsvpForm(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", response);

            } else
            {
                return View();
            }
            
        }
    }
}
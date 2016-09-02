using movieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace movieDB.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBNishEntities db = new MoviesDBNishEntities();
        // GET: Home
        public ActionResult Index()
        {
            //linq query
            var movies = from m in db.Movies
                         select m;



            return View(movies);
        }
    }
}
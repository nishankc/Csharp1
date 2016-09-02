using MVCRecords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRecords.Controllers
{
    public class HomeController : Controller
    {
        List<Album> albums = new List<Album>();
        // GET: Home
        public ActionResult Index()
        {
            Album album1 = new Album("Dark Side of the Moon", "Pink Floyd", "Vinyl", 9.99m);
            albums.Add(album1);
            Album album2 = new Album("Dark Side of the Sun", "Red Floyd", "CD", 9.99m);
            albums.Add(album2);
            Album album3 = new Album("Dark Side of the Earth", "Yellow Floyd", "Tape", 9.99m);
            albums.Add(album3);
            Album album4 = new Album("Light Side of the Table", "Table Floyd", "MicroDisc", 9.99m);
            albums.Add(album4);


            return View(albums);
        }
    }
}
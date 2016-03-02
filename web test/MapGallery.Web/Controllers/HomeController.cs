using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MapGallery.Web.Models;

namespace MapGallery.Web.Controllers
{
    public class HomeController : Controller
    {

        GalleryContext db = new GalleryContext();

        public ActionResult Index()
        {
            IEnumerable<Country> countries = db.Countries;
            IEnumerable<City> cities = db.Cities;
            IEnumerable<Continent> continents = db.Continents;

            ViewBag.Countries = countries;
            ViewBag.Continents = continents;
            ViewBag.Cities = cities;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
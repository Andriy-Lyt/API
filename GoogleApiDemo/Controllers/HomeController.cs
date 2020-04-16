using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleApiDemo.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Returns location of Vaccinations centers
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public ActionResult GetInfo(string choice)
        {
            if (choice == "Centers")
            {
                return Json(new[]
                {
                    new Location {Latitude = 50.4501, Longitude = 30.5234, Title = "Kiev" },                    
                    new Location {Latitude = 45.5017, Longitude = -73.5673, Title = "Monreal" },                    
                    new Location {Latitude = 35.6804, Longitude = 139.7690, Title = "Tokyo" },
                }, JsonRequestBehavior.AllowGet);
            }

            // Returms location of Hospitals
            if (choice == "Hospitals")
            {
                return Json(new[]
                {
                    new Location {Latitude = 12, Longitude = 30, Title = "Hospital 1" },
                    new Location {Latitude = 50, Longitude = 83, Title = "Hospital 2" },
                    new Location {Latitude = 44, Longitude = -74, Title = "Hospital 3" },
                    new Location {Latitude = 43, Longitude = -72, Title = "Hospital 4" },
                }, JsonRequestBehavior.AllowGet);
            }

            return new EmptyResult();
        }
    }
}
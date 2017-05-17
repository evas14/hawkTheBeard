using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HawkTheBeard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hawk the Beard";

            return View();
        }

        public ActionResult More()
        {
            ViewBag.Message = "Hawk the Beard";

            return View();
        }

        public ActionResult TermsAndConditions()
        {
            ViewBag.Message = "Hawk the Beard";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BookGoldenCircle()
        {
            ViewBag.Message = "Here you can book your trip.";

            return View();
        }

        public ActionResult BookSnaefellsnes()
        {
            ViewBag.Message = "Here you can book your trip.";

            return View();
        }

        public ActionResult BookSouthCoast()
        {
            ViewBag.Message = "Here you can book your trip.";

            return View();
        }

        public ActionResult BookPrivate()
        {
            ViewBag.Message = "Here you can book your trip.";

            return View();
        }
    }
}
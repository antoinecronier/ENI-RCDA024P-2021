using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module4_Demo1.Controllers
{
    [RoutePrefix("welcome")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("{nom}/{prenom}")]
        public ActionResult Welcome(string nom, string prenom)
        {
            ViewBag.Nom = nom;
            ViewBag.Prenom = prenom;

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module4_Demo1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Message = "Mon message";
            return View();
        }

        public ActionResult Test1()
        {
            TempData["key1"] = "valeur de key1";

            return View();
        }
    }
}
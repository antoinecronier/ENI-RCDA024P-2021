using Module5_Demo1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5_Demo1.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Mon message";
            Debug.Write(TempData["key2"]);

            MessageViewModel vm = new MessageViewModel() { MyProperty1 = 10, MyProperty2 = "welcome from vm" };

            return View(vm);
        }

        public ActionResult Test1()
        {
            TempData["key1"] = "valeur de key1";

            return View();
        }

        public ActionResult Test2()
        {
            TempData["key2"] = "valeur de key2";

            return RedirectToAction("Index");
        }
    }
}
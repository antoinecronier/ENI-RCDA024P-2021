using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Module6_Tp1_ASP.Data;
using Module6_Tp1_BO.Entities;

namespace Module6_Tp1_ASP.Controllers
{
    public class ArtMartiauxController : Controller
    {
        private Module6_Tp1_ASPContext db = new Module6_Tp1_ASPContext();

        // GET: ArtMartiaux
        public ActionResult Index()
        {
            return View(db.ArtMartiaux.ToList());
        }

        // GET: ArtMartiaux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtMartial artMartial = db.ArtMartiaux.Find(id);
            if (artMartial == null)
            {
                return HttpNotFound();
            }
            return View(artMartial);
        }

        // GET: ArtMartiaux/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArtMartiaux/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom")] ArtMartial artMartial)
        {
            if (ModelState.IsValid)
            {
                db.ArtMartiaux.Add(artMartial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artMartial);
        }

        // GET: ArtMartiaux/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtMartial artMartial = db.ArtMartiaux.Find(id);
            if (artMartial == null)
            {
                return HttpNotFound();
            }
            return View(artMartial);
        }

        // POST: ArtMartiaux/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nom")] ArtMartial artMartial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artMartial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artMartial);
        }

        // GET: ArtMartiaux/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtMartial artMartial = db.ArtMartiaux.Find(id);
            if (artMartial == null)
            {
                return HttpNotFound();
            }
            return View(artMartial);
        }

        // POST: ArtMartiaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArtMartial artMartial = db.ArtMartiaux.Find(id);
            db.ArtMartiaux.Remove(artMartial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

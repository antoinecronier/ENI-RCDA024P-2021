using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Module6_Tp1_ASP.Data;
using Module6_Tp1_ASP.Models;
using Module6_Tp1_BO.Entities;

namespace Module6_Tp1_ASP.Controllers
{
    public class SamouraisController : Controller
    {
        private Module6_Tp1_ASPContext db = new Module6_Tp1_ASPContext();

        // GET: Samourais
        public ActionResult Index()
        {
            return View(db.Samourais.ToList());
        }

        // GET: Samourais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
            if (samourai == null)
            {
                return HttpNotFound();
            }
            return View(samourai);
        }

        // GET: Samourais/Create
        public ActionResult Create()
        {
            SamouraiViewModel vm = new SamouraiViewModel();
            vm.Armes = db.Armes.Where(x => !db.Samourais.Select(y => y.Arme.Id).Contains(x.Id)).ToList();
            vm.ArtMartiaux = db.ArtMartiaux.ToList();
            return View(vm);
        }

        // POST: Samourais/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SamouraiViewModel vm)
        {
            if (ModelState.IsValid)
            {
                vm.Samourai.Arme = db.Armes.Find(vm.ArmeId);
                
                if (vm.ArtMartiauxIds != null)
                {
                    vm.Samourai.ArtMartiaux = db.ArtMartiaux.Where(x => vm.ArtMartiauxIds.Contains(x.Id)).ToList();
                }
                
                db.Samourais.Add(vm.Samourai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            vm.Armes = db.Armes.Where(x => !db.Samourais.Select(y => y.Arme.Id).Contains(x.Id)).ToList();
            vm.ArtMartiaux = db.ArtMartiaux.ToList();
            return View(vm);
        }

        // GET: Samourais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
            if (samourai == null)
            {
                return HttpNotFound();
            }

            SamouraiViewModel vm = new SamouraiViewModel();
            vm.Armes = db.Armes.Where(x => !db.Samourais.Where(y => y.Id != id).Select(y => y.Arme.Id).Contains(x.Id)).ToList();
            vm.ArtMartiaux = db.ArtMartiaux.ToList();
            vm.Samourai = samourai;
            vm.ArmeId = samourai.Arme?.Id;
            vm.ArtMartiauxIds = samourai.ArtMartiaux.Select(x => x.Id).ToList();
            return View(vm);
        }

        // POST: Samourais/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SamouraiViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Samourai samourai = db.Samourais.Include(x => x.Arme).Include(x => x.ArtMartiaux).SingleOrDefault(x => x.Id == vm.Samourai.Id);
                samourai.Nom = vm.Samourai.Nom;
                samourai.Force = vm.Samourai.Force;
                samourai.Arme = db.Armes.Find(vm.ArmeId);

                if (vm.ArtMartiauxIds != null)
                {
                    samourai.ArtMartiaux = db.ArtMartiaux.Where(x => vm.ArtMartiauxIds.Contains(x.Id)).ToList();
                }
                else
                {
                    samourai.ArtMartiaux = null;
                }
                
                db.Entry(samourai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            vm.Armes = db.Armes.Where(x => !db.Samourais.Where(y => y.Id != vm.Samourai.Id).Select(y => y.Arme.Id).Contains(x.Id)).ToList();
            vm.ArtMartiaux = db.ArtMartiaux.ToList();
            return View(vm);
        }

        // GET: Samourais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
            if (samourai == null)
            {
                return HttpNotFound();
            }
            return View(samourai);
        }

        // POST: Samourais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Samourai samourai = db.Samourais.Find(id);
            db.Samourais.Remove(samourai);
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

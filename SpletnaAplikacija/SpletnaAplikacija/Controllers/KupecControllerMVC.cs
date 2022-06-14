using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpletnaAplikacija.Models;

namespace SpletnaAplikacija.Controllers
{
    public class KupecControllerMVC : Controller
    {
        private BazaZaVajeEntities db = new BazaZaVajeEntities();

        // GET: KupecControllerMVC
        public ActionResult Index()
        {
            return View(db.KUPEC.ToList());
        }

        // GET: KupecControllerMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KUPEC kupec = db.KUPEC.Find(id);
            if (kupec == null)
            {
                return HttpNotFound();
            }
            return View(kupec);
        }

        // GET: KupecControllerMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KupecControllerMVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KUP_KODA,KUP_PRIIMEK,KUP_IME,KUP_ZAČ,KUP_PODROČJE,KUP_TELEFON,KUP_STANJE")] KUPEC kupec)
        {
            if (ModelState.IsValid)
            {
                db.KUPEC.Add(kupec);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kupec);
        }

        // GET: KupecControllerMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KUPEC kupec = db.KUPEC.Find(id);
            if (kupec == null)
            {
                return HttpNotFound();
            }
            return View(kupec);
        }

        // POST: KupecControllerMVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KUP_KODA,KUP_PRIIMEK,KUP_IME,KUP_ZAČ,KUP_PODROČJE,KUP_TELEFON,KUP_STANJE")] KUPEC kupec)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kupec).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kupec);
        }

        // GET: KupecControllerMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KUPEC kupec = db.KUPEC.Find(id);
            if (kupec == null)
            {
                return HttpNotFound();
            }
            return View(kupec);
        }

        // POST: KupecControllerMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KUPEC kupec = db.KUPEC.Find(id);
            db.KUPEC.Remove(kupec);
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

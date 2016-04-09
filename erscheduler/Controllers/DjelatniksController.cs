using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using erscheduler.Models;

namespace erscheduler.Controllers
{
    public class DjelatniksController : Controller
    {
        private erschedulerContext db = new erschedulerContext();

        // GET: Djelatniks
        public ActionResult Index()
        {
            return View(db.Djelatniks.ToList());
        }

        // GET: Djelatniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Djelatnik djelatnik = db.Djelatniks.Find(id);
            if (djelatnik == null)
            {
                return HttpNotFound();
            }
            return View(djelatnik);
        }

        // GET: Djelatniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Djelatniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OIB,Name,Surname,Birth_Date,Adress,Hometown,Home_Telephone,Mobile_Phone,Note")] Djelatnik djelatnik)
        {
            if (ModelState.IsValid)
            {
                db.Djelatniks.Add(djelatnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(djelatnik);
        }

        // GET: Djelatniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Djelatnik djelatnik = db.Djelatniks.Find(id);
            if (djelatnik == null)
            {
                return HttpNotFound();
            }
            return View(djelatnik);
        }

        // POST: Djelatniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OIB,Name,Surname,Birth_Date,Adress,Hometown,Home_Telephone,Mobile_Phone,Note")] Djelatnik djelatnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(djelatnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(djelatnik);
        }

        // GET: Djelatniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Djelatnik djelatnik = db.Djelatniks.Find(id);
            if (djelatnik == null)
            {
                return HttpNotFound();
            }
            return View(djelatnik);
        }

        // POST: Djelatniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Djelatnik djelatnik = db.Djelatniks.Find(id);
            db.Djelatniks.Remove(djelatnik);
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

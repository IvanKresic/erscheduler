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
    public class PlaceOfLivingsController : Controller
    {
        private erschedulerContext db = new erschedulerContext();

        // GET: PlaceOfLivings
        public ActionResult Index()
        {
            return View(db.PlaceOfLivings.ToList());
        }

        // GET: PlaceOfLivings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaceOfLiving placeOfLiving = db.PlaceOfLivings.Find(id);
            if (placeOfLiving == null)
            {
                return HttpNotFound();
            }
            return View(placeOfLiving);
        }

        // GET: PlaceOfLivings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaceOfLivings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] PlaceOfLiving placeOfLiving)
        {
            if (ModelState.IsValid)
            {
                db.PlaceOfLivings.Add(placeOfLiving);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(placeOfLiving);
        }

        // GET: PlaceOfLivings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaceOfLiving placeOfLiving = db.PlaceOfLivings.Find(id);
            if (placeOfLiving == null)
            {
                return HttpNotFound();
            }
            return View(placeOfLiving);
        }

        // POST: PlaceOfLivings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] PlaceOfLiving placeOfLiving)
        {
            if (ModelState.IsValid)
            {
                db.Entry(placeOfLiving).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(placeOfLiving);
        }

        // GET: PlaceOfLivings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaceOfLiving placeOfLiving = db.PlaceOfLivings.Find(id);
            if (placeOfLiving == null)
            {
                return HttpNotFound();
            }
            return View(placeOfLiving);
        }

        // POST: PlaceOfLivings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlaceOfLiving placeOfLiving = db.PlaceOfLivings.Find(id);
            db.PlaceOfLivings.Remove(placeOfLiving);
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

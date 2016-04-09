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
    public class Work_DataController : Controller
    {
        private erschedulerContext db = new erschedulerContext();

        // GET: Work_Data
        public ActionResult Index()
        {
            return View(db.Work_Data.ToList());
        }

        // GET: Work_Data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Work_Data work_Data = db.Work_Data.Find(id);
            if (work_Data == null)
            {
                return HttpNotFound();
            }
            return View(work_Data);
        }

        // GET: Work_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Work_Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Work_Data_ID,Shift_Date_End,Shift_Time_End,Working_Hours")] Work_Data work_Data)
        {
            if (ModelState.IsValid)
            {
                db.Work_Data.Add(work_Data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(work_Data);
        }

        // GET: Work_Data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Work_Data work_Data = db.Work_Data.Find(id);
            if (work_Data == null)
            {
                return HttpNotFound();
            }
            return View(work_Data);
        }

        // POST: Work_Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Work_Data_ID,Shift_Date_End,Shift_Time_End,Working_Hours")] Work_Data work_Data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(work_Data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(work_Data);
        }

        // GET: Work_Data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Work_Data work_Data = db.Work_Data.Find(id);
            if (work_Data == null)
            {
                return HttpNotFound();
            }
            return View(work_Data);
        }

        // POST: Work_Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Work_Data work_Data = db.Work_Data.Find(id);
            db.Work_Data.Remove(work_Data);
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


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Class_performance;
using EntityState = System.Data.EntityState;

namespace Class_performance.Controllers
{
    [Authorize]
    public class DonarsController : Controller
    {
        private P_PEntities db = new P_PEntities();

        // GET: Donars
        public ActionResult Index()
        {
            return View(db.Donars.ToList());
        }

        // GET: Donars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donar donar = db.Donars.Find(id);
            if (donar == null)
            {
                return HttpNotFound();
            }
            return View(donar);
        }

        // GET: Donars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Donars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [RequireHttps]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Phone,Email,Amount,Address,Comment")] Donar donar)
        {
            if (ModelState.IsValid)
            {
                db.Donars.Add(donar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(donar);
        }

        // GET: Donars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donar donar = db.Donars.Find(id);
            if (donar == null)
            {
                return HttpNotFound();
            }
            return View(donar);
        }

        // POST: Donars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Phone,Email,Amount,Address,Comment")] Donar donar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donar).State = (System.Data.Entity.EntityState)EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donar);
        }

        // GET: Donars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donar donar = db.Donars.Find(id);
            if (donar == null)
            {
                return HttpNotFound();
            }
            return View(donar);
        }

        // POST: Donars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Donar donar = db.Donars.Find(id);
            db.Donars.Remove(donar);
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

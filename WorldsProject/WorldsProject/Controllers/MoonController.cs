using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StarboundWorlds.Models;
using WorldsProject.DAL;

namespace WorldsProject.Controllers
{
    public class MoonController : Controller
    {
        private PrimaryContext db = new PrimaryContext();

        // GET: Moon
        public ActionResult Index()
        {
            var moons = db.Moons.Include(m => m.Planet);
            return View(moons.ToList());
        }

        // GET: Moon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moon moon = db.Moons.Find(id);
            if (moon == null)
            {
                return HttpNotFound();
            }
            return View(moon);
        }

        // GET: Moon/Create
        public ActionResult Create()
        {
            ViewBag.PlanetID = new SelectList(db.Planets, "PlanetID", "PlanetID");
            return View();
        }

        // POST: Moon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MoonID,PlanetID")] Moon moon)
        {
            if (ModelState.IsValid)
            {
                db.Moons.Add(moon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlanetID = new SelectList(db.Planets, "PlanetID", "PlanetID", moon.PlanetID);
            return View(moon);
        }

        // GET: Moon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moon moon = db.Moons.Find(id);
            if (moon == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanetID = new SelectList(db.Planets, "PlanetID", "PlanetID", moon.PlanetID);
            return View(moon);
        }

        // POST: Moon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MoonID,PlanetID")] Moon moon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlanetID = new SelectList(db.Planets, "PlanetID", "PlanetID", moon.PlanetID);
            return View(moon);
        }

        // GET: Moon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moon moon = db.Moons.Find(id);
            if (moon == null)
            {
                return HttpNotFound();
            }
            return View(moon);
        }

        // POST: Moon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Moon moon = db.Moons.Find(id);
            db.Moons.Remove(moon);
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

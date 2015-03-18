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
    public class PlanetController : Controller
    {
        private PrimaryContext db = new PrimaryContext();

        // GET: Planet
        public ActionResult Index()
        {
            var planets = db.Planets.Include(p => p.StarSystem);
            return View(planets.ToList());
        }

        // GET: Planet/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Planet planet = db.Planets.Find(id);
            if (planet == null)
            {
                return HttpNotFound();
            }
            return View(planet);
        }

        // GET: Planet/Create
        public ActionResult Create()
        {
            ViewBag.StarSystemID = new SelectList(db.StarSystems, "StarSystemID", "StarName");
            return View();
        }

        // POST: Planet/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlanetID,StarSystemID,Orbit")] Planet planet)
        {
            if (ModelState.IsValid)
            {
                db.Planets.Add(planet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StarSystemID = new SelectList(db.StarSystems, "StarSystemID", "StarName", planet.StarSystemID);
            return View(planet);
        }

        // GET: Planet/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Planet planet = db.Planets.Find(id);
            if (planet == null)
            {
                return HttpNotFound();
            }
            ViewBag.StarSystemID = new SelectList(db.StarSystems, "StarSystemID", "StarName", planet.StarSystemID);
            return View(planet);
        }

        // POST: Planet/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlanetID,StarSystemID,Orbit")] Planet planet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StarSystemID = new SelectList(db.StarSystems, "StarSystemID", "StarName", planet.StarSystemID);
            return View(planet);
        }

        // GET: Planet/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Planet planet = db.Planets.Find(id);
            if (planet == null)
            {
                return HttpNotFound();
            }
            return View(planet);
        }

        // POST: Planet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Planet planet = db.Planets.Find(id);
            db.Planets.Remove(planet);
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

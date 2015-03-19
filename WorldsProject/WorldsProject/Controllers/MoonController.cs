using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorldsProject.Models;
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
            ViewBag.PlanetID = new SelectList(db.Planets, "PlanetID", "PlanetName");
            return View();
        }

        // POST: Moon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlanetID,Orbit,WorldType,WorldSize,WorldGravity,DayLength")] Moon moonVM)
        {
            if (ModelState.IsValid)
            {
                Moon newMoon = new Moon();

                newMoon.PlanetID = moonVM.PlanetID;
                newMoon.Orbit = moonVM.Orbit;

                newMoon.WorldType = moonVM.WorldType;
                newMoon.WorldSize = moonVM.WorldSize;
                newMoon.WorldGravity = moonVM.WorldGravity;
                newMoon.DayLength = moonVM.DayLength;

                //newMoon.MoonName = moonVM.inheritMoonName();

                db.Moons.Add(newMoon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlanetID = new SelectList(db.Planets, "PlanetID", "PlanetName", moonVM.PlanetID);
            return View(moonVM);
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
        public ActionResult Edit([Bind(Include = "MoonID,PlanetID,Orbit,WorldType,DayLength,WorldSize,WorldGravity")] Moon moon)
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

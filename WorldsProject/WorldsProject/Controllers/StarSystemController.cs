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
    public class StarSystemController : Controller
    {
        private PrimaryContext db = new PrimaryContext();

        // GET: StarSystem
        public ActionResult Index()
        {
            return View(db.StarSystems.ToList());
        }

        // GET: StarSystem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StarSystem starSystem = db.StarSystems.Find(id);
            if (starSystem == null)
            {
                return HttpNotFound();
            }
            return View(starSystem);
        }

        // GET: StarSystem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StarSystem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StarSystemID,Xcoordinate,Ycoordinate,StarName")] StarSystem starSystem)
        {
            if (ModelState.IsValid)
            {
                db.StarSystems.Add(starSystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(starSystem);
        }

        // GET: StarSystem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StarSystem starSystem = db.StarSystems.Find(id);
            if (starSystem == null)
            {
                return HttpNotFound();
            }
            return View(starSystem);
        }

        // POST: StarSystem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StarSystemID,Xcoordinate,Ycoordinate,StarName")] StarSystem starSystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(starSystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(starSystem);
        }

        // GET: StarSystem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StarSystem starSystem = db.StarSystems.Find(id);
            if (starSystem == null)
            {
                return HttpNotFound();
            }
            return View(starSystem);
        }

        // POST: StarSystem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StarSystem starSystem = db.StarSystems.Find(id);
            db.StarSystems.Remove(starSystem);
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

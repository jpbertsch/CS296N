using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StarboundWorlds.DAL;
using StarboundWorlds.Models;

namespace StarboundWorlds.Controllers
{
    public class WorldController : Controller
    {
        private PrimaryContext db = new PrimaryContext();

        // GET: World
        public ActionResult Index()
        {
            return View(db.World.ToList());
        }

        // GET: World/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            World world = db.World.Find(id);
            if (world == null)
            {
                return HttpNotFound();
            }
            return View(world);
        }

        // GET: World/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: World/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorldID,WorldType,WorldSize,WorldGravity")] World world)
        {
            if (ModelState.IsValid)
            {
                db.World.Add(world);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(world);
        }

        // GET: World/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            World world = db.World.Find(id);
            if (world == null)
            {
                return HttpNotFound();
            }
            return View(world);
        }

        // POST: World/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorldID,WorldType,WorldSize,WorldGravity")] World world)
        {
            if (ModelState.IsValid)
            {
                db.Entry(world).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(world);
        }

        // GET: World/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            World world = db.World.Find(id);
            if (world == null)
            {
                return HttpNotFound();
            }
            return View(world);
        }

        // POST: World/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            World world = db.World.Find(id);
            db.World.Remove(world);
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

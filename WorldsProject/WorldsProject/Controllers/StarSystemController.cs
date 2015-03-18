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
    public class StarSystemController : Controller
    {
        private IStarSystemRepository starsystemRepository;
        //private PrimaryContext db = new PrimaryContext();

        public StarSystemController() // Called by MVC framework
        {
            this.starsystemRepository = new StarSystemRepository(new PrimaryContext());
        }

        public StarSystemController(IStarSystemRepository starsystemRepository)
        {
            this.starsystemRepository = starsystemRepository;
        }

        // GET: StarSystem
        public ActionResult Index()
        {
            return View(starsystemRepository.GetStarSystems());
        }

        // GET: StarSystem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            StarSystem starSystem = starsystemRepository.GetStarSystemByID((int)id);

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
        public ActionResult Create([Bind(Include = "StarSystemID,Xcoordinate,Ycoordinate,StarName,StarType")] StarSystem starsystemVM)
        {
            if (ModelState.IsValid)
            {
                StarSystem newStarSystem = new StarSystem();

                newStarSystem.Xcoordinate = starsystemVM.Xcoordinate;
                newStarSystem.Ycoordinate = starsystemVM.Ycoordinate;

                newStarSystem.StarName = starsystemVM.StarName;
                newStarSystem.StarType = starsystemVM.StarType;

                //db.StarSystems.Add(newStarSystem);
                starsystemRepository.InsertStarSystem(newStarSystem);
                //db.SaveChanges();
                starsystemRepository.Save();
                return RedirectToAction("Index");
            }

            return View(starsystemVM);
        }

        // GET: StarSystem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //StarSystem starSystem = db.StarSystems.Find(id);
            StarSystem starSystem = starsystemRepository.GetStarSystemByID((int)id);
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
        public ActionResult Edit([Bind(Include = "StarSystemID,Xcoordinate,Ycoordinate,StarName,StarType")] StarSystem starSystem)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(starSystem).State = EntityState.Modified;
                starsystemRepository.UpdateStarSystem(starSystem);
                //db.SaveChanges();
                starsystemRepository.Save();
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
            //StarSystem starSystem = db.StarSystems.Find(id);
            StarSystem starSystem = starsystemRepository.GetStarSystemByID((int)id);
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
            //StarSystem starSystem = db.StarSystems.Find(id);
            //db.StarSystems.Remove(starSystem);
            starsystemRepository.DeleteStarSystem(id);
            //db.SaveChanges();
            starsystemRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                starsystemRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

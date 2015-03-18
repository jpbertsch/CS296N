using StarboundWorlds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldsProject.DAL;
using WorldsProject.ViewModels;

namespace WorldsProject.Controllers
{
    public class PlanetVMController : Controller
    {
        // GET: PlanetVM
        public ActionResult Index()
        {
            PrimaryContext db = new PrimaryContext();

            var planets = db.Planets.Include("StarSystem");

            var vmList = new List<PlanetVM>();

            foreach(Planet P in planets)
            {

                vmList.Add(new PlanetVM(P) {
                                                //Orbit = P.Orbit,
                                            });
            }

            return View(vmList);
        }
    }
}
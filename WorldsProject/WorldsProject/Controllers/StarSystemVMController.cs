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
    public class StarSystemVMController : Controller
    {
        // GET: StarSystemVM
        public ActionResult Index()
        {
            PrimaryContext db = new PrimaryContext();

            var starsystems = db.StarSystems;

            var vmList = new List<StarSystemVM>();

            foreach(StarSystem SS in starsystems)
            {
                vmList.Add(new StarSystemVM(SS) {
                                                    //StarName = SS.StarName, 
                                                    //Xcoordinate = SS.Xcoordinate,
                                                    //Ycoordinate = SS.Ycoordinate,
                                                    //Planets = ??
                                                }); 
            }


            //var planets = new List<Planet>();

            ViewBag.planetList = "WiP Message: Planet List goes here.";

            return View(vmList);
        }
    }
}
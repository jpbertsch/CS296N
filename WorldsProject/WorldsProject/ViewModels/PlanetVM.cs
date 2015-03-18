using StarboundWorlds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsProject.ViewModels
{
    public class PlanetVM
    {
        public Planet thisPlanet { get; set; }

        //public List<MoonVM> Moons { get; set; }
        //public List<Moon> Moons { get; set; }

        //public StarSystemVM StarSystem { get; set; }
        public StarSystem StarSystem { get; set; }


        public int Orbit { get; set; }
        public string StarName { get; set; }

        public PlanetVM()
        {
        }

        public PlanetVM(Planet planet)
        {
            thisPlanet = planet;

            StarSystem = planet.StarSystem;

            //Moons.AddRange(Planet.Moons);
            //foreach (Moon m in Planet.Moons) { Moons.Add(m); }

            //need alternate method to pull list of planets from original starsystems virtual icollection without crashing

            Orbit = planet.Orbit;
            StarName = planet.StarSystem.StarName;

        }
        //Obsolete constructor
    }
}
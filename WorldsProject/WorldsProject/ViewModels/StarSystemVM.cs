using StarboundWorlds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsProject.ViewModels
{
    public class StarSystemVM
    {
        public StarSystem thisStarSystem { get; set; }

        //public List<PlanetVM> Planets { get; set; }
        public List<Planet> Planets {get; set; }

        public int StarSystemID { get; set; }
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }
        public string StarName { get; set; }
        public string StarType { get; set; }

        public StarSystemVM()
        { }

        public StarSystemVM(StarSystem starsystem)
        {
            thisStarSystem = starsystem;

            //Planets.AddRange(starsystem.Planets);
            //foreach (Planet p in StarSystem.Planets) { Planets.Add(p); }

            //need alternate method to pull list of planets from original starsystems virtual icollection without crashing

            StarName = starsystem.StarName;
            Xcoordinate = starsystem.Xcoordinate;
            Ycoordinate = starsystem.Ycoordinate;
        }
        //Obsolete constructor
    }
}
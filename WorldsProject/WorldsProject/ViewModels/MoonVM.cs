using StarboundWorlds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsProject.ViewModels
{
    public class MoonVM
    {
        public Moon thisMoon { get; set; }

        //public PlanetVM Planet { get; set; }
        //public Planet Planet { get; set; }

        public int Orbit { get; set; }

        public MoonVM()
        { }

        public MoonVM(Moon moon)
        {
            thisMoon = moon;

            //Planet = moon.Planet;
        }
        //Obsolete constructor
    }
}
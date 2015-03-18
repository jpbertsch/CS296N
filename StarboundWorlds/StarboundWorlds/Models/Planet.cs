using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class Planet : World
    {
        //public Moon Moons { get; set; }

        //public Moon[] Moons { get; set;  }

        public int Orbit { get; set; }

        public string PlanetName { get; set; }

        //public virtual ICollection<Moon> PlanetMoons { get; set; }
    }
}
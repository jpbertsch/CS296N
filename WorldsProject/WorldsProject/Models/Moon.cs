using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class Moon : World
    {
        public int MoonID { get; set; }

        public int PlanetID { get; set; }

        public virtual Planet Planet { get; set; } //Foreign key to planet moon orbits

        // public String MoonName { get; set; } //Need to inherit(?) from planet
    }
}
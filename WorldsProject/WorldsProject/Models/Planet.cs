using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class Planet : World
    {
        public int PlanetID { get; set; }

        public int StarSystemID { get; set; }

        //public string PlanetName { get; set; } //SB planets get name from starsystem

        public virtual StarSystem StarSystem { get; set; } //Foreign key to starsystem planet is in
        public virtual ICollection<Moon> Moons { get; set; } //Foreign keys to Moons that planet has

    }
}
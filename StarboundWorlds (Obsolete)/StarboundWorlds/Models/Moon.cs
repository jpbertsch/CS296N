using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class Moon : World
    {
        public Planet ofPlanet { get; set; }

        public String MoonName { get; set; }
    }
}
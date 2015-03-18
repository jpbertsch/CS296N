using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class StarSystem
    {
        public int StarSystemID { get; set; } //Primary Key
   
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }


        public string StarName { get; set; }
        public string StarType { get; set; } //Fluff

        public virtual ICollection<Planet> Planets { get; set; } //foreign key to planets
    }
}
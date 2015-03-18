using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class StarSystem
    {
        public int StarID { get; set; }
        public string StarType { get; set; }
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

        //public World[] Worlds { get; set; }

        //public virtual ICollection<World> StarWorlds { get; set; }

        public string StarName { get; set; }
    }
}
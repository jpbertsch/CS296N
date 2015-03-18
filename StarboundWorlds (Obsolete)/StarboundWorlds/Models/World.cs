using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class World
    {
        public int WorldID { get; set; }
        //public StarSystem Star { get; set; }
        public string WorldType { get; set; }
        public int WorldSize { get; set; }
        public float WorldGravity { get; set; }

        //public string[] WorldFeatures { get; set; }

        //public virtual ICollection<String> WorldFeatures { get; set; }


    }
}
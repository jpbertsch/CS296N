﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarboundWorlds.Models
{
    public class World
    {
        //public int WorldID { get; set; } //Primary Key (Maybe?

        //public string WorldName { get; set; } //May not use worldname as they get their names from the starsystem they inhabit

        public string WorldType { get; set; }
        public int WorldSize { get; set; }
        public double WorldGravity { get; set; }
        public int DayLength { get; set; }

        //public StarSystem Star { get; set; } // Foreign Key, need to look into how to implement

        public int Orbit { get; set; }

        //Need some way of keeping a list of features of world

        //public string[] WorldFeatures { get; set; }

        //public virtual ICollection<String> WorldFeatures { get; set; }


    }
}
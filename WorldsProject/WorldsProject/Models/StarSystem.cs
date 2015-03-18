using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorldsProject.Models
{
    public class StarSystem
    {
        
        public int StarSystemID { get; set; } //Primary Key
   
        [MinLength(8, ErrorMessage="Star coordinates must be 8 digits long and can be negative.")]
        public int Xcoordinate { get; set; }

        [MinLength(8, ErrorMessage = "Star coordinates must be 8 digits long and can be negative.")]
        public int Ycoordinate { get; set; }

        [MaxLength(50, ErrorMessage="Star names cannot exceed 50 characters.")]
        public string StarName { get; set; }

        [MaxLength(12, ErrorMessage="Star types cannot exceed 12 characters.")]
        public string StarType { get; set; } //Fluff

        public virtual ICollection<Planet> Planets { get; set; } //foreign key to planets
    }
}
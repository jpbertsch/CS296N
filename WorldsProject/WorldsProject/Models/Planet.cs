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

        public string PlanetName { get; set; } //SB planets get name from starsystem

        public virtual StarSystem StarSystem { get; set; } //Foreign key to starsystem planet is in
        public virtual ICollection<Moon> Moons { get; set; } //Foreign keys to Moons that planet has

        /*
        public Planet() : base()
        {
            //PlanetName = inheritPlanetName();
        }
        */

        public string inheritPlanetName()
        {
            string tempName = "";
            int tempCount = Orbit;

            if (StarSystem.StarName != null)
            {
                tempName += StarSystem.StarName + " ";
            }
            else
            {
                tempName += "(Invalid Star)";
            }

            switch (tempCount)
            {
                case 1:
                    tempName += "I";
                    break;
                case 2:
                    tempName += "II";
                    break;
                case 3:
                    tempName += "III";
                    break;
                case 4:
                    tempName += "IV";
                    break;
                case 5:
                    tempName += "V";
                    break;
                case 6:
                    tempName += "VI";
                    break;
                case 7:
                    tempName += "VII";
                    break;
                case 8:
                    tempName += "VIII";
                    break;
                case 9:
                    tempName += "VIV";
                    break;
                case 10:
                    tempName += "X";
                    break;
                case 11:
                    tempName += "XI";
                    break;
                case 12:
                    tempName += "XII";
                    break;
                default:
                    tempName += "(Invalid Planet)";
                    break;
            }

            PlanetName = tempName;

            return tempName;
        }

    }



}
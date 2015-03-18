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

        public string MoonName { get; set; }

        public virtual Planet Planet { get; set; } //Foreign key to planet moon orbits

        // public String MoonName { get; set; } //Need to inherit(?) from planet

        /*
        public Moon() : base()
        {
            //MoonName = inheritMoonName();
        }

        public string inheritMoonName()
        {
            string tempName = "";

            if (Planet.PlanetName != null)
            {
                int tempCount = Orbit;

                tempName += Planet.PlanetName + " ";

                switch (tempCount)
                {
                    case 1:
                        tempName += "a";
                        break;
                    case 2:
                        tempName += "b";
                        break;
                    case 3:
                        tempName += "c";
                        break;
                    case 4:
                        tempName += "d";
                        break;
                    case 5:
                        tempName += "e";
                        break;
                    case 6:
                        tempName += "f";
                        break;
                }
            }
            return tempName;
        }
        */

        public string inheritMoonName(int moonOrbit, int planetOrbit, string starName)
        {
            string tempName = "";

            if (starName != null)
            {
                tempName += starName + " ";
            }
            else
            {
                tempName += "(Invalid Star)";
            }

            switch (planetOrbit)
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

            switch (moonOrbit)
            {
                case 1:
                    tempName += "-A";
                    break;
                case 2:
                    tempName += "-B";
                    break;
                case 3:
                    tempName += "-C";
                    break;
                case 4:
                    tempName += "-D";
                    break;
                case 5:
                    tempName += "-E";
                    break;
                case 6:
                    tempName += "-F";
                    break;
                default:
                    tempName += "(Invalid Moon)";
                    break;
            }
            
            MoonName = tempName;

            return tempName;
        }
    }
}
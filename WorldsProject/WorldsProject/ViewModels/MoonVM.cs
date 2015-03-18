using WorldsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsProject.ViewModels
{
    public class MoonVM
    {
        public Moon thisMoon { get; set; }

        //public PlanetVM Planet { get; set; }
        //public Planet Planet { get; set; }
        public int MoonID { get; set; }
        public int PlanetID { get; set; }
        public string MoonName { get; set; }
        public string WorldType { get; set; }
        public int WorldSize { get; set; }
        public double WorldGravity { get; set; }
        public int DayLength { get; set; }
        public int Orbit { get; set; }

        public MoonVM()
        { }

        public MoonVM(Moon moon)
        {
            thisMoon = moon;

            //Planet = moon.Planet;
        }
        //Obsolete constructor
        
        /*
        public string inheritMoonNameVM(int moonOrbit, int planetOrbit, string starName)
        {
            string tempName = "";

            if (starName != null)
            {
                tempName += starName + " ";

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
                }

                switch (moonOrbit)
                {
                    case 1:
                        tempName += "-a";
                        break;
                    case 2:
                        tempName += "-b";
                        break;
                    case 3:
                        tempName += "-c";
                        break;
                    case 4:
                        tempName += "-d";
                        break;
                    case 5:
                        tempName += "-e";
                        break;
                    case 6:
                        tempName += "-f";
                        break;
                }
            }

            return tempName;
        }
         * */
    }
}
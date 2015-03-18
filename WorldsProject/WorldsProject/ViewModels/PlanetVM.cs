using WorldsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsProject.ViewModels
{
    public class PlanetVM
    {
        public Planet thisPlanet { get; set; }

        //public List<MoonVM> Moons { get; set; }
        //public List<Moon> Moons { get; set; }

        //public StarSystemVM StarSystem { get; set; }
        public int PlanetID { get; set; }
        public int StarSystemID { get; set; }
        public string PlanetName { get; set; }
        public string WorldType { get; set; }
        public int WorldSize { get; set; }
        public double WorldGravity { get; set; }
        public int DayLength { get; set; }
        public int Orbit { get; set; }

        public string StarName { get; set; }
        

        public PlanetVM()
        {
        }

        public PlanetVM(Planet planet)
        {
            thisPlanet = planet;

            //StarSystem = planet.StarSystem;

            //Moons.AddRange(Planet.Moons);
            //foreach (Moon m in Planet.Moons) { Moons.Add(m); }

            //need alternate method to pull list of planets from original starsystems virtual icollection without crashing

            Orbit = planet.Orbit;
            StarName = planet.StarSystem.StarName;
            PlanetName = inheritPlanetNameVM(Orbit, StarName);


        }
        //Obsolete constructor

        public string inheritPlanetNameVM(int orbitNum, string starName)
        {
            string tempName = "";

            tempName += starName + " ";

            switch (orbitNum)
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
            

            return tempName;
        }
    }
}
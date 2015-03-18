using StarboundWorlds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsProject.DAL
{
    public class PrimaryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PrimaryContext>
    {
        protected override void Seed(PrimaryContext context)
        {
            var starsystems = new List<StarSystem>
            {
                new StarSystem{StarName="Gamma Embroxillia Majoris", Xcoordinate=-534828658, Ycoordinate=-194670420},
                new StarSystem{StarName="Alpha Shilvina 11", Xcoordinate=-534828677, Ycoordinate=-194670409},
                new StarSystem{StarName="Epsilon Aether 9994", Xcoordinate=-534828694, Ycoordinate=-194670418},
                new StarSystem{StarName="Gamma Beta Com 56", Xcoordinate=-534828684, Ycoordinate=-194670412},
                new StarSystem{StarName="Gamma Gamma Crt 6753", Xcoordinate=-534828697, Ycoordinate=-194670402},
                new StarSystem{StarName="Epsilon 40 Per Majoris", Xcoordinate=-534828688, Ycoordinate=-194670405},
                new StarSystem{StarName="Delta Polaris Gal. Bor. 621", Xcoordinate=-534828677, Ycoordinate=-194670404},
                new StarSystem{StarName="Epsilon Parcomium 671", Xcoordinate=-534828655, Ycoordinate=-194670406}
            };

            starsystems.ForEach(s => context.StarSystems.Add(s));
            context.SaveChanges();

            var planets = new List<Planet>
            {
                new Planet{StarSystemID=1, Orbit=1},
                new Planet{StarSystemID=1, Orbit=2},
                new Planet{StarSystemID=1, Orbit=3},
                new Planet{StarSystemID=1, Orbit=4},
                new Planet{StarSystemID=1, Orbit=5},
                new Planet{StarSystemID=1, Orbit=6},
                new Planet{StarSystemID=2, Orbit=1},
                new Planet{StarSystemID=2, Orbit=2},
                new Planet{StarSystemID=2, Orbit=3},
                new Planet{StarSystemID=2, Orbit=4},
                new Planet{StarSystemID=2, Orbit=5},
                new Planet{StarSystemID=2, Orbit=6},
                new Planet{StarSystemID=2, Orbit=7},
                new Planet{StarSystemID=2, Orbit=8},
                new Planet{StarSystemID=3, Orbit=1},
                new Planet{StarSystemID=3, Orbit=2},
                new Planet{StarSystemID=3, Orbit=3},
                new Planet{StarSystemID=3, Orbit=4},
                new Planet{StarSystemID=3, Orbit=5},
                new Planet{StarSystemID=3, Orbit=6},
                new Planet{StarSystemID=4, Orbit=1},
                new Planet{StarSystemID=4, Orbit=2},
                new Planet{StarSystemID=4, Orbit=3},
                new Planet{StarSystemID=4, Orbit=4},
                new Planet{StarSystemID=4, Orbit=5},
                new Planet{StarSystemID=4, Orbit=6},
                new Planet{StarSystemID=4, Orbit=7},
                new Planet{StarSystemID=4, Orbit=8},
                new Planet{StarSystemID=5, Orbit=1},
                new Planet{StarSystemID=5, Orbit=2},
                new Planet{StarSystemID=5, Orbit=3},
                new Planet{StarSystemID=5, Orbit=4},
                new Planet{StarSystemID=5, Orbit=5},
                new Planet{StarSystemID=5, Orbit=6},
                new Planet{StarSystemID=6, Orbit=1},
                new Planet{StarSystemID=6, Orbit=2},
                new Planet{StarSystemID=6, Orbit=3},
                new Planet{StarSystemID=6, Orbit=4},
                new Planet{StarSystemID=6, Orbit=5},
                new Planet{StarSystemID=6, Orbit=6},
                new Planet{StarSystemID=6, Orbit=7},
                new Planet{StarSystemID=6, Orbit=8},
                new Planet{StarSystemID=7, Orbit=1},
                new Planet{StarSystemID=7, Orbit=2},
                new Planet{StarSystemID=7, Orbit=3},
                new Planet{StarSystemID=7, Orbit=4},
                new Planet{StarSystemID=7, Orbit=5},
                new Planet{StarSystemID=7, Orbit=6},
                new Planet{StarSystemID=7, Orbit=7},
                new Planet{StarSystemID=8, Orbit=1},
                new Planet{StarSystemID=8, Orbit=2},
                new Planet{StarSystemID=8, Orbit=3},
                new Planet{StarSystemID=8, Orbit=4},
                new Planet{StarSystemID=8, Orbit=5},
                new Planet{StarSystemID=8, Orbit=6},
                new Planet{StarSystemID=8, Orbit=7},
                new Planet{StarSystemID=8, Orbit=8}
            };

            planets.ForEach(s => context.Planets.Add(s));
            context.SaveChanges();

            var moons = new List<Moon>
            {
                new Moon{PlanetID=1, Orbit=1},
                new Moon{PlanetID=2, Orbit=1},
                new Moon{PlanetID=2, Orbit=2},
                new Moon{PlanetID=3, Orbit=1},
                new Moon{PlanetID=3, Orbit=2},
                new Moon{PlanetID=5, Orbit=1},
                //6
                new Moon{PlanetID=7, Orbit=1},
                new Moon{PlanetID=7, Orbit=2},
                new Moon{PlanetID=8, Orbit=1},
                new Moon{PlanetID=9, Orbit=1},
                new Moon{PlanetID=9, Orbit=2},
                new Moon{PlanetID=11, Orbit=1},
                new Moon{PlanetID=12, Orbit=1},
                //14
                new Moon{PlanetID=15, Orbit=1},
                new Moon{PlanetID=15, Orbit=2},
                new Moon{PlanetID=15, Orbit=3},
                new Moon{PlanetID=15, Orbit=4},
                new Moon{PlanetID=17, Orbit=1},
                new Moon{PlanetID=17, Orbit=2},
                new Moon{PlanetID=17, Orbit=3},
                new Moon{PlanetID=17, Orbit=4},
                new Moon{PlanetID=19, Orbit=1},
                new Moon{PlanetID=20, Orbit=1},
                //20
                new Moon{PlanetID=23, Orbit=1},
                new Moon{PlanetID=23, Orbit=2},
                new Moon{PlanetID=24, Orbit=1},
                new Moon{PlanetID=25, Orbit=1},
                new Moon{PlanetID=25, Orbit=2},
                new Moon{PlanetID=27, Orbit=1},
                //28
                new Moon{PlanetID=29, Orbit=1},
                new Moon{PlanetID=29, Orbit=2},
                new Moon{PlanetID=30, Orbit=1},
                new Moon{PlanetID=31, Orbit=1},
                new Moon{PlanetID=32, Orbit=1},
                new Moon{PlanetID=32, Orbit=2},
                new Moon{PlanetID=33, Orbit=1},
                new Moon{PlanetID=34, Orbit=1},
                //34
                new Moon{PlanetID=35, Orbit=1},
                new Moon{PlanetID=36, Orbit=1},
                new Moon{PlanetID=37, Orbit=1},
                new Moon{PlanetID=38, Orbit=1},
                new Moon{PlanetID=39, Orbit=1},
                new Moon{PlanetID=39, Orbit=2},
                new Moon{PlanetID=39, Orbit=3},
                new Moon{PlanetID=41, Orbit=1},
                new Moon{PlanetID=41, Orbit=2},
                //42
                new Moon{PlanetID=43, Orbit=1},
                new Moon{PlanetID=46, Orbit=1},
                new Moon{PlanetID=48, Orbit=1},
                new Moon{PlanetID=48, Orbit=2},
                new Moon{PlanetID=48, Orbit=3},
                //49
                new Moon{PlanetID=50, Orbit=1},
                new Moon{PlanetID=51, Orbit=1},
                new Moon{PlanetID=53, Orbit=1},
                new Moon{PlanetID=54, Orbit=1},
                new Moon{PlanetID=55, Orbit=1},
                new Moon{PlanetID=55, Orbit=2},
                new Moon{PlanetID=56, Orbit=1},
                new Moon{PlanetID=56, Orbit=2},
                new Moon{PlanetID=56, Orbit=3},
                new Moon{PlanetID=56, Orbit=4}
            };

            moons.ForEach(s => context.Moons.Add(s));
            context.SaveChanges();


        }
    }
}
using WorldsProject.Models;
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
                new StarSystem{StarName="Gamma Embroxillia Majoris", Xcoordinate=-534828658, Ycoordinate=-194670420,StarType="Gentle"},
                new StarSystem{StarName="Alpha Shilvina 11", Xcoordinate=-534828677, Ycoordinate=-194670409,StarType="Eccentric"},
                new StarSystem{StarName="Epsilon Aether 9994", Xcoordinate=-534828694, Ycoordinate=-194670418,StarType="Fiery"},
                new StarSystem{StarName="Gamma Beta Com 56", Xcoordinate=-534828684, Ycoordinate=-194670412,StarType="Fiery"},
                new StarSystem{StarName="Gamma Gamma Crt 6753", Xcoordinate=-534828697, Ycoordinate=-194670402,StarType="Radioactive"},
                new StarSystem{StarName="Epsilon 40 Per Majoris", Xcoordinate=-534828688, Ycoordinate=-194670405,StarType="Frozen"},
                new StarSystem{StarName="Delta Polaris Gal. Bor. 621", Xcoordinate=-534828677, Ycoordinate=-194670404,StarType="Frozen"},
                new StarSystem{StarName="Epsilon Parcomium 671", Xcoordinate=-534828655, Ycoordinate=-194670406,StarType="Eccentric"}
            };

            starsystems.ForEach(s => context.StarSystems.Add(s));
            context.SaveChanges();

            var planets = new List<Planet>
            {
                new Planet{StarSystemID=1, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=0.937, DayLength=15},
                new Planet{StarSystemID=1, Orbit=2, WorldType="Desert", WorldSize=4000, WorldGravity=1.021, DayLength=14},
                new Planet{StarSystemID=1, Orbit=3, WorldType="Desert", WorldSize=4000, WorldGravity=1.052, DayLength=14},
                new Planet{StarSystemID=1, Orbit=4, WorldType="Desert", WorldSize=6000, WorldGravity=1.079, DayLength=15},
                new Planet{StarSystemID=1, Orbit=5, WorldType="Desert", WorldSize=4000, WorldGravity=1.016, DayLength=13},
                new Planet{StarSystemID=1, Orbit=6, WorldType="Moon", WorldSize=4000, WorldGravity=0.706, DayLength=13}, //

                new Planet{StarSystemID=2, Orbit=1, WorldType="Arid", WorldSize=6000, WorldGravity=1.174, DayLength=12},
                new Planet{StarSystemID=2, Orbit=2, WorldType="Ocean", WorldSize=6000, WorldGravity=1.198, DayLength=14},
                new Planet{StarSystemID=2, Orbit=3, WorldType="Snow", WorldSize=6000, WorldGravity=1.191, DayLength=13},
                new Planet{StarSystemID=2, Orbit=4, WorldType="Barren", WorldSize=4000, WorldGravity=1.042, DayLength=12},
                new Planet{StarSystemID=2, Orbit=5, WorldType="Arid", WorldSize=6000, WorldGravity=1.187, DayLength=15},
                new Planet{StarSystemID=2, Orbit=6, WorldType="Arid", WorldSize=4000, WorldGravity=1.044, DayLength=13},
                new Planet{StarSystemID=2, Orbit=7, WorldType="Ocean", WorldSize=6000, WorldGravity=1.101, DayLength=12},
                new Planet{StarSystemID=2, Orbit=8, WorldType="Snow", WorldSize=6000, WorldGravity=1.087, DayLength=13}, //

                new Planet{StarSystemID=3, Orbit=1, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=3, Orbit=2, WorldType="Magma", WorldSize=4000, WorldGravity=0.967, DayLength=17},
                new Planet{StarSystemID=3, Orbit=3, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=3, Orbit=4, WorldType="Magma", WorldSize=4000, WorldGravity=0.973, DayLength=12},
                new Planet{StarSystemID=3, Orbit=5, WorldType="Magma", WorldSize=4000, WorldGravity=1.035, DayLength=12},
                new Planet{StarSystemID=3, Orbit=6, WorldType="Moon", WorldSize=4000, WorldGravity=0.724, DayLength=12}, //

                new Planet{StarSystemID=4, Orbit=1, WorldType="Dead", WorldSize=6000, WorldGravity=1.190, DayLength=13},
                new Planet{StarSystemID=4, Orbit=2, WorldType="Magma", WorldSize=4000, WorldGravity=0.961, DayLength=13},
                new Planet{StarSystemID=4, Orbit=3, WorldType="Dead", WorldSize=6000, WorldGravity=1.138, DayLength=16},
                new Planet{StarSystemID=4, Orbit=4, WorldType="Volcanic", WorldSize=4000, WorldGravity=1.011, DayLength=16},
                new Planet{StarSystemID=4, Orbit=5, WorldType="Magma", WorldSize=4000, WorldGravity=1.007, DayLength=15},
                new Planet{StarSystemID=4, Orbit=6, WorldType="Volcanic", WorldSize=4000, WorldGravity=0.993, DayLength=12},
                new Planet{StarSystemID=4, Orbit=7, WorldType="Volcanic", WorldSize=6000, WorldGravity=1.130, DayLength=13},
                new Planet{StarSystemID=4, Orbit=8, WorldType="Moon", WorldSize=4000, WorldGravity=0.711, DayLength=15}, //

                new Planet{StarSystemID=5, Orbit=1, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=5, Orbit=2, WorldType="Poison", WorldSize=6000, WorldGravity=1.135, DayLength=15},
                new Planet{StarSystemID=5, Orbit=3, WorldType="Poison", WorldSize=6000, WorldGravity=1.072, DayLength=16},
                new Planet{StarSystemID=5, Orbit=4, WorldType="Poison", WorldSize=4000, WorldGravity=0.934, DayLength=17},
                new Planet{StarSystemID=5, Orbit=5, WorldType="Poison", WorldSize=4000, WorldGravity=1.013, DayLength=13},
                new Planet{StarSystemID=5, Orbit=6, WorldType="Moon", WorldSize=4000, WorldGravity=0.687, DayLength=14}, //

                new Planet{StarSystemID=6, Orbit=1, WorldType="Frigid", WorldSize=6000, WorldGravity=1.182, DayLength=16},
                new Planet{StarSystemID=6, Orbit=2, WorldType="Frigid", WorldSize=6000, WorldGravity=1.107, DayLength=16},
                new Planet{StarSystemID=6, Orbit=3, WorldType="Frigid", WorldSize=4000, WorldGravity=1.051, DayLength=12},
                new Planet{StarSystemID=6, Orbit=4, WorldType="Frigid", WorldSize=4000, WorldGravity=1.036, DayLength=12},
                new Planet{StarSystemID=6, Orbit=5, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=6, Orbit=6, WorldType="Frigid", WorldSize=4000, WorldGravity=1.025, DayLength=16},
                new Planet{StarSystemID=6, Orbit=7, WorldType="Ice", WorldSize=6000, WorldGravity=1.192, DayLength=12},
                new Planet{StarSystemID=6, Orbit=8, WorldType="Moon", WorldSize=4000, WorldGravity=0.675, DayLength=12}, //

                new Planet{StarSystemID=7, Orbit=1, WorldType="Frigid", WorldSize=4000, WorldGravity=0.979, DayLength=16},
                new Planet{StarSystemID=7, Orbit=2, WorldType="Barren", WorldSize=3000, WorldGravity=0.896, DayLength=16},
                new Planet{StarSystemID=7, Orbit=3, WorldType="Ice", WorldSize=6000, WorldGravity=1.145, DayLength=14},
                new Planet{StarSystemID=7, Orbit=4, WorldType="Frigid", WorldSize=6000, WorldGravity=1.081, DayLength=12},
                new Planet{StarSystemID=7, Orbit=5, WorldType="Frigid", WorldSize=6000, WorldGravity=1.081, DayLength=14},
                new Planet{StarSystemID=7, Orbit=6, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=7, Orbit=7, WorldType="Moon", WorldSize=4000, WorldGravity=0.721, DayLength=14}, //

                new Planet{StarSystemID=8, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=1.029, DayLength=13},
                new Planet{StarSystemID=8, Orbit=2, WorldType="Ocean", WorldSize=4000, WorldGravity=1.019, DayLength=12},
                new Planet{StarSystemID=8, Orbit=3, WorldType="Barren", WorldSize=4000, WorldGravity=0.964, DayLength=16},
                new Planet{StarSystemID=8, Orbit=4, WorldType="Arid", WorldSize=4000, WorldGravity=0.944, DayLength=15},
                new Planet{StarSystemID=8, Orbit=5, WorldType="Snow", WorldSize=6000, WorldGravity=1.082, DayLength=15},
                new Planet{StarSystemID=8, Orbit=6, WorldType="Ocean", WorldSize=6000, WorldGravity=1.182, DayLength=15},
                new Planet{StarSystemID=8, Orbit=7, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=8, Orbit=8, WorldType="Moon", WorldSize=4000, WorldGravity=0.681, DayLength=12}
            };

            planets.ForEach(s => context.Planets.Add(s));
            context.SaveChanges();

            var moons = new List<Moon>
            {
                new Moon{PlanetID=1, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=0.937, DayLength=15},

                new Moon{PlanetID=2, Orbit=1, WorldType="Lush", WorldSize=4000, WorldGravity=0.989, DayLength=16},
                new Moon{PlanetID=2, Orbit=2, WorldType="Forest", WorldSize=3000, WorldGravity=0.850, DayLength=16},

                new Moon{PlanetID=3, Orbit=1, WorldType="Lush", WorldSize=3000, WorldGravity=0.847, DayLength=15},
                new Moon{PlanetID=3, Orbit=2, WorldType="Desert", WorldSize=4000, WorldGravity=0.955, DayLength=15},

                new Moon{PlanetID=5, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=1.013, DayLength=16},

                //6

                new Moon{PlanetID=7, Orbit=1, WorldType="Ocean", WorldSize=4000, WorldGravity=0.959, DayLength=12},
                new Moon{PlanetID=7, Orbit=2, WorldType="Arid", WorldSize=3000, WorldGravity=0.900, DayLength=14},

                new Moon{PlanetID=8, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=0.953, DayLength=12},
                new Moon{PlanetID=8, Orbit=2, WorldType="Alien", WorldSize=3000, WorldGravity=0.815, DayLength=16},

                new Moon{PlanetID=9, Orbit=1, WorldType="Snow", WorldSize=3000, WorldGravity=0.929, DayLength=15},
                new Moon{PlanetID=9, Orbit=2, WorldType="Desert", WorldSize=4000, WorldGravity=0.989, DayLength=12},

                new Moon{PlanetID=11, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=0.973, DayLength=16},

                new Moon{PlanetID=12, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=1.062, DayLength=12},

                //14

                new Moon{PlanetID=15, Orbit=1, WorldType="Magma", WorldSize=4000, WorldGravity=0.985, DayLength=15},
                new Moon{PlanetID=15, Orbit=2, WorldType="Dead", WorldSize=4000, WorldGravity=0.986, DayLength=16},
                new Moon{PlanetID=15, Orbit=3, WorldType="Volcanic", WorldSize=3000, WorldGravity=0.819, DayLength=16},
                new Moon{PlanetID=15, Orbit=4, WorldType="Magma", WorldSize=3000, WorldGravity=0.842, DayLength=15},

                new Moon{PlanetID=17, Orbit=1, WorldType="Dead", WorldSize=4000, WorldGravity=0.978, DayLength=13},
                new Moon{PlanetID=17, Orbit=2, WorldType="Frigid", WorldSize=4000, WorldGravity=0.968, DayLength=14},
                new Moon{PlanetID=17, Orbit=3, WorldType="Moon", WorldSize=3000, WorldGravity=0.704, DayLength=16},
                new Moon{PlanetID=17, Orbit=4, WorldType="Dead", WorldSize=3000, WorldGravity=0.836, DayLength=13},

                new Moon{PlanetID=19, Orbit=1, WorldType="Ice", WorldSize=3000, WorldGravity=0.803, DayLength=15},

                //20

                new Moon{PlanetID=23, Orbit=1, WorldType="Ice", WorldSize=3000, WorldGravity=0.900, DayLength=16},
                new Moon{PlanetID=23, Orbit=2, WorldType="Frigid", WorldSize=4000, WorldGravity=1.021, DayLength=14},

                new Moon{PlanetID=24, Orbit=1, WorldType="Magma", WorldSize=4000, WorldGravity=0.938, DayLength=16},

                new Moon{PlanetID=25, Orbit=1, WorldType="Ice", WorldSize=3000, WorldGravity=0.886, DayLength=14},
                new Moon{PlanetID=25, Orbit=2, WorldType="Magma", WorldSize=4000, WorldGravity=1.057, DayLength=12},

                new Moon{PlanetID=27, Orbit=1, WorldType="Volcanic", WorldSize=3000, WorldGravity=0.928, DayLength=13},

                //28

                new Moon{PlanetID=29, Orbit=1, WorldType="Tropical", WorldSize=4000, WorldGravity=0.954, DayLength=12},
                new Moon{PlanetID=29, Orbit=2, WorldType="Poison", WorldSize=3000, WorldGravity=0.856, DayLength=14},

                new Moon{PlanetID=30, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=1.035, DayLength=14},

                new Moon{PlanetID=31, Orbit=1, WorldType="Ice", WorldSize=4000, WorldGravity=0.941, DayLength=13},

                new Moon{PlanetID=32, Orbit=1, WorldType="Alien", WorldSize=4000, WorldGravity=0.994, DayLength=13},
                new Moon{PlanetID=32, Orbit=2, WorldType="Snow", WorldSize=4000, WorldGravity=1.064, DayLength=13},

                new Moon{PlanetID=33, Orbit=1, WorldType="Poison", WorldSize=4000, WorldGravity=1.063, DayLength=15},

                //34

                new Moon{PlanetID=35, Orbit=1, WorldType="Magma", WorldSize=3000, WorldGravity=0.827, DayLength=13}, 

                //new Moon{PlanetID=36, Orbit=1, WorldType="", WorldSize=, WorldGravity=, DayLength=}, //no moon anymore

                new Moon{PlanetID=37, Orbit=1, WorldType="Frigid", WorldSize=3000, WorldGravity=0.917, DayLength=15},

                new Moon{PlanetID=38, Orbit=1, WorldType="Poison", WorldSize=3000, WorldGravity=0.897, DayLength=15},

                new Moon{PlanetID=39, Orbit=1, WorldType="Frigid", WorldSize=3000, WorldGravity=0.813, DayLength=12},
                new Moon{PlanetID=39, Orbit=2, WorldType="Ice", WorldSize=4000, WorldGravity=0.975, DayLength=13},
                new Moon{PlanetID=39, Orbit=3, WorldType="Ice", WorldSize=4000, WorldGravity=1.056, DayLength=17},

                new Moon{PlanetID=41, Orbit=1, WorldType="Ice", WorldSize=4000, WorldGravity=1.008, DayLength=13},
                new Moon{PlanetID=41, Orbit=2, WorldType="Frigid", WorldSize=4000, WorldGravity=0.949, DayLength=14},

                //42

                new Moon{PlanetID=43, Orbit=1, WorldType="Moon", WorldSize=3000, WorldGravity=0.709, DayLength=15},

                new Moon{PlanetID=46, Orbit=1, WorldType="Frigid", WorldSize=3000, WorldGravity=0.883, DayLength=14},

                new Moon{PlanetID=48, Orbit=1, WorldType="Frigid", WorldSize=4000, WorldGravity=1.021, DayLength=12},
                new Moon{PlanetID=48, Orbit=2, WorldType="Frigid", WorldSize=3000, WorldGravity=0.801, DayLength=14},
                new Moon{PlanetID=48, Orbit=3, WorldType="Moon", WorldSize=3000, WorldGravity=0.704, DayLength=13},

                //49

                new Moon{PlanetID=50, Orbit=1, WorldType="Snow", WorldSize=3000, WorldGravity=0.921, DayLength=13},

                new Moon{PlanetID=51, Orbit=1, WorldType="Arid", WorldSize=3000, WorldGravity=0.801, DayLength=16},

                new Moon{PlanetID=53, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=1.061, DayLength=12},

                new Moon{PlanetID=54, Orbit=1, WorldType="Snow", WorldSize=4000, WorldGravity=1.066, DayLength=15},

                new Moon{PlanetID=55, Orbit=1, WorldType="Snow", WorldSize=4000, WorldGravity=0.974, DayLength=12},
                new Moon{PlanetID=55, Orbit=2, WorldType="Snow", WorldSize=3000, WorldGravity=0.809, DayLength=16},

                new Moon{PlanetID=56, Orbit=1, WorldType="Moon", WorldSize=3000, WorldGravity=0.682, DayLength=14},
                new Moon{PlanetID=56, Orbit=2, WorldType="Arid", WorldSize=3000, WorldGravity=0.807, DayLength=13},
                new Moon{PlanetID=56, Orbit=3, WorldType="Moon", WorldSize=3000, WorldGravity=0.691, DayLength=12},
                new Moon{PlanetID=56, Orbit=4, WorldType="Moon", WorldSize=3000, WorldGravity=0.685, DayLength=13}
            };

            moons.ForEach(s => context.Moons.Add(s));
            context.SaveChanges();


        }
    }
}
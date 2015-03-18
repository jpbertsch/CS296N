namespace WorldsProject.Migrations
{
    using WorldsProject.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WorldsProject.DAL.PrimaryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(WorldsProject.DAL.PrimaryContext context)
        {
            /*
            var startypes = new List<StarType>
            {
                new StarType{StarTypeID=1, StarTypeName="Gentle", Description="Gentle-type stars are generally home to safe planets with relativel harmless creatures and few hazards."},
                new StarType{StarTypeID=2, StarTypeName="Eccentric", Description="Eccentric-type stars contains wildly different worlds but do not pose significant threats."},
                new StarType{StarTypeID=3, StarTypeName="Radioactive", Description="Radioactive-type stars usually contain planets that require a radiation suit to visit safely."},
                new StarType{StarTypeID=4, StarTypeName="Frozen", Description="Frozen-type stars contain planets with extremely low temperatures which require special cold-weather gear."},
                new StarType{StarTypeID=5, StarTypeName="Fiery", Description="Fiery-type stars contain volatile and burning hot worlds that require thermal gear to safely visit."}
            };

            startypes.ForEach(s => context.StarTypes.AddOrUpdate(s));
            context.SaveChanges();
            */

            /*
                //TODO: Add worldtypes seed portion
            
            var worldtypes = new List<WorldType>
            {
                new WorldType{WorldTypeID=01, WorldTypeName="Barren", Description="Barren-type worlds are largely unremarkable and featureless, making them idea locations for future construction."},
                new WorldType{WorldTypeID=02, WorldTypeName="Moon", Description="Moon-type worlds lack a breathable atmosphere but are rich in fuel deposits for those willing to mine deep enough."},

                new WorldType{WorldTypeID=11, WorldTypeName="Lush", Description="Lush-type worlds are typically safe grassy planets with relatively low powered creatures and many helpful resources."},
                new WorldType{WorldTypeID=12, WorldTypeName="Forest", Description="Description goes here."},
                new WorldType{WorldTypeID=13, WorldTypeName="Desert", Description="Description goes here."},

                new WorldType{WorldTypeID=21, WorldTypeName="Arid", Description="Description goes here."},
                new WorldType{WorldTypeID=22, WorldTypeName="Ocean", Description="Description goes here."},
                new WorldType{WorldTypeID=23, WorldTypeName="Snow", Description="Description goes here."},

                new WorldType{WorldTypeID=31, WorldTypeName="Jungle", Description="Description goes here."},
                new WorldType{WorldTypeID=32, WorldTypeName="Poison", Description="Description goes here."},
                new WorldType{WorldTypeID=33, WorldTypeName="Alien", Description="Description goes here."},

                new WorldType{WorldTypeID=41, WorldTypeName="Ice", Description="Description goes here."},
                new WorldType{WorldTypeID=42, WorldTypeName="Frigid", Description="Description goes here."},

                new WorldType{WorldTypeID=51, WorldTypeName="Volcanic", Description="Description goes here."},
                new WorldType{WorldTypeID=52, WorldTypeName="Magma", Description="Description goes here."},
                new WorldType{WorldTypeID=53, WorldTypeName="Dead", Description="Description goes here."},

            };
            worldtypes.ForEach(s => context.StarTypes.AddOrUpdate(s));
            context.SaveChanges();
            */

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

            starsystems.ForEach(s => context.StarSystems.AddOrUpdate(s));
            context.SaveChanges();

            var planets = new List<Planet>
            {
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Embroxillia Majoris").StarSystemID, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=0.937, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Embroxillia Majoris").StarSystemID, Orbit=2, WorldType="Desert", WorldSize=4000, WorldGravity=1.021, DayLength=14},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Embroxillia Majoris").StarSystemID, Orbit=3, WorldType="Desert", WorldSize=4000, WorldGravity=1.052, DayLength=14},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Embroxillia Majoris").StarSystemID, Orbit=4, WorldType="Desert", WorldSize=6000, WorldGravity=1.079, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Embroxillia Majoris").StarSystemID, Orbit=5, WorldType="Desert", WorldSize=4000, WorldGravity=1.016, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Embroxillia Majoris").StarSystemID, Orbit=6, WorldType="Moon", WorldSize=4000, WorldGravity=0.706, DayLength=13}, //

                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=1, WorldType="Arid", WorldSize=6000, WorldGravity=1.174, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=2, WorldType="Ocean", WorldSize=6000, WorldGravity=1.198, DayLength=14},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=3, WorldType="Snow", WorldSize=6000, WorldGravity=1.191, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=4, WorldType="Barren", WorldSize=4000, WorldGravity=1.042, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=5, WorldType="Arid", WorldSize=6000, WorldGravity=1.187, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=6, WorldType="Arid", WorldSize=4000, WorldGravity=1.044, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=7, WorldType="Ocean", WorldSize=6000, WorldGravity=1.101, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Alpha Shilvina 11").StarSystemID, Orbit=8, WorldType="Snow", WorldSize=6000, WorldGravity=1.087, DayLength=13}, //

                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Aether 9994").StarSystemID, Orbit=1, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Aether 9994").StarSystemID, Orbit=2, WorldType="Magma", WorldSize=4000, WorldGravity=0.967, DayLength=17},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Aether 9994").StarSystemID, Orbit=3, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Aether 9994").StarSystemID, Orbit=4, WorldType="Magma", WorldSize=4000, WorldGravity=0.973, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Aether 9994").StarSystemID, Orbit=5, WorldType="Magma", WorldSize=4000, WorldGravity=1.035, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Aether 9994").StarSystemID, Orbit=6, WorldType="Moon", WorldSize=4000, WorldGravity=0.724, DayLength=12}, //

                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=1, WorldType="Dead", WorldSize=6000, WorldGravity=1.190, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=2, WorldType="Magma", WorldSize=4000, WorldGravity=0.961, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=3, WorldType="Dead", WorldSize=6000, WorldGravity=1.138, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=4, WorldType="Volcanic", WorldSize=4000, WorldGravity=1.011, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=5, WorldType="Magma", WorldSize=4000, WorldGravity=1.007, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=6, WorldType="Volcanic", WorldSize=4000, WorldGravity=0.993, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=7, WorldType="Volcanic", WorldSize=6000, WorldGravity=1.130, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Beta Com 56").StarSystemID, Orbit=8, WorldType="Moon", WorldSize=4000, WorldGravity=0.711, DayLength=15}, //

                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Gamma Crt 6753").StarSystemID, Orbit=1, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Gamma Crt 6753").StarSystemID, Orbit=2, WorldType="Poison", WorldSize=6000, WorldGravity=1.135, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Gamma Crt 6753").StarSystemID, Orbit=3, WorldType="Poison", WorldSize=6000, WorldGravity=1.072, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Gamma Crt 6753").StarSystemID, Orbit=4, WorldType="Poison", WorldSize=4000, WorldGravity=0.934, DayLength=17},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Gamma Crt 6753").StarSystemID, Orbit=5, WorldType="Poison", WorldSize=4000, WorldGravity=1.013, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Gamma Gamma Crt 6753").StarSystemID, Orbit=6, WorldType="Moon", WorldSize=4000, WorldGravity=0.687, DayLength=14}, //

                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=1, WorldType="Frigid", WorldSize=6000, WorldGravity=1.182, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=2, WorldType="Frigid", WorldSize=6000, WorldGravity=1.107, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=3, WorldType="Frigid", WorldSize=4000, WorldGravity=1.051, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=4, WorldType="Frigid", WorldSize=4000, WorldGravity=1.036, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=5, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=6, WorldType="Frigid", WorldSize=4000, WorldGravity=1.025, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=7, WorldType="Ice", WorldSize=6000, WorldGravity=1.192, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon 40 Per Majoris").StarSystemID, Orbit=8, WorldType="Moon", WorldSize=4000, WorldGravity=0.675, DayLength=12}, //

                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Delta Polaris Gal. Bor. 621").StarSystemID, Orbit=1, WorldType="Frigid", WorldSize=4000, WorldGravity=0.979, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Delta Polaris Gal. Bor. 621").StarSystemID, Orbit=2, WorldType="Barren", WorldSize=3000, WorldGravity=0.896, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Delta Polaris Gal. Bor. 621").StarSystemID, Orbit=3, WorldType="Ice", WorldSize=6000, WorldGravity=1.145, DayLength=14},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Delta Polaris Gal. Bor. 621").StarSystemID, Orbit=4, WorldType="Frigid", WorldSize=6000, WorldGravity=1.081, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Delta Polaris Gal. Bor. 621").StarSystemID, Orbit=5, WorldType="Frigid", WorldSize=6000, WorldGravity=1.081, DayLength=14},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Delta Polaris Gal. Bor. 621").StarSystemID, Orbit=6, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Delta Polaris Gal. Bor. 621").StarSystemID, Orbit=7, WorldType="Moon", WorldSize=4000, WorldGravity=0.721, DayLength=14}, //

                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=1.029, DayLength=13},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=2, WorldType="Ocean", WorldSize=4000, WorldGravity=1.019, DayLength=12},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=3, WorldType="Barren", WorldSize=4000, WorldGravity=0.964, DayLength=16},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=4, WorldType="Arid", WorldSize=4000, WorldGravity=0.944, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=5, WorldType="Snow", WorldSize=6000, WorldGravity=1.082, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=6, WorldType="Ocean", WorldSize=6000, WorldGravity=1.182, DayLength=15},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=7, WorldType="Gas", WorldSize=0, WorldGravity=0, DayLength=0},
                new Planet{StarSystemID=starsystems.Single(s => s.StarName == "Epsilon Parcomium 671").StarSystemID, Orbit=8, WorldType="Moon", WorldSize=4000, WorldGravity=0.681, DayLength=12}
            };

            planets.ForEach(s => context.Planets.AddOrUpdate(s));
            context.SaveChanges();

            var moons = new List<Moon>
            {
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Embroxillia Majoris I").PlanetID, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=0.937, DayLength=15},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Embroxillia Majoris II").PlanetID, Orbit=1, WorldType="Lush", WorldSize=4000, WorldGravity=0.989, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Embroxillia Majoris II").PlanetID, Orbit=2, WorldType="Forest", WorldSize=3000, WorldGravity=0.850, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Embroxillia Majoris III").PlanetID, Orbit=1, WorldType="Lush", WorldSize=3000, WorldGravity=0.847, DayLength=15},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Embroxillia Majoris III").PlanetID, Orbit=2, WorldType="Desert", WorldSize=4000, WorldGravity=0.955, DayLength=15},
                //4
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Embroxillia Majoris V").PlanetID, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=1.013, DayLength=16},
                //6


                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 I").PlanetID, Orbit=1, WorldType="Ocean", WorldSize=4000, WorldGravity=0.959, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 II").PlanetID, Orbit=2, WorldType="Arid", WorldSize=3000, WorldGravity=0.900, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 III").PlanetID, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=0.953, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 III").PlanetID, Orbit=2, WorldType="Alien", WorldSize=3000, WorldGravity=0.815, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 IV").PlanetID, Orbit=1, WorldType="Snow", WorldSize=3000, WorldGravity=0.929, DayLength=15},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 IV").PlanetID, Orbit=2, WorldType="Desert", WorldSize=4000, WorldGravity=0.989, DayLength=12},
                //10
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 VI").PlanetID, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=0.973, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Alpha Shilvina 11 VI").PlanetID, Orbit=1, WorldType="Desert", WorldSize=4000, WorldGravity=1.062, DayLength=12},
                //13
                //14


                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 I").PlanetID, Orbit=1, WorldType="Magma", WorldSize=4000, WorldGravity=0.985, DayLength=15},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 I").PlanetID, Orbit=2, WorldType="Dead", WorldSize=4000, WorldGravity=0.986, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 I").PlanetID, Orbit=3, WorldType="Volcanic", WorldSize=3000, WorldGravity=0.819, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 I").PlanetID, Orbit=4, WorldType="Magma", WorldSize=3000, WorldGravity=0.842, DayLength=15},
                //16
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 III").PlanetID, Orbit=1, WorldType="Dead", WorldSize=4000, WorldGravity=0.978, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 III").PlanetID, Orbit=2, WorldType="Frigid", WorldSize=4000, WorldGravity=0.968, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 III").PlanetID, Orbit=3, WorldType="Moon", WorldSize=3000, WorldGravity=0.704, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 III").PlanetID, Orbit=4, WorldType="Dead", WorldSize=3000, WorldGravity=0.836, DayLength=13},
                //18
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Aether 9994 V").PlanetID, Orbit=1, WorldType="Ice", WorldSize=3000, WorldGravity=0.803, DayLength=15},
                //20


                //21
                //22
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Beta Com 56 III").PlanetID, Orbit=1, WorldType="Ice", WorldSize=3000, WorldGravity=0.900, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Beta Com 56 III").PlanetID, Orbit=2, WorldType="Frigid", WorldSize=4000, WorldGravity=1.021, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Beta Com 56 IV").PlanetID, Orbit=1, WorldType="Magma", WorldSize=4000, WorldGravity=0.938, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Beta Com 56 V").PlanetID, Orbit=1, WorldType="Ice", WorldSize=3000, WorldGravity=0.886, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Beta Com 56 V").PlanetID, Orbit=2, WorldType="Magma", WorldSize=4000, WorldGravity=1.057, DayLength=12},
                //26
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Beta Com 56 VII").PlanetID, Orbit=1, WorldType="Volcanic", WorldSize=3000, WorldGravity=0.928, DayLength=13},
                //28


                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Gamma Crt 6753 I").PlanetID, Orbit=1, WorldType="Tropical", WorldSize=4000, WorldGravity=0.954, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Gamma Crt 6753 I").PlanetID, Orbit=2, WorldType="Poison", WorldSize=3000, WorldGravity=0.856, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Gamma Crt 6753 II").PlanetID, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=1.035, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Gamma Crt 6753 III").PlanetID, Orbit=1, WorldType="Ice", WorldSize=4000, WorldGravity=0.941, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Gamma Crt 6753 IV").PlanetID, Orbit=1, WorldType="Alien", WorldSize=4000, WorldGravity=0.994, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Gamma Crt 6753 IV").PlanetID, Orbit=2, WorldType="Snow", WorldSize=4000, WorldGravity=1.064, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Gamma Gamma Crt 6753 V").PlanetID, Orbit=1, WorldType="Poison", WorldSize=4000, WorldGravity=1.063, DayLength=15},
                //34


                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris I").PlanetID, Orbit=1, WorldType="Magma", WorldSize=3000, WorldGravity=0.827, DayLength=13}, 
                //36
                //new Moon{PlanetID=36, Orbit=1, WorldType="", WorldSize=, WorldGravity=, DayLength=}, //no moon anymore
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris III").PlanetID, Orbit=1, WorldType="Frigid", WorldSize=3000, WorldGravity=0.917, DayLength=15},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris IV").PlanetID, Orbit=1, WorldType="Poison", WorldSize=3000, WorldGravity=0.897, DayLength=15},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris V").PlanetID, Orbit=1, WorldType="Frigid", WorldSize=3000, WorldGravity=0.813, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris V").PlanetID, Orbit=2, WorldType="Ice", WorldSize=4000, WorldGravity=0.975, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris V").PlanetID, Orbit=3, WorldType="Ice", WorldSize=4000, WorldGravity=1.056, DayLength=17},
                //40
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris VII").PlanetID, Orbit=1, WorldType="Ice", WorldSize=4000, WorldGravity=1.008, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon 40 Per Majoris VII").PlanetID, Orbit=2, WorldType="Frigid", WorldSize=4000, WorldGravity=0.949, DayLength=14},
                //42


                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Delta Polaris Gal. Bor. 621 I").PlanetID, Orbit=1, WorldType="Moon", WorldSize=3000, WorldGravity=0.709, DayLength=15},
                //44
                //45
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Delta Polaris Gal. Bor. 621 IV").PlanetID, Orbit=1, WorldType="Frigid", WorldSize=3000, WorldGravity=0.883, DayLength=14},
                //47
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Delta Polaris Gal. Bor. 621 VI").PlanetID, Orbit=1, WorldType="Frigid", WorldSize=4000, WorldGravity=1.021, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Delta Polaris Gal. Bor. 621 VI").PlanetID, Orbit=2, WorldType="Frigid", WorldSize=3000, WorldGravity=0.801, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Delta Polaris Gal. Bor. 621 VI").PlanetID, Orbit=3, WorldType="Moon", WorldSize=3000, WorldGravity=0.704, DayLength=13},
                //49


                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 I").PlanetID, Orbit=1, WorldType="Snow", WorldSize=3000, WorldGravity=0.921, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 II").PlanetID, Orbit=1, WorldType="Arid", WorldSize=3000, WorldGravity=0.801, DayLength=16},
                //52
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 IV").PlanetID, Orbit=1, WorldType="Arid", WorldSize=4000, WorldGravity=1.061, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 V").PlanetID, Orbit=1, WorldType="Snow", WorldSize=4000, WorldGravity=1.066, DayLength=15},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 VI").PlanetID, Orbit=1, WorldType="Snow", WorldSize=4000, WorldGravity=0.974, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 VI").PlanetID, Orbit=2, WorldType="Snow", WorldSize=3000, WorldGravity=0.809, DayLength=16},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 VII").PlanetID, Orbit=1, WorldType="Moon", WorldSize=3000, WorldGravity=0.682, DayLength=14},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 VII").PlanetID, Orbit=2, WorldType="Arid", WorldSize=3000, WorldGravity=0.807, DayLength=13},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 VII").PlanetID, Orbit=3, WorldType="Moon", WorldSize=3000, WorldGravity=0.691, DayLength=12},
                new Moon{PlanetID=planets.Single(p => p.inheritPlanetName() == "Epsilon Parcomium 671 VII").PlanetID, Orbit=4, WorldType="Moon", WorldSize=3000, WorldGravity=0.685, DayLength=13}
                //57


            };

            moons.ForEach(s => context.Moons.AddOrUpdate(s));
            context.SaveChanges();

            //moons.ForEach(m => m.MoonName = m.inheritMoonName());
            //planets.ForEach(p => p.PlanetName = p.inheritPlanetName());
        }
    }
}

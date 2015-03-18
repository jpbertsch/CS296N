using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using StarboundWorlds.Models;
using System.Data.Entity;


namespace StarboundWorlds.DAL
{
    public class PrimaryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PrimaryContext>
    {
        protected override void Seed(PrimaryContext context)
        {
            //base.Seed(context);

            var StarSystems = new List<StarSystem>
            {
                new StarSystem{StarID=01,Xcoordinate=00000000, Ycoordinate=00000000, StarType="G2V", StarName="Sol"},
                new StarSystem{StarID=02,Xcoordinate=00001234, Ycoordinate=00005678, StarType="G2V", StarName="Alpha Centauri"} //Yes, in reality Alpha Centauri is a binary star system, this is merely simplified for convenience
            };

            var Planets = new List<Planet>
            {
                new Planet{PlanetName="Mercury", Orbit=1, WorldGravity=0.38f, WorldType="Rocky"},
                new Planet{PlanetName="Venus", Orbit=2, WorldGravity=0.904f, WorldType="Rocky"},
                new Planet{PlanetName="Earth", Orbit=3, WorldGravity=1.00f, WorldType="Garden"},
                new Planet{PlanetName="Mars", Orbit=4, WorldGravity=0.376f, WorldType="Rocky"},
                new Planet{PlanetName="Jupiter", Orbit=5, WorldGravity=2.528f, WorldType="Gas Giant"},
                new Planet{PlanetName="Saturn", Orbit=6, WorldGravity=1.065f, WorldType="Gas Giant"},
                new Planet{PlanetName="Uranus", Orbit=7, WorldGravity=0.886f, WorldType="Ice Giant"},
                new Planet{PlanetName="Neptune", Orbit=8, WorldGravity=1.14f, WorldType="Ice Giant"}
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using StarboundWorlds.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StarboundWorlds.DAL
{
    public class PrimaryContext : DbContext
    {
        public PrimaryContext() : base("PrimaryContext")
        { }

        //public DbSet<StarSystem> StarSystem { get; set; }
        public DbSet<World> World { get; set; }
        public DbSet<Planet> Planet { get; set; }
        public DbSet<Moon> Moon { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
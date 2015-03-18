using StarboundWorlds.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WorldsProject.DAL
{
    public class PrimaryContext : DbContext
    {

        public PrimaryContext() : base("PrimaryContext") {}

        public DbSet<StarSystem> StarSystems { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Moon> Moons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
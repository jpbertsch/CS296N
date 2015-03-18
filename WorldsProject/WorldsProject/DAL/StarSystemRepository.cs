using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WorldsProject.Models;

namespace WorldsProject.DAL
{
    public class StarSystemRepository : IStarSystemRepository, IDisposable
    {
        private PrimaryContext context;

        public StarSystemRepository(PrimaryContext context)
        {
            this.context = context;
        }

        public IEnumerable<StarSystem> GetStarSystems()
        {
            return context.StarSystems.ToList();
        }

        public StarSystem GetStarSystemByID(int id)
        {
            return context.StarSystems.Find(id);
        }

        public void InsertStarSystem(StarSystem starsystem)
        {
            context.StarSystems.Add(starsystem);
        }

        public void DeleteStarSystem(int starsystemID)
        {
            StarSystem starsystem = context.StarSystems.Find(starsystemID);
            context.StarSystems.Remove(starsystem);
        }

        public void UpdateStarSystem(StarSystem starsystem)
        {
            context.Entry(starsystem).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
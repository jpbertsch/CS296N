using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldsProject.Models;

namespace WorldsProject.DAL
{
    public interface IStarSystemRepository : IDisposable
    {
        IEnumerable<StarSystem> GetStarSystems();
        StarSystem GetStarSystemByID(int starsystemID);
        void InsertStarSystem(StarSystem starsystem);
        void DeleteStarSystem(int starsystemID);
        void UpdateStarSystem(StarSystem starsystem);
        void Save();
    }
}
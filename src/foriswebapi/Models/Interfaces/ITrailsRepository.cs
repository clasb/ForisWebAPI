using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foriswebapi.Models.Interfaces
{
    public interface ITrailsRepository
    {
        IEnumerable<Trail> GetAllTrails();
        IEnumerable<Trail> GetTrails(long latitude, long longitude, int radius);
        IEnumerable<Trail> GetTrails(Trail trail);
        IEnumerable<Trail> GetTrails(string keyword);
        Trail GetTrail(string id);
        Trail AddTrail(Trail trail);
        Trail UpdateTrail(string id, Trail trail);
        bool DeleteTrail(Trail trail);
        bool DeleteTrail(string id);
    }
}

using foriswebapi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foriswebapi.Models
{
    public class TrailsRepository : ITrailsRepository
    {
        public IEnumerable<Trail> GetAllTrails() {
            return new List<Trail>();
        }

        public IEnumerable<Trail> GetTrails(long latitude, long longitude, int radius) {
            return new List<Trail>();
        }

        public IEnumerable<Trail> GetTrails(Trail trail) {
            return new List<Trail>();
        }

        public IEnumerable<Trail> GetTrails(string keyword){ 
            return new List<Trail>();
        }

        public Trail GetTrail(string id)
        {
            return new Trail();
        }
        public Trail AddTrail(Trail trail)
        {
            return new Trail();
        }

        public Trail UpdateTrail(string id, Trail trail) {
            return new Trail();
        }

        public bool DeleteTrail(Trail trail)
        {
            return false;
        }

        public bool DeleteTrail(string id)
        {
            return false;
        }
    }
}

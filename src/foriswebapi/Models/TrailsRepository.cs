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
            List<Coordinate> coordinates = new List<Coordinate>()
            {
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 }
            };
            return new List<Trail>()
            {
                new Trail() { Id = "asd123", Name = "Trail 1", Length = 12, Rating = 4, Difficulty = 1, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asd112323", Name = "Trail 2", Length = 5, Rating = 1, Difficulty = 2, Description = "Trail 1 asawsdr34534tafdsafd sflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "a123d123", Name = "Trail 3", Length = 32, Rating = 2, Difficulty = 3, Description = "Trail 1 sdafdfsdfasdfsohd b", Coordinates = coordinates },
                new Trail() { Id = "asddd123", Name = "Trail 4", Length = 2, Rating = 5, Difficulty = 4, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asasdasf123", Name = "Trail 5", Length = 982, Rating = 4, Difficulty = 5, Description = "Trail 1 adfhsdt345w4fsdfkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asadfas23", Name = "Trail 6", Length = 32, Rating = 3, Difficulty = 4, Description = "Trail 1 asdertsfdg hsdfgdff khsflkahdlhadohd b", Coordinates = coordinates }
            };
        }

        public IEnumerable<Trail> GetTrails(long latitude, long longitude, int radius) {
            List<Coordinate> coordinates = new List<Coordinate>()
            {
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 }
            };
            return new List<Trail>()
            {
                new Trail() { Id = "asd123", Name = "Trail 1", Length = 12, Rating = 4, Difficulty = 1, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "as45sdf23", Name = "Trail 2", Length = 5, Rating = 1, Difficulty = 2, Description = "Trail 1 asawsdr34534tafdsafd sflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "a123d123", Name = "Trail 3", Length = 32, Rating = 2, Difficulty = 3, Description = "Trail 1 sdafdfsdfasdfsohd b", Coordinates = coordinates },
                new Trail() { Id = "asddd123", Name = "Trail 4", Length = 2, Rating = 5, Difficulty = 4, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asasdasf123", Name = "Trail 5", Length = 982, Rating = 4, Difficulty = 5, Description = "Trail 1 adfhsdt345w4fsdfkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asadfas23", Name = "Trail 6", Length = 32, Rating = 3, Difficulty = 4, Description = "Trail 1 asdertsfdg hsdfgdff khsflkahdlhadohd b", Coordinates = coordinates }
            };
        }

        public IEnumerable<Trail> GetTrails(Trail trail) {
            List<Coordinate> coordinates = new List<Coordinate>()
            {
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 }
            };
            return new List<Trail>()
            {
                new Trail() { Id = "asd123", Name = "Trail 1", Length = 12, Rating = 4, Difficulty = 1, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "as45sdf23", Name = "Trail 2", Length = 5, Rating = 1, Difficulty = 2, Description = "Trail 1 asawsdr34534tafdsafd sflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "a123d123", Name = "Trail 3", Length = 32, Rating = 2, Difficulty = 3, Description = "Trail 1 sdafdfsdfasdfsohd b", Coordinates = coordinates },
                new Trail() { Id = "asddd123", Name = "Trail 4", Length = 2, Rating = 5, Difficulty = 4, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asasdasf123", Name = "Trail 5", Length = 982, Rating = 4, Difficulty = 5, Description = "Trail 1 adfhsdt345w4fsdfkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asadfas23", Name = "Trail 6", Length = 32, Rating = 3, Difficulty = 4, Description = "Trail 1 asdertsfdg hsdfgdff khsflkahdlhadohd b", Coordinates = coordinates }
            };
        }

        public IEnumerable<Trail> GetTrails(string keyword){
            List<Coordinate> coordinates = new List<Coordinate>()
            {
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 }
            };
            return new List<Trail>()
            {
                new Trail() { Id = "asd123", Name = "Trail 1", Length = 12, Rating = 4, Difficulty = 1, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "as45sdf23", Name = "Trail 2", Length = 5, Rating = 1, Difficulty = 2, Description = "Trail 1 asawsdr34534tafdsafd sflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "a123d123", Name = "Trail 3", Length = 32, Rating = 2, Difficulty = 3, Description = "Trail 1 sdafdfsdfasdfsohd b", Coordinates = coordinates },
                new Trail() { Id = "asddd123", Name = "Trail 4", Length = 2, Rating = 5, Difficulty = 4, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asasdasf123", Name = "Trail 5", Length = 982, Rating = 4, Difficulty = 5, Description = "Trail 1 adfhsdt345w4fsdfkahdlhadohd b", Coordinates = coordinates },
                new Trail() { Id = "asadfas23", Name = "Trail 6", Length = 32, Rating = 3, Difficulty = 4, Description = "Trail 1 asdertsfdg hsdfgdff khsflkahdlhadohd b", Coordinates = coordinates }
            };
        }

        public Trail GetTrail(string id)
        {
            try {
                return GetAllTrails().Single(trail => trail.Id == id);
            } catch (InvalidOperationException e)
            {
                // This will catch if more than 1 is found on ID
                return null;
            }
        }
        public Trail AddTrail(Trail trail)
        {
            List<Coordinate> coordinates = new List<Coordinate>()
            {
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 }
            };
            return new Trail() { Id = "asd123", Name = "Trail 1", Length = 12, Rating = 4, Difficulty = 1, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates };
        }

        public Trail UpdateTrail(string id, Trail trail) {
            List<Coordinate> coordinates = new List<Coordinate>()
            {
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 },
                new Coordinate() { Latitude = 12.121212, Longitude = 12.32323 }
            };
            return new Trail() { Id = "asd123", Name = "Trail 1", Length = 12, Rating = 4, Difficulty = 1, Description = "Trail 1 asdajksöf khsflkahdlhadohd b", Coordinates = coordinates };
        }

        public bool DeleteTrail(Trail trail)
        {
            return true;
        }

        public bool DeleteTrail(string id)
        {
            return true;
        }
    }
}

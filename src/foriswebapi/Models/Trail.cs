using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foriswebapi.Models
{
    public class Trail
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public IEnumerable<Coordinate> Coordinates { get; set; }
    }
}

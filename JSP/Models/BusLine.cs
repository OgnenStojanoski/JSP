using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class BusLine
    {
        public List<BusStop> BusStops { get; set; }
        public int ID { get; set; }
        public Dictionary<int, int> Map { get; set; }

        public BusLine()
        {
            BusStops = new List<BusStop>();
            Map = new Dictionary<int, int>();
        }

        public BusLine(int id, List<BusStop> busStops, Dictionary<int, int> map)
        {
            ID = id;
            BusStops = busStops;
            Map = map;
        }
    }
}
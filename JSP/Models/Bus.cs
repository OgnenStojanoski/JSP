using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class Bus
    {
        [Key]
        public int ID { get; set; }
        public int Capacity { get; set; }
        public List<BusStop> BusStops { get; set; }
        public DateTime StartTime { get; set; }

        public Bus()
        {
            BusStops = new List<BusStop>();
            StartTime = new DateTime();
        }

        public Bus(int id, int capacity, List<BusStop> busStops, DateTime startTime)
        {
            ID = id;
            Capacity = capacity;
            BusStops = busStops;
            StartTime = startTime;
        }


    }
}
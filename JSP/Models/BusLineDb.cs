using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class BusLineDb : DbContext
    {
        public DbSet<BusLine> BusLines { get; set; }
        public DbSet<BusStop> BusStops { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public BusLineDb() : base("DefaultConection") { }

        public static BusLineDb Create()
        {
            return new BusLineDb();
        }
    }
}
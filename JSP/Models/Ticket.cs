using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class Ticket
    {
        public BusStop StartDestination { get; set; }
        public BusStop EndDestination { get; set; }
        [Key] public int ID { get; set; }
        public Ticket() { }

        public Ticket(int id, BusStop start, BusStop end)
        {
            ID = id;
            StartDestination = start;
            EndDestination = end;
        }
    }
}
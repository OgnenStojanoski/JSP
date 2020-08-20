using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class BusStop
    {
        public string Name { get; set; }
        [Key]
        public int ID { get; set; }

        public BusStop() { }
        public BusStop(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
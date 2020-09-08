using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Models
{
    public class Event
    {
        public int Eventid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        public Sport Sport { get; set; }

    }
}

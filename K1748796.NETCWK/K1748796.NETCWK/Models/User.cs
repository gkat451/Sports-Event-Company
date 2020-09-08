using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]

        public int Phone { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string Postcode { get; set; }
        public string Biography { get; set; }

        public Skills Skills { get; set; }
        public Sport  Sport { get; set; }



    }
}

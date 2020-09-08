using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K1748796.NETCWK.Models;

namespace K1748796.NETCWK.ViewModels
{
    public class UserEditViewModel
    {
        public int id  { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Postcode { get; set; }
        public int Phone { get; set; }
        public string Gender { get; set; }
        public Skills Skills { get; set; }
        public string Biography { get; set; }
        public Sport Sport { get; set; }

    }
}

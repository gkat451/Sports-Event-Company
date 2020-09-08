using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Models
{
    public class Sport
    {
        public int SportId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

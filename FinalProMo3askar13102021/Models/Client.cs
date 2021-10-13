using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [Required]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        [Required]
        [Display(Name = "Client Position")]
        public string ClientPosition { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        public bool isActive { get; set; }

    }
}

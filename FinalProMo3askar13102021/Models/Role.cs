using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}

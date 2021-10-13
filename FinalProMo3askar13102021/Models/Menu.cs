using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Models
{
    public class Menu
    {
        [Display(Name = "Menu Id")]
        public int MenuId { get; set; }
        [Required]
        [Display(Name ="Menu Title")]
        public string ItemName { get; set; }
        [Required]
        [Display(Name = "Menu URL")]
        public string ItemUrl { get; set; }
        public bool isActive { get; set; }
    }
}

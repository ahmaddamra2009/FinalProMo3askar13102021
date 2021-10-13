using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Models
{
    public class Slider
    {
        public int SliderId { get; set; }
        [Required(ErrorMessage ="Enter Slider Title")]
        [Display(Name ="Slider Title")]
        [MaxLength(15,ErrorMessage ="out of range")]
        public string SliderTitle { get; set; }
        [Required(ErrorMessage = "Enter Slider Sub Title")]
        [Display(Name = "Sub Title")]
        public string SubTitle { get; set; }
        [Required(ErrorMessage = "Enter Discount")]
         [Range(1,100,ErrorMessage ="Discount between 1 -100 %")]
        public int Discount { get; set; }
        public string Location { get; set; }
        [Required]
        public string SliderImage { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string BtnText { get; set; }
        public string BtnUrl { get; set; }
        public bool isActive { get; set; }

    }
}

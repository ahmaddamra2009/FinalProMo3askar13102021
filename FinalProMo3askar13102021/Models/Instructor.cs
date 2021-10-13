using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        [Required]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [Display(Name = "FaceBook")]
        public string Fb { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        [Required]
        [Display(Name = "Instructor Picture")]
        public string InstructorPicture { get; set; }
        public bool isActive { get; set; }

    }
}

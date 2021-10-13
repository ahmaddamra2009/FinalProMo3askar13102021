using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        [Display(Name ="Course Name")]
        public string CourseName { get; set; }
        [Required]
        [Display(Name = "Course Desc")]
        [DataType(DataType.MultilineText)]
        public string CourseDesc { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        public string Venu { get; set; }
        [Required]
        [Display(Name = "Course Image")]
        public string CourseImg { get; set; }
        [Display(Name = "is Active")]
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
    }
}

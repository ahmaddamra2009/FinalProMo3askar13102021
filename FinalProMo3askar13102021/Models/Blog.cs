using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        [Required]
        [Display(Name = "Blog Title")]
        public string BlogTitle { get; set; }
        [Required]
        [Display(Name = "Blog Description")]
        [DataType(DataType.MultilineText)]
        public string BlogDesc { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string BlogImage { get; set; }
        public bool isPublished { get; set; }
    }
}

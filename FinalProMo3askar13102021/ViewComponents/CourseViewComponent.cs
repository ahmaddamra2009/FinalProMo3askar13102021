using FinalProMo3askar13102021.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private AppDbContext db;
        public CourseViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.Courses.OrderByDescending(x=>x.CourseId));
        }



    }
}

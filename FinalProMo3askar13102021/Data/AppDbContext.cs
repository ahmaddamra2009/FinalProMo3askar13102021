using FinalProMo3askar13102021.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Data
{
    public class AppDbContext:DbContext
    {
    
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
         
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seasion1_Assignment.Entities;

namespace Seasion1_Assignment.Contexts
{
    internal class AppDbContext2:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=App01;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseInst> CourseInsts { get; set; }

    }
}

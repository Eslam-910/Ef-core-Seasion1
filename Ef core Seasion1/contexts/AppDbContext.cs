using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_core_Seasion1.Configurations;
using Ef_core_Seasion1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ef_core_Seasion1.contexts
{
    internal class AppDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MyRegion
            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E.HasKey(E => E.EmpId);

            //    E.Property(E => E.Name)
            //        .IsRequired()
            //        .HasColumnType("varchar")
            //        .HasColumnName("Employee Name")
            //        .HasMaxLength(50);

            //    E
            //        .Property(E => E.Age)
            //        .IsRequired(false)
            //        .HasColumnName("Employee Age");

            //   E.Property(E => E.Salary)
            //        .IsRequired()
            //        .HasColumnName("Employee Salary")
            //        .HasColumnType("money");

            //    E.Property(E => E.Email)
            //        .IsRequired()
            //        .HasColumnName(@"email");
            //}); 
            #endregion
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelBuilder);



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=App01;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

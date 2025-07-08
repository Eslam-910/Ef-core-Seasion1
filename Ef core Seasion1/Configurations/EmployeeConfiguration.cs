using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Ef_core_Seasion1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_core_Seasion1.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
           
            {
                E.HasKey(E => E.EmpId);

                E.Property(E => E.Name)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasColumnName("Employee Name")
                    .HasMaxLength(50);

                E
                    .Property(E => E.Age)
                    .IsRequired(false)
                    .HasColumnName("Employee Age");

                E.Property(E => E.Salary)
                     .IsRequired()
                     .HasColumnName("Employee Salary")
                     .HasColumnType("money");

                E.Property(E => E.Email)
                    .IsRequired()
                    .HasColumnName(@"email");
            };
        }
    }
}

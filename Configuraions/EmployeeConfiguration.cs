using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Database_3.Configuraions
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
               .ToTable("Employee")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeId");

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(50);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(50);
            //builder.HasMany(c => c.Projects)
            //    .WithMany(s => s.Employees)
            //    .UsingEntity<Dictionary<string, object>>(
            //    "Supply",
            //    j => j
            //    .HasOne<Project>()
            //    .WithMany()
            //    .HasForeignKey("ProjectId"),
            //    j => j
            //    .HasOne<Employee>()
            //    .WithMany()
            //    .HasForeignKey("EmployeeId"));

            //builder
            //    .Property(p => p.HiredDate.ParseExact(p.HiredDate.ToString("yyyy-MM-dd HH:mm:ss:fffffff"), "yyyy-MM-dd HH:mm:ss:fffffff", null, System.Globalization.DateTimeStyles.None));

        }
    }
}

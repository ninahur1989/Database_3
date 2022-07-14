
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_3.Configuraions
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
               .ToTable("Project")
               .HasKey(p => p.ProjectId);

            builder
                .Property(p => p.Name)
                .HasMaxLength(50);
            //builder.HasMany(c => c.Employees)
            //   .WithMany(s => s.Projects)
            //   .UsingEntity<Dictionary<string, object>>(
            //   "EmployeeProject",
            //   j => j
            //   .HasOne<Employee>()
            //   .WithMany()
            //   .HasForeignKey("ProjectId"),
            //   j => j
            //   .HasOne<Project>()
            //   .WithMany()
            //   .HasForeignKey("EmployeeId"));
        }
    }
}

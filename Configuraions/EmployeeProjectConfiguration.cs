using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_3.Configuraions
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
               .ToTable("EmployeeProject")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeProjectId");
            //builder.HasData(new[]
            //{
            //    new EmployeeProject
            //    {
            //        Id = 1,
            //        EmployeeId = 1,
            //         ProjectId = 350
            //    },
            //    new EmployeeProject
            //    {
            //        Id = 2,
            //        EmployeeId = 1,
            //        ProjectId = 1
            //    },
            //    new EmployeeProject
            //    {
            //        Id = 3,
            //        EmployeeId = 4,
            //         ProjectId = 1
            //    },
            //    new EmployeeProject
            //    {
            //        Id = 4,
            //        EmployeeId = 4,
            //        ProjectId = 1
            //    }
            //});

        }
    }
}

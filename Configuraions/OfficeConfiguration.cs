using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_3.Configuraions
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
               .ToTable("Office")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("OfficeId");

            builder
                .Property(p => p.Ttitle)
                .HasMaxLength(100);

            builder
                .Property(p => p.Location)
                .HasMaxLength(100);
        }
    }
}

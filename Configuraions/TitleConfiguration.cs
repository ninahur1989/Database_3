
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_3.Configuraions
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
               .ToTable("Title")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("TitleId");

            builder
                .Property(p => p.Name)
                .HasMaxLength(50);
        }
    }
}

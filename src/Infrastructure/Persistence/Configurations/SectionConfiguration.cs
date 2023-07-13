using Domain.SectionAggregate;
using Domain.SectionAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    internal class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.ToTable("Sections");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
           .ValueGeneratedNever()
           .HasConversion(
               id => id.Value,
               value => SectionId.Create(value));
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Configurations
{
    public class PropertyImageConfiguration : IEntityTypeConfiguration<PropertyImage>
    {
        public void Configure(EntityTypeBuilder<PropertyImage> builder)
        {
            builder.Property(pi => pi.Url).IsRequired().HasMaxLength(500);
            builder.HasOne(pi => pi.Property).WithMany(p => p.propertyImages)
                .HasForeignKey(pi => pi.PropertyId);
        }
    }
}

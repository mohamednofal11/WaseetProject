using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Configurations
{
    public class PropertyTypeConfiguration : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.HasOne(pt => pt.PropertyCategory).WithMany(pc => pc.propertyTypes)
                .HasForeignKey(pt => pt.CategoryId);
        }
    }
}

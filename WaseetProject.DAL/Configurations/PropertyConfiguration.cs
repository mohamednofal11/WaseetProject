using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(P => P.Id);
            builder.Property(P => P.Title).IsRequired()
                .HasMaxLength(200);
            builder.Property(P => P.Description).HasMaxLength(500);
            builder.Property(P => P.Price).HasColumnType("decimal(18,2)");
            builder.HasOne(P => P.PropertyType)
                .WithMany(pt => pt.properties)
                .HasForeignKey(P => P.PropertyTypeId);
            builder.HasOne(P => P.User).WithMany(u => u.properties)
                .HasForeignKey(P => P.UserId);
            builder.HasOne(P => P.Area)
                .WithMany(a => a.Properties)
                .HasForeignKey(P => P.AreaId);
        }
    }
}

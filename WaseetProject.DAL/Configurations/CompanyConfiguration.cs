using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasMany(c => c.brokerProfiles).WithOne(b => b.Company).HasForeignKey(b => b.CompanyId);
        }
    }
}

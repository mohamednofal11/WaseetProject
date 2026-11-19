using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Configurations
{
    public class BrokerProfileConfiguration : IEntityTypeConfiguration<BrokerProfile>
    {
        public void Configure(EntityTypeBuilder<BrokerProfile> builder)
        {
            builder.HasOne(b => b.User)
                .WithOne(u => u.BrokerProfile)
                .HasForeignKey<BrokerProfile>(u => u.UserId);
            builder.HasOne(b => b.Company)
                .WithMany(c => c.brokerProfiles)
                .HasForeignKey(b => b.CompanyId);
        }
    }
}

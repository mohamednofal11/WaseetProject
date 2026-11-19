using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WaseetProject.DAL.Entities;

namespace WaseetProject.DAL.Configurations
{
    public class InquiryConfiguration : IEntityTypeConfiguration<Inquiry>
    {
        public void Configure(EntityTypeBuilder<Inquiry> builder)
        {
          builder .HasOne(i => i.Sender)
                .WithMany(u => u.SentInquiries)
                .HasForeignKey(i => i.SenderId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.Receiver)
                .WithMany(u => u.ReceivedInquiries)
                .HasForeignKey(i => i.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}

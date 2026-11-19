using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WaseetProject.DAL.Entities.Enums;

namespace WaseetProject.DAL.Entities
{
    public class Inquiry: BaseEntity
    {
        [Required, MaxLength(1000)]
        public string Message { get; set; } = string.Empty;

        public InquiryStatus Status { get; set; } = InquiryStatus.New;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public User Sender {  get; set; }
        public int SenderId {  get; set; }
        public User Receiver { get; set; }
        public int ReceiverId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class User: BaseEntity
    {
        [Required, MaxLength(150)]
        public string FullName { get; set; } =null!;

        [MaxLength(20)]
        public string? Phone { get; set; }

        [Required, MaxLength(256)]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        [MaxLength(500)]
        public string? AvatarUrl { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsVerified { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        public BrokerProfile BrokerProfile { get; set; }
        public ICollection<Property> properties { get; set; }=new HashSet<Property>();
        public ICollection<Favorite> favorites { get; set; }=new HashSet<Favorite>();
        public ICollection<Inquiry> SentInquiries { get; set; } = new HashSet<Inquiry>();
        public ICollection<Inquiry> ReceivedInquiries { get; set; } = new HashSet<Inquiry>();
    }
}

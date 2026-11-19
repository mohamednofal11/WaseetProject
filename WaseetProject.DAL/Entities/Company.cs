using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class Company: BaseEntity
    {
        [Required, MaxLength(150)]
        public string Name { get; set; } = null!;

        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(300)]
        public string? Address { get; set; }

        [MaxLength(500)]
        public string? LogoUrl { get; set; }

        public bool IsApproved { get; set; }
        public ICollection<BrokerProfile> brokerProfiles { get; set; } = new HashSet<BrokerProfile>();
    }
}

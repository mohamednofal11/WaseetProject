using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class BrokerProfile: BaseEntity
    {
        [MaxLength(20)]
        public string? Whatsapp { get; set; }

        [MaxLength(1000)]
        public string? Bio { get; set; }

        public bool IsApproved { get; set; }
        public User User { get; set; }
        public int UserId {  get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}

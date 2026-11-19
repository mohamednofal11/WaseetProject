using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class PropertyImage: BaseEntity
    {
        [Required, MaxLength(500)]
        public string Url { get; set; } = null!;

        public bool IsMain { get; set; }
        public int SortOrder { get; set; }
        public Property Property { get; set; } = null!;
        public int PropertyId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class PropertyType: BaseEntity
    {
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? ImageUrl { get; set; }
        public PropertyCategory PropertyCategory { get; set; }
        public int CategoryId {  get; set; }
        public ICollection<Property> properties { get; set; }= new HashSet<Property>();
    }
}

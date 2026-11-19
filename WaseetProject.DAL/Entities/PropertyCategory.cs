using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class PropertyCategory: BaseEntity
    {

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public int SortOrder { get; set; }
        public ICollection<PropertyType> propertyTypes { get; set; } = new HashSet<PropertyType>();
    }
}

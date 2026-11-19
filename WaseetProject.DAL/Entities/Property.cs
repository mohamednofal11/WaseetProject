using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WaseetProject.DAL.Entities.Enums;

namespace WaseetProject.DAL.Entities
{
    public class Property: BaseEntity
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price {  get; set; }
        public ListingType ListingType { get; set; }
        public PropertyStatus Status { get; set; } = default;
        public RentPeriod RentPeriod { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal SizeM2 { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? Floor { get; set; }
        public FinishingType? FinishingType { get; set; }

        public bool IsFeatured { get; set; }
        public int ViewsCount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        //navigations prop
        public PropertyType PropertyType { get; set; }
        public int PropertyTypeId {  get; set; } 
        public Area Area { get; set; }
        public int AreaId {  get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<PropertyImage> propertyImages { get; set; }= new HashSet<PropertyImage>();
        public ICollection<Favorite> favorites { get; set; }= new HashSet<Favorite>();
    }
}

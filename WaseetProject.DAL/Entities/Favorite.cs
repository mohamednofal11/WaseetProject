using System;
using System.Collections.Generic;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class Favorite: BaseEntity
    {
        public User User { get; set; }
        public int UserId {  get; set; }
        public Property Property { get; set; }
        public int PropertyId {  get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

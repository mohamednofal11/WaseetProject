using System;
using System.Collections.Generic;
using System.Text;

namespace WaseetProject.DAL.Entities
{
    public class Role: BaseEntity
    {
        public string Name { get; set; }
        public ICollection<User> users { get; set; }= new HashSet<User>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<ComplaintType>? ComplaintTypes { get; set; } = new List<ComplaintType>();
        //public string DepartmentName { get; set; }
        //public ICollection<User> Users { get; set; } = new HashSet<User>();
        //public ICollection<ComplaintType> ComplaintTypes { get; set; } = new HashSet<ComplaintType>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class Department : BaseEntity
    {
        [Required(ErrorMessage = "Department name is required.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Department name must be between 1 and 200 characters.")]
        public string DepartmentName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<ComplaintType>? ComplaintTypes { get; set; } = new List<ComplaintType>();
        //public string DepartmentName { get; set; }
        //public ICollection<User> Users { get; set; } = new HashSet<User>();
        //public ICollection<ComplaintType> ComplaintTypes { get; set; } = new HashSet<ComplaintType>();
    }
}

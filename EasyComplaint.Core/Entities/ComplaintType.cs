using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class ComplaintType : BaseEntity
    {
       
        [Required(ErrorMessage = "Type name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Type name must be between 1 and 100 characters.")]
        public string TypeName { get; set; }

        [Required(ErrorMessage = "DepartmentID is required.")]
        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }

        public ICollection<Complaint>? Complaints { get; set; } = new List<Complaint>();
        //public string TypeName { get; set; }
        //public int DepartmentID { get; set; }

        //[ForeignKey("DepartmentID")]
        //public Department Department { get; set; }   
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class ComplaintType : BaseEntity
    {
        public string TypeName { get; set; }
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

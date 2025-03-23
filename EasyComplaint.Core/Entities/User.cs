using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class User : IdentityUser<int>
    {
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Full name must be between 1 and 200 characters.")]
        public string FullName { get; set; }
        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        public ICollection<Complaint>? Complaints { get; set; } = new List<Complaint>();
        public ICollection<Complaint>? AssignedComplaints { get; set; } = new List<Complaint>();
        //public string FullName { get; set; }
        //public int DepartmentID { get; set; }
        //[ForeignKey("DepartmentID")]
        //public Department Department { get; set; }       
        //public ICollection<Complaint>? Complaints { get; set; } = new HashSet<Complaint>(); 
        //public ICollection<Complaint>? AssignedComplaints { get; set; } = new HashSet<Complaint>();
        //public ICollection<Comment>? Comments { get; set; } = new HashSet<Comment>();
        //public ICollection<Attachment>? Attachments { get; set; } = new HashSet<Attachment>();



    }
}

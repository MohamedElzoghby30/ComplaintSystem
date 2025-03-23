using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyComplaint.Core.Entities
{
    public class Complaint : BaseEntity
    {
       
        public int? UserID { get; set; } 
        [ForeignKey("UserID")]
        public User? User { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [StringLength(50, ErrorMessage = "Status cannot exceed 50 characters.")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(2000, MinimumLength = 1, ErrorMessage = "Description must be between 1 and 2000 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Complaint type ID is required.")]
        public int ComplaintTypeID { get; set; }

        [ForeignKey("ComplaintTypeID")]
        public ComplaintType ComplaintType { get; set; }

        public int? CurrentStepID { get; set; } 
        [ForeignKey("CurrentStepID")]
        public Workflow? CurrentStep { get; set; }

        public int? AssignedToID { get; set; } 
        [ForeignKey("AssignedToID")]
        public User? AssignedTo { get; set; }

        public DateTime? AssignedAt { get; set; } 

        public ICollection<ComplaintParticipant> Participants { get; set; } = new List<ComplaintParticipant>();
        public ICollection<Comment>? Comments { get; set; } = new List<Comment>();
        public ICollection<Attachment>? Attachments { get; set; } = new List<Attachment>();
    }
    //public int  ComplainerID { get; set; } // اللي عمل الشكوي
    //[ForeignKey("UserID")]
    //public User User { get; set; }
    //public string Status { get; set; }
    //public string Description { get; set; }
    //public int ComplaintTypeID { get; set; }
    //[ForeignKey("ComplaintTypeID")]
    //public ComplaintType ComplaintType { get; set; }
    //public int CurrentStepID { get; set; }
    //[ForeignKey("CurrentStepID")]
    //public Workflow CurrentStep { get; set; }
    //public int? AssignedToID { get; set; } // اللي هتروحله الشكوي
    //[ForeignKey("AssignedToID")]
    //public User? AssignedTo { get; set; }
    //public ICollection<User> Users { get; set; } = new HashSet<User>(); 
    //public ICollection<Comment>? Comments { get; set; } = new HashSet<Comment>(); 
    //public ICollection<Attachment>? Attachments { get; set; } = new HashSet<Attachment>(); 

}


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{

    public class Attachment : BaseEntity
    {
        [Required(ErrorMessage = "ComplaintID is required.")]
        public int ComplaintID { get; set; }

        [ForeignKey("ComplaintID")]
        public Complaint Complaint { get; set; }

        [Required(ErrorMessage = "File path is required.")]
        [StringLength(500, ErrorMessage = "File path cannot exceed 500 characters.")]
        public string FilePath { get; set; }

        [Required(ErrorMessage = "File type is required.")]
        [StringLength(50, ErrorMessage = "File type cannot exceed 50 characters.")]
        public string FileType { get; set; }

        [Required(ErrorMessage = "UploadedBy is required.")]
        public int UploadedBy { get; set; }

        [ForeignKey("UploadedBy")]
        public User User { get; set; }
    }
    //public int ComplaintID { get; set; }
    //[ForeignKey("ComplaintID")]
    //public Complaint Complaint { get; set; }
    //public string FilePath { get; set; }
    //public string FileType { get; set; }
    //public int ComplainerId { get; set; }
    //[ForeignKey("ComplainerId")]
    //public User Complainer { get; set; }
}

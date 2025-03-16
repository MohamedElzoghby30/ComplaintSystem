using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class Attachment : BaseEntity
    {
        public int ComplaintID { get; set; }
        [ForeignKey("ComplaintID")]
        public Complaint Complaint { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
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

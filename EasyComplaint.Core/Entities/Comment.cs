using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyComplaint.Core.Entities
{
   

    public class Comment : BaseEntity
    {
        [Required(ErrorMessage = "ComplaintID is required.")]
        public int ComplaintID { get; set; }

        [ForeignKey("ComplaintID")]
        public Complaint Complaint { get; set; }

        [Required(ErrorMessage = "ParticipantID is required.")]
        public int ParticipantID { get; set; }

        [ForeignKey("ParticipantID")]
        public ComplaintParticipant Participant { get; set; }

        [Required(ErrorMessage = "Comment text is required.")]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Comment text must be between 1 and 1000 characters.")]
        public string CommentText { get; set; }
        [Required(ErrorMessage = "Date created is required.")]
        public DateTime CreatedAt { get; set; }
    }
    // public int ComplaintID { get; set; }
    // [ForeignKey("ComplaintID")]
    // public Complaint Complaint { get; set; }
    // public int ParticipantID { get; set; }
    // [ForeignKey("ParticipantID")]
    // public User Participant { get; set; }
    // public string CommentText { get; set; }
    // #region MyRegion
    ////متنساش ال config علاقه 1==> m complaint
    // #endregion
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class Comment : BaseEntity
    {
        public int ComplaintID { get; set; }
        [ForeignKey("ComplaintID")]
        public Complaint Complaint { get; set; }
        public int ParticipantID { get; set; }
        [ForeignKey("ParticipantID")]
        public ComplaintParticipant Participant { get; set; }
        public string CommentText { get; set; }
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
}

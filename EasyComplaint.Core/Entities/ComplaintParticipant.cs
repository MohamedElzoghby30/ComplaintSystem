﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
   public class ComplaintParticipant : BaseEntity
    {

        public int ComplaintID { get; set; }
        [ForeignKey("ComplaintID")]
        public Complaint Complaint { get; set; }
        public int WorkflowID { get; set; }
        [ForeignKey("WorkflowID")]
        public Workflow Workflow { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public DateTime AssignedAt { get; set; }
        //     public int ComplaintID { get; set; }
        //     [ForeignKey("ComplaintID")]
        //     public Complaint Complaint { get; set; }

        //     public int CurrentStepID { get; set; }
        //     [ForeignKey("CurrentStepID")]
        //     public Workflow CurrentStep { get; set; }
        //     public int RoleID { get; set; }
        //     [ForeignKey("RoleID")]
        //     public Role Role { get; set; }

        //     public int UserID { get; set; }
        //     [ForeignKey("UserID")]
        //     public User User { get; set; }

        //     public DateTime AssignedAt { get; set; }
    }
}
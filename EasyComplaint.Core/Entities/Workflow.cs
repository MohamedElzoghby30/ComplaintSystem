﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Core.Entities
{
    public class Workflow : BaseEntity
    {
        public string StepName { get; set; }
        public int ComplaintTypeID { get; set; }
        [ForeignKey("ComplaintTypeID")]
        public ComplaintType ComplaintType { get; set; }
        public int StepOrder { get; set; }
        public int? NextStepID { get; set; }
        [ForeignKey("NextStepID")]
        public Workflow? NextStep { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public Role Role { get; set; }
        public ICollection<Complaint>? Complaints { get; set; } = new List<Complaint>();
        //public string StepName { get; set; }
        //public int ComplaintTypeID { get; set; }
        //[ForeignKey("ComplaintTypeID")]
        //public ComplaintType ComplaintType { get; set; }

        //public int StepOrder { get; set; }
        //public int? NextStepID { get; set; } 
        //[ForeignKey("NextStepID")]
        //public Workflow? NextStep { get; set; }

        //public int RoleID { get; set; }
        //[ForeignKey("RoleID")]
        //public Role Role { get; set; }

        //public ICollection<Complaint>? Complaints { get; set; } = new HashSet<Complaint>(); 
    }
}

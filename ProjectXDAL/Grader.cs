//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectXDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grader
    {
        public int Marks_Obtained { get; set; }
        public string Feedback { get; set; }
        public string BatchID { get; set; }
        public string CourseID { get; set; }
        public int ParticipantID { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual Cours Cours { get; set; }
        public virtual Participant Participant { get; set; }
    }
}

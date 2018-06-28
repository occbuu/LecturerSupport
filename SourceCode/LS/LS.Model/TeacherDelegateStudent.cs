//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherDelegateStudent
    {
        public long StudentId { get; set; }
        public long TeacherId { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string SupervisionType { get; set; }
        public string Time { get; set; }
        public string Degree { get; set; }
        public string Status { get; set; }
        public Nullable<bool> CanDelete { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
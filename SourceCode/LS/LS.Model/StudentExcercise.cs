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
    
    public partial class StudentExcercise
    {
        public long Id { get; set; }
        public Nullable<long> DocumentId { get; set; }
        public Nullable<long> ClassId { get; set; }
        public Nullable<long> StudentId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string Link { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<long> AssignmentConfigId { get; set; }
    
        public virtual AssignmentConfig AssignmentConfig { get; set; }
        public virtual Class Class { get; set; }
        public virtual Document Document { get; set; }
        public virtual Student Student { get; set; }
    }
}

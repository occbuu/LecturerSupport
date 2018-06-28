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
    
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            this.AssignmentConfigs = new HashSet<AssignmentConfig>();
            this.StudentExcercises = new HashSet<StudentExcercise>();
        }
    
        public long Id { get; set; }
        public Nullable<long> ClassId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ModidiedBy { get; set; }
        public Nullable<System.DateTime> ModidiedOn { get; set; }
        public string Image { get; set; }
        public string DocumentType { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Linkl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignmentConfig> AssignmentConfigs { get; set; }
        public virtual Class Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentExcercise> StudentExcercises { get; set; }
    }
}

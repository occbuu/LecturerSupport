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
    
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            this.Classes = new HashSet<Class>();
            this.Classes1 = new HashSet<Class>();
            this.Schedules = new HashSet<Schedule>();
            this.TeacherDelegateStudents = new HashSet<TeacherDelegateStudent>();
            this.TeacherMemories = new HashSet<TeacherMemory>();
            this.TeacherResearchWorks = new HashSet<TeacherResearchWork>();
            this.TeacherStudies = new HashSet<TeacherStudy>();
        }
    
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<long> TypeTeacherId { get; set; }
        public string Description { get; set; }
        public string ObjectId { get; set; }
        public Nullable<long> SchoolId { get; set; }
        public string Owner { get; set; }
        public string Gender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes1 { get; set; }
        public virtual Object Object { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual University University { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherDelegateStudent> TeacherDelegateStudents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherMemory> TeacherMemories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherResearchWork> TeacherResearchWorks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherStudy> TeacherStudies { get; set; }
    }
}

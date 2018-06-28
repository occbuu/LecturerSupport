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
    
    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            this.AssignmentConfigs = new HashSet<AssignmentConfig>();
            this.ClassAnnouncements = new HashSet<ClassAnnouncement>();
            this.ClassDiscusses = new HashSet<ClassDiscuss>();
            this.CourseScores = new HashSet<CourseScore>();
            this.Documents = new HashSet<Document>();
            this.Schedules = new HashSet<Schedule>();
            this.ScoreConfigs = new HashSet<ScoreConfig>();
            this.StudentClasses = new HashSet<StudentClass>();
            this.StudentExcercises = new HashSet<StudentExcercise>();
        }
    
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<long> SubjectId { get; set; }
        public string Status { get; set; }
        public Nullable<long> VenueId { get; set; }
        public string Description { get; set; }
        public string Prerequisition { get; set; }
        public Nullable<long> TeacherId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Images { get; set; }
        public Nullable<long> UniversityId { get; set; }
        public Nullable<long> TeachingAssistantId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignmentConfig> AssignmentConfigs { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Teacher Teacher1 { get; set; }
        public virtual University University { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassAnnouncement> ClassAnnouncements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassDiscuss> ClassDiscusses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseScore> CourseScores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScoreConfig> ScoreConfigs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentExcercise> StudentExcercises { get; set; }
    }
}
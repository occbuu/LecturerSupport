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
    
    public partial class ClassDiscuss
    {
        public long Id { get; set; }
        public Nullable<long> ClassId { get; set; }
        public Nullable<long> ParentId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Level { get; set; }
        public string Content { get; set; }
    
        public virtual Class Class { get; set; }
    }
}

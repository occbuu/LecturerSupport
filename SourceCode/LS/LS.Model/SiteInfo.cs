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
    
    public partial class SiteInfo
    {
        public long Id { get; set; }
        public string lang { get; set; }
        public string brief { get; set; }
        public string type { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public string URL1 { get; set; }
        public string URL2 { get; set; }
        public string Status { get; set; }
        public Nullable<bool> CanDelete { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ParentId { get; set; }
    }
}

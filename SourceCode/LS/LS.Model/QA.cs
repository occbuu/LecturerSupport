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
    
    public partial class QA
    {
        public long id { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string AskedBy { get; set; }
        public Nullable<System.DateTime> AskedDate { get; set; }
        public string AnsweredBy { get; set; }
        public Nullable<System.DateTime> AnsweredDate { get; set; }
        public string Status { get; set; }
        public Nullable<bool> Highlight { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
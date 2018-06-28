using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LS.Web.Models
{
    public class StudentScoreViewModel
    {
        public long? ClassId { set; get; }
        public long? StudentId { set; get; }
        public string PerAdd { set; get; }
        public string TemAdd { set; get; }
        public string Gender { set; get; }
        public string Birthday { set; get; }
        public string Name { set; get; }
        public string TotalMark { set; get; } 
    }
}
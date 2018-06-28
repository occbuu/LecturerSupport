using System;
using System.Collections.Generic;

namespace LS.Web.Models
{
    public class SearchSelectedListViewModel
    {
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public string Status { set; get; }
        public string Type { set; get; }
        public long? SchoolId { set; get; }
        public List<long?> ClassId { set; get; }
    }
}
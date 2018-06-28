using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class ScheduleDetail
    {
        public long? Id { set; get; }
        public string Date { set; get; }
        public string StartTime { set; get; }
        public string Remark { set; get; }
        public string EndTime { set; get; }
        public string Contents { set; get; }
         public string AddressUniverstity { set; get; }
        public string Status { set; get; }
        public List<ScheduleDetail> Schools { get; set; }

        public static List<ScheduleDetail> Convert(List<Schedule> list)
        {
            if (list == null)
            {
                return new List<ScheduleDetail>();
            }
            var res = from s in list
                      select new ScheduleDetail
                      {
                          Id = s.Id,
                          Date = s.Date.HasValue ? s.Date.Value.ToString("dd/MM/yyyy") : string.Empty,
                          StartTime = s.StartTime.HasValue ? s.StartTime.Value.ToString("hh\\:mm") : string.Empty,
                          EndTime = s.EndTime.HasValue ? s.EndTime.Value.ToString("hh\\:mm") : string.Empty,
                          //SubjectName = s.Subject.SubjectName,
                          Remark = s.Remark,
                          AddressUniverstity = s.AddressUniversity.Address,
                          Contents = s.Contents,
                          Status=s.Status
                      };
            return res.ToList();
        }
    }

    public class SchoolDetailVM
    {
        public string SchoolName { get; set; }

        public List<ScheduleDetail> SchoolDetails { get; set; }
    }

    public class SchoolVM
    {
        public List<SchoolDetailVM> Schools { get; set; }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class StudentClassViewModel
    {
        public long Id { set; get; }
        public long? ClassId { set; get; }
        public long? StudentId { set; get; }
        public string StartMonthClass { set; get; }
        public string StartYearClass { set; get; }
        public string StartDateClass { set; get; }
        public string EndDateClass { set; get; }
        public string ClassName { set; get; }

        public static List<StudentClassViewModel> Convert(List<StudentClass> lst)
        {
            if (lst == null)
            {
                return new List<StudentClassViewModel>();
            }
            var res = from s in lst
                      select new StudentClassViewModel
                      {
                          Id = s.Id,
                          ClassId = s.ClassId,
                          StudentId = s.StudentId,
                          StartMonthClass = s.Class.StartDate.HasValue ? string.Format("{0:MMM}", s.Class.StartDate) : string.Empty,
                          StartYearClass = s.Class.StartDate.HasValue ? string.Format("{0:yyyy}", s.Class.StartDate) : string.Empty,
                          StartDateClass = s.Class.StartDate.HasValue ? string.Format("{0:dd MMM, yyyy}", s.Class.StartDate) : string.Empty,
                          EndDateClass = s.Class.StartDate.HasValue ? string.Format("{0:dd MMM, yyyy}", s.Class.EndDate) : string.Empty,
                          ClassName = s.Class.Name
                      };
            return res.ToList();
        }

    }
}
using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class TeacherDelegateStudentViewModel
    {
        public long StudentId { get; set; }

        public string Name { get; set; }

        public string Topic { get; set; }

        public string SupervisionType { get; set; }

        public string Time { get; set; }

        public string Avartar { get; set; }

        public string Degree { get; set; }

        public string Status { get; set; }

        public bool? CanDelete { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public static List<TeacherDelegateStudentViewModel> Convert(List<TeacherDelegateStudent> lst)
        {
            if (lst == null)
            {
                return new List<TeacherDelegateStudentViewModel>();
            }
            var res = from s in lst
                      select new TeacherDelegateStudentViewModel
                      {
                          StudentId = s.Student.Id,
                          Name = s.Student.Object.FullName,
                          Topic = s.Topic,
                          SupervisionType = s.SupervisionType,
                          Time = s.Time,
                          Degree = s.Degree,
                          Status = s.Status,
                          CanDelete = s.CanDelete,
                          CreatedBy = s.CreatedBy,
                          Avartar = s.Student.Object.Image,
                          CreatedDate = s.CreatedDate.HasValue ? s.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                      };
            return res.ToList();
        }
    }
}
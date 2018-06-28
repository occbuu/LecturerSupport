using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LS.Web.Models
{
    using Model;
    public class StudentViewModel
    {
        public long Id { get; set; }

        public string ObjectId { get; set; }

        public string Status { get; set; }

        public long? SchoolId { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public string ModifiedOn { get; set; }

        public string FullName { get; set; }

        public List<StudentViewModel> Convert(List<Student> list)
        {
            if (list == null)
            {
                return new List<StudentViewModel>();
            }

            var res = from s in list
                      select new StudentViewModel
                      {
                          Id = s.Id,
                          ObjectId = s.ObjectId,
                          Status = s.Status,
                          SchoolId = s.SchoolId,
                          CreatedBy = s.CreatedBy,
                          CreatedOn = s.CreatedOn.HasValue ? s.CreatedOn.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          ModifiedBy = s.ModifiedBy,
                          ModifiedOn = s.ModifiedOn.HasValue ? s.ModifiedOn.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          FullName = s.Object.FullName!=null?s.Object.FullName:string.Empty
                      };
            return res.ToList();
        }
    }
}
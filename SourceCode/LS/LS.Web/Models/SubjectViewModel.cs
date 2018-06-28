using System.Collections.Generic;
using System.Linq;
using System;

namespace LS.Web.Models
{
    using Model;

    public class SubjectViewModel
    {
        public long Id { set; get; }
        public string SubjectName { set; get; }
        public string Description { get; set; }
        public string SubjectType { get; set; }
        public int? Unit { get; set; }
        public int? Practice { get; set; }
        public int? Theory { get; set; }
        public string Status { get; set; }
        public string CreateOn { get; set; }
        public string CreateBy { get; set; }
        public bool? CanDelete { get; set; }


        public static List<SubjectViewModel> Convert(List<Subject> lst)
        {
            if (lst == null)
            {
                return new List<SubjectViewModel>();
            }
            var res = from s in lst
                      select new SubjectViewModel
                      {
                          Id = s.Id,
                          SubjectName = s.SubjectName,
                          Description = s.Description,
                          SubjectType = s.SubjectType,
                          Unit = s.Unit,
                          Practice = s.Practice,
                          Theory = s.Theory,
                          Status = s.Status,
                          CreateOn = s.CreatedOn.HasValue ? s.CreatedOn.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          CreateBy = s.CreatedBy,
                          CanDelete = s.CanDelete
                      };
            return res.ToList();
        }
    }
}
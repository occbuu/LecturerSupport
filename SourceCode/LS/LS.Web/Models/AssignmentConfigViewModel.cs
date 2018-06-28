using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class AssignmentConfigViewModel
    {
        public long? Id { set; get; }
        public long? DocumentId { set; get; }
        public long? ClassId { set; get; }
        public string Status { set; get; }
        public string ModifiedBy { set; get; }
        public string CreatedBy { set; get; }
        public string CreatedOn { set; get; }
        public string ModifiedOn { set; get; }
        public string Content { set; get; }
        public string StartDate { set; get; }
        public string EndDate { set; get; }

        public static List<AssignmentConfigViewModel> Convert (List<AssignmentConfig> lst)
        {

            if (lst == null)
            {
                return new List<AssignmentConfigViewModel>();
            }

            var res = from s in lst
                      select new AssignmentConfigViewModel
                      {
                          Id = s.Id,
                          DocumentId = s.DocumentId,
                          ClassId = s.ClassId,
                          CreatedBy = s.CreatedBy,
                          CreatedOn = s.CreatedOn.HasValue ? s.CreatedOn.Value.ToString("MM/dd/yyyy") : string.Empty,
                          ModifiedBy = s.ModifiedBy,
                          ModifiedOn = s.ModifiedOn.HasValue ? s.ModifiedOn.Value.ToString("MM/dd/yyyy") : string.Empty,
                          StartDate = s.StartDate.HasValue ? s.StartDate.Value.ToString("MM/dd/yyyy") : string.Empty,
                          EndDate = s.EndDate.HasValue ? s.EndDate.Value.ToString("MM/dd/yyyy") : string.Empty,
                          Status = s.Status,
                          Content = s.Content
                      };
            return res.ToList();
        }
    }
}
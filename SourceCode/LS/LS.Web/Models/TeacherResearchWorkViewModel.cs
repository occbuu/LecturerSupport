using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class TeacherResearchWorkViewModel
    {
        public string Id { get; set; }

        public long? TeacherId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Level { get; set; }

        public string Member { get; set; }

        public string Time { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        public bool? CanDelete { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public int TotalNews { get; set; }

        public List<TeacherResearchWorkViewModel> TRBookVM { get; set; }

        public List<TeacherResearchWorkViewModel> TRReseachProjectsVM { get; set; }

        public List<TeacherResearchWorkViewModel> TRJournalArticlesVM { get; set; }

        public List<TeacherResearchWorkViewModel> TRConferenceProceedings { get; set; }

        public static List<TeacherResearchWorkViewModel> Convert(List<TeacherResearchWork> lst)
        {
            if (lst == null)
            {
                return new List<TeacherResearchWorkViewModel>();
            }
            var res = from s in lst
                      select new TeacherResearchWorkViewModel
                      {
                          Id = s.Id,
                          TeacherId = s.TeacherId,
                          Title = s.Title,
                          Description = s.Description,
                          Time = s.Time,
                          Member = s.Member,
                          Level = s.Level,
                          Type = s.Type,
                          Status = s.Status,
                          CanDelete = s.CanDelete,
                          CreatedBy = s.CreatedBy,
                          CreatedDate = s.CreatedDate.HasValue ? s.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                      };
            return res.ToList();
        }
    }
}
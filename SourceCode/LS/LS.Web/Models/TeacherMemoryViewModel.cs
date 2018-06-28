using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class TeacherMemoryViewModel
    {
        public long Id { set; get; }

        public long TeacherId { set; get; }

        public string Type { get; set; }

        public string Url { get; set; }

        public string FileExtension { get; set; }

        public string FileName { get; set; }

        public string Status { get; set; }

        public bool? CanDelete { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string BackgroundId { get; set; }

        public string BackgroundTitle { get; set; }

        public TeacherBackgroundViewModel Background { get; set; }
        public static List<TeacherMemoryViewModel> Convert(List<TeacherMemory> lst)
        {
            if (lst == null)
            {
                return new List<TeacherMemoryViewModel>();
            }
            var res = from s in lst
                      select new TeacherMemoryViewModel
                      {
                          Background = new TeacherBackgroundViewModel()
                          {
                              Id = s.TeacherBackground != null ? s.TeacherBackground.Id : string.Empty,
                              Title = s.TeacherBackground != null ? s.TeacherBackground.Title : string.Empty,
                              Description = s.TeacherBackground != null ? s.TeacherBackground.Description : string.Empty,
                              Type = s.TeacherBackground != null ? s.TeacherBackground.Type : string.Empty,
                              Status = s.TeacherBackground != null ? s.TeacherBackground.Status : string.Empty,
                              CanDelete = s.TeacherBackground != null ? s.TeacherBackground.CanDelete : false,
                              CreatedBy = s.TeacherBackground != null ? s.TeacherBackground.CreatedBy : string.Empty,
                              CreatedDate = s.TeacherBackground != null ? s.TeacherBackground.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty
                          },
                          Id = s.Id,
                          TeacherId = s.TeacherId,
                          Type = s.Type,
                          Url = s.URL,
                          FileExtension = s.FileExtension,
                          FileName = s.FileName,
                          BackgroundId = s.BackgroundId,
                          Status = s.Status,
                          CanDelete = s.CanDelete,
                          CreatedBy = s.CreatedBy,
                          CreatedDate = s.CreatedDate.HasValue ? s.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                      };
            return res.ToList();
        }
    }
}
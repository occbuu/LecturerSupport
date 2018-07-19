using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class TeacherBackgroundViewModel
    {
        public string Id { get; set; }

        public long? TeacherId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        public bool? CanDelete { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public static List<TeacherBackgroundViewModel> Convert(List<TeacherBackground> lst)
        {
            if (lst == null)
            {
                return new List<TeacherBackgroundViewModel>();
            }
            var res = from s in lst
                      select new TeacherBackgroundViewModel
                      {
                          Id = s.Id,
                          TeacherId = s.TeacherId,
                          Title = s.Title,
                          Description = s.Description,
                          Type = s.Type,
                          Status = s.Status,
                          CanDelete = s.CanDelete,
                          CreatedBy = s.CreatedBy,
                          CreatedDate = s.CreatedDate.HasValue ? s.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                      };
            return res.ToList();
        }

        public static TeacherBackgroundViewModel Convert(TeacherBackground entity)
        {
            if (entity == null)
            {
                return new TeacherBackgroundViewModel();
            }
            var res = new TeacherBackgroundViewModel
            {
                Id = entity.Id,
                TeacherId = entity.TeacherId,
                Title = entity.Title,
                Description = entity.Description,
                Type = entity.Type,
                Status = entity.Status,
                CanDelete = entity.CanDelete,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate.HasValue ? entity.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
            };
            return res;
        }
    }
}
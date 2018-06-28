using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LS.Web.Models
{
    using Model;

    public class StudentExerciseViewModel
    {
        public long Id { set; get; }
        public long? AssignmentConfigId { set; get; }
        public long? StudentId { set; get; }
        public long? ClassId { set; get; }
        public long? DocumentId { set; get; }
        public string CreatedOn { set; get; }
        public string FileName { set; get; }
        public string FileExtension { set; get; }
        public string Status { set; get; }
        public string ModifiedBy { set; get; }
        public string ModifiedOn { set; get; }
        public string StudentName { set; get; }
        public string Contents { set; get; }
        public string UserId { set; get; }

        public static List<StudentExerciseViewModel> Convert(List<StudentExcercise> list)
        {

            if (list == null)
            {
                return new List<StudentExerciseViewModel>();
            }

            var res = from s in list
                      select new StudentExerciseViewModel
                      {
                          Id = s.Id,
                          AssignmentConfigId = s.AssignmentConfigId,
                          StudentId = s.StudentId,
                          ClassId = s.ClassId,
                          DocumentId = s.DocumentId,
                          CreatedOn = s.CreatedOn.HasValue ? s.CreatedOn.Value.ToString("MM/dd/yyyy") : string.Empty,
                          ModifiedBy = s.ModifiedBy,
                          ModifiedOn = s.ModifiedOn.HasValue ? s.ModifiedOn.Value.ToString("MM/dd/yyyy") : string.Empty,
                          Status = s.Status,
                          FileName = s.FileName,
                          FileExtension = s.FileExtension,
                          StudentName = s.Student.Object.FullName,
                          Contents = s.AssignmentConfig.Content,
                          UserId = s.Student.ObjectId,
                      };
            return res.ToList();
        }

    }
}
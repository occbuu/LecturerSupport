using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;
    using System;

    public class ClassViewModel
    {
        public long Id { set; get; }
        public string Code { set; get; }
        public string Value { set; get; }
        public string Prerequisition { set; get; }
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public string Status { set; get; }
        public string Name { set; get; }
        public string University { set; get; }
        public long? UniversityId { set; get; }
        public string Teacher { set; get; }
        public long? TeacherId { set; get; }
        public long? SubjectId { set; get; }
        public string TeacherAssistant { set; get; }
        public long? TeacherAssistantId { set; get; }
        public string Subject { set; get; }
        public string CreatedBy { set; get; }
        public string CreatedOn { set; get; }
        public string ModifiedBy { set; get; }
        public string ModifiedOn { set; get; }
        public string Images { set; get; }
        public static List<ClassViewModel> Convert(List<Class> list)
        {

            if (list == null)
            {
                return new List<ClassViewModel>();
            }

            var res = from s in list
                      select new ClassViewModel
                      {
                          Id = s.Id,
                          Value = s.Description,
                          Code = s.Code,
                          Prerequisition = s.Prerequisition,
                          StartDate = s.StartDate.HasValue ? s.StartDate.Value.ToString("MM/dd/yyyy") : string.Empty,
                          EndDate = s.EndDate.HasValue ? s.EndDate.Value.ToString("MM/dd/yyyy") : string.Empty,
                          CreatedBy = s.CreatedBy,
                          CreatedOn = s.CreatedOn.HasValue ? s.CreatedOn.Value.ToString("MM/dd/yyyy") : string.Empty,
                          ModifiedBy = s.ModifiedBy,
                          ModifiedOn = s.ModifiedOn.HasValue ? s.ModifiedOn.Value.ToString("MM/dd/yyyy") : string.Empty,
                          Status = s.Status,
                          Name = s.Name,
                          Subject = s.Subject.SubjectName,
                          University = s.University.Name,
                          UniversityId = s.UniversityId,
                          Teacher = s.Teacher.FullName,
                          TeacherAssistant = s.Teacher1.FullName,
                          Images = s.Images,
                          SubjectId = s.SubjectId,
                          TeacherId = s.TeacherId,
                          TeacherAssistantId = s.TeachingAssistantId
                      };
            return res.ToList();
        }

        public static ClassViewModel Convert2(Class list)
        {

            if (list == null)
            {
                return new ClassViewModel();
            }

            var vm = new ClassViewModel();
            vm.Id = list.Id;
            vm.Name = list.Name;
            vm.Value = list.Description;
            vm.Subject = list.Subject.SubjectName;
            vm.Teacher = list.Teacher.FullName;
            vm.TeacherAssistant = list.Teacher1.FullName;
            return vm;
        }
    }
}
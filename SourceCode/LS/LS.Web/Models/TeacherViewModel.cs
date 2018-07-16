using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class TeacherViewModel
    {

        public TeacherViewModel()
        {
            TeacherVM = new List<TeacherViewModels>();
            TeacherBackgroundVM = new List<TeacherBackgroundViewModel>();
        }

        #region -- Properties -- 

        public long? Id { set; get; }

        public string FullName { set; get; }

        public string Description { set; get; }

        public long? TypeTeacherId { set; get; }

        public string Status { set; get; }

        public string Birthday { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string Owner { get; set; }

        public string Gender { get; set; }

        public List<TeacherBackgroundViewModel> LstTeacherBackground { get; set; }


        public List<TeacherViewModels> TeacherVM { get; set; }

        public List<TeacherMemoryViewModel> TeacherMemoryVM { get; set; }

        public List<TeacherBackgroundViewModel> TeacherBackgroundVM { get; set; }

        public List<TeacherStudiesViewModel> TeacherStudiesVM { get; set; }

        public List<TeacherResearchWorkViewModel> TeacherResearchWorkVM { get; set; }

        public List<TeacherDelegateStudentViewModel> TeacherDelegateStudentVM { get; set; }


        #endregion

    }

    public class TeacherViewModels
    {
        #region -- Properties --

        public long? Id { set; get; }

        public string FullName { set; get; }

        public string Description { set; get; }

        public long? TypeTeacherId { set; get; }

        public string Status { set; get; }

        public string Birthday { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string Owner { get; set; }

        public string Gender { get; set; }

        public List<TeacherBackground> TeacherBackgroundVM { get; set; }

        #endregion

        #region -- Methods --

        public static List<TeacherViewModels> Convert(List<Teacher> lst)
        {
            if (lst == null)
            {
                return new List<TeacherViewModels>();
            }
            var res = from s in lst
                      select new TeacherViewModels
                      {
                          Id = s.Id,
                          FullName = s.FullName,
                          TypeTeacherId = s.TypeTeacherId,
                          Description = s.Description,
                          Status = s.Status,
                          Birthday = s.Birthday.HasValue ? s.Birthday.Value.ToString("dd/MM/yyyy") : string.Empty,
                          PhoneNumber = s.PhoneNumber,
                          Address = s.Address,
                          CreatedBy = s.CreatedBy,
                          CreatedDate = s.CreatedDate.HasValue ? s.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          Owner = s.Owner,
                          Gender = s.Gender
                      };
            return res.ToList();
        }

        public static List<TeacherViewModels> ConvertToVM(List<Teacher> lst)
        {
            if (lst == null)
            {
                return new List<TeacherViewModels>();
            }
            var res = from s in lst
                      select new TeacherViewModels
                      {
                          Id = s.Id,
                          FullName = s.FullName,
                          TypeTeacherId = s.TypeTeacherId,
                          Description = s.Description,
                          Status = s.Status,
                          Birthday = s.Birthday.HasValue ? s.Birthday.Value.ToString("dd/MM/yyyy") : string.Empty,
                          PhoneNumber = s.PhoneNumber,
                          Address = s.Address,
                          CreatedBy = s.CreatedBy,
                          CreatedDate = s.CreatedDate.HasValue ? s.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          Owner = s.Owner,
                          Gender = s.Gender
                      };
            return res.ToList();
        }

        #endregion
    }
}
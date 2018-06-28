using System;
using W = System.Web;
using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;
    using BLL;
    using IBLL;

    public class UserFrontVM
    {
        private IStudentService _studentService = new StudentService();

        public UserFrontVM()
        {
        }

        public UserFrontVM(User m)
        {
            var userRole = m.UserRoles.FirstOrDefault();
            UserId = m.UserId;
            Role = userRole.Role.Name;
            Permission = userRole.Role.FunctionRoles.Select(p => p.Function.Code).ToList();
            Name = m.Object.FullName;
            StudentId = _studentService.getSudentIdByObjectId(m.ObjectId);
        }

        public string Name { get; set; }

        public List<string> Permission { get; set; }

        public string Role { get; set; }

        public string UserId { set; get; }

        public string Pwd { set; get; }

        public string OjectId { set; get; }

        public DateTime? LastLogin { set; get; }

        public string Avatar { set; get; }

        public string Status { set; get; }

        public long? StudentId { set; get; }

        public static UserFrontVM Convert(User usr)
        {
            if (usr == null)
            {
                return null;
            }
            var s = new UserFrontVM();
            s.UserId = usr.UserId;
            s.Pwd = usr.Pwd;
            s.OjectId = usr.ObjectId;
            s.Status = usr.Status;
            s.LastLogin = usr.LastLogin;
            s.Avatar = usr.Avatar;
            return s;
        }

        public static UserFrontVM CurrentUser
        {
            get
            {
                return (UserFrontVM)W.HttpContext.Current.Session["CurrentUser"];
            }
            set
            {
                W.HttpContext.Current.Session["CurrentUser"] = value;
            }
        }

        public List<UserFrontVM> Convert(List<User> list)
        {
            if (list == null)
            {
                return new List<UserFrontVM>();
            }
            var res = from s in list
                      select new UserFrontVM
                      {
                          OjectId = s.ObjectId,
                          Name = s.Object.FullName,
                          Role = s.UserRoles.FirstOrDefault() == null ? string.Empty : s.UserRoles.FirstOrDefault().Role.Remarks
                      };
            return res.ToList();
        }
    }
    public class ChangePassword
    {
        public string UserId { set; get; }
        public string OldPassword { set; get; }
        public string NewPassword { set; get; }
        public string ConfirmPassword { set; get; }
    }

}
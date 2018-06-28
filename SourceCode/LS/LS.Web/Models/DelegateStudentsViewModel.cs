using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class DelegateStudentsViewModel
    {
        public List<DelegateStudentsVM> DelegateStudents { set; get; }
    }

    #region -- Delegate Students --

    public class DelegateStudentsDetailVM
    {
        public string Value { set; get; }

        public static List<DelegateStudentsDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<DelegateStudentsDetailVM>();
            }
            var res = from s in lst
                      select new DelegateStudentsDetailVM
                      {
                          Value = s.Value,
                      };
            return res.ToList();
        }
    }

    public class NameDelegateStudentsVM
    {
        public string Value { set; get; }
        public string Image { set; get; }
        public string Brief { set; get; }

        public List<DelegateStudentsDetailVM> DelegateStudentsDetail { set; get; }
        public static List<NameDelegateStudentsVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameDelegateStudentsVM>();
            }
            var res = from s in lst
                      select new NameDelegateStudentsVM
                      {
                          Brief = s.brief,
                          Value = s.Value,
                          Image = s.URL1
                      };
            return res.ToList();
        }
    }

    public class DelegateStudentsVM
    {
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public string Brief { set; get; }
        public List<NameDelegateStudentsVM> NameDelegateStudents { set; get; }
    }

    #endregion
}
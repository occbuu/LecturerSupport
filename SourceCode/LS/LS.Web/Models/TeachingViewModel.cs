using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;
    
    public class TeachingViewModel
    {
        public List<UTeachingVM> UTeching { set; get; }
        public List<PTeachingVM> PTeaching { set; get; }
    }

    #region -- Undergraduate Teaching Model--

    public class UTeachingDetailVM
    {
        public string Brief { set; get; }
        public string Value { set; get; }
        public string Images { set; get; }
        public string Name { set; get; }
        public static List<UTeachingDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<UTeachingDetailVM>();
            }
            var res = from s in lst
                      select new UTeachingDetailVM
                      {
                          Brief = s.brief,
                          Value = s.Value,
                          Images = s.URL1,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NameUTeachingVM
    {
        public string Brief { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<UTeachingDetailVM> UTeachingDetail { set; get; }
        public static List<NameUTeachingVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameUTeachingVM>();
            }
            var res = from s in lst
                      select new NameUTeachingVM
                      {
                          Brief = s.brief,
                          Name = s.Name,
                          Value = s.Value
                      };
            return res.ToList();
        }
    }

    public class UTeachingVM
    {
        public string Brief { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NameUTeachingVM> NameUTeaching { set; get; }
    }

    #endregion

    #region -- Postgraduate Teaching --

    public class PTeachingDetailVM
    {
        public string Brief { set; get; }
        public string Value { set; get; }
        public string Images { set; get; }
        public string Name { set; get; }
        public static List<PTeachingDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<PTeachingDetailVM>();
            }
            var res = from s in lst
                      select new PTeachingDetailVM
                      {
                          Brief = s.brief,
                          Value = s.Value,
                          Images = s.URL1,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NamePTeachingVM
    {
        public string Brief { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<PTeachingDetailVM> PTeachingDetail { set; get; }
        public static List<NamePTeachingVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NamePTeachingVM>();
            }
            var res = from s in lst
                      select new NamePTeachingVM
                      {
                          Brief = s.brief,
                          Name = s.Name,
                          Value = s.Value
                      };
            return res.ToList();
        }
    }

    public class PTeachingVM
    {
        public string Brief { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NamePTeachingVM> NamePTeaching { set; get; }
    }

    #endregion

}
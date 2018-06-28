using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class StudiesViewModel
    {
        public List<ResearchInterestsVM> ResearchInterests { set; get; }
    }
    #region -- Research Interest --

    public class ResearchInterestsDetailVM
    {
        public string Brief { set; get; }
        public string Value { set; get; }
        public string Images { set; get; }
        public string Name { set; get; }
        public static List<ResearchInterestsDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<ResearchInterestsDetailVM>();
            }
            var res = from s in lst
                      select new ResearchInterestsDetailVM
                      {
                          Brief = s.brief,
                          Value = s.Value,
                          Images = s.URL1,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NameResearchInterestsVM
    {
        public string Brief { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public string Time { set; get; }
        public List<ResearchInterestsDetailVM> ResearchInterestsDetail { set; get; }
        public static List<NameResearchInterestsVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameResearchInterestsVM>();
            }
            var res = from s in lst
                      select new NameResearchInterestsVM
                      {
                          Brief = s.brief,
                          Name = s.Name,
                          Value = s.Value,
                          Time = s.URL1
                      };
            return res.ToList();
        }
    }

    public class ResearchInterestsVM
    {
        public string Brief { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NameResearchInterestsVM> NameResearchInterests { set; get; }
    }

    #endregion
}
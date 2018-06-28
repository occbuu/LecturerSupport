using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class WhoAmIDetailVM
    {
        public string Value { set; get; }
        public string Images { set; get; }
        public static List<WhoAmIDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<WhoAmIDetailVM>();
            }
            var res = from s in lst
                      select new WhoAmIDetailVM
                      {
                          Value = s.Value,
                          Images = s.URL1
                      };
            return res.ToList();
        }
    }

    public class WhoAmIVM
    {
        public long Id { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<WhoAmIDetailVM> WhoAmIDetail { set; get; }
    }

    public class AboutMeViewModel
    {
        public List<WhoAmIVM> WhoAmI { set; get; }
        public List<EBackgroundVM> EBackground { set; get; }
        public List<CurrentJobVM> CurrentJob { set; get; }
    }

    public class EBackgroudDetailVM
    {
        public long Id { set; get; }
        public string Value { set; get; }
        public string Images { set; get; }
        public string Name { set; get; }
        public static List<EBackgroudDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<EBackgroudDetailVM>();
            }
            var res = from s in lst
                      select new EBackgroudDetailVM
                      {
                          Id = s.Id,
                          Value = s.Value,
                          Images = s.URL1,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NameBackgroundVM
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<EBackgroudDetailVM> EBackgroudDetail { set; get; }
        public static List<NameBackgroundVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameBackgroundVM>();
            }
            var res = from s in lst
                      select new NameBackgroundVM
                      {
                          Id = s.Id,
                          Name = s.Name,
                          Value = s.Value
                      };
            return res.ToList();
        }
    }

    public class EBackgroundVM
    {
        public long Id { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NameBackgroundVM> NameBackground { set; get; }
    }

    public class CurrentJobDetailVM
    {
        public long Id { set; get; }
        public string Value { set; get; }
        public string Images { set; get; }
        public string Name { set; get; }
        public static List<CurrentJobDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<CurrentJobDetailVM>();
            }
            var res = from s in lst
                      select new CurrentJobDetailVM
                      {
                          Id = s.Id,
                          Value = s.Value,
                          Images = s.URL1,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NameCurrentJobVM
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<CurrentJobDetailVM> CurrentJobDetail { set; get; }
        public static List<NameCurrentJobVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameCurrentJobVM>();
            }
            var res = from s in lst
                      select new NameCurrentJobVM
                      {
                          Id = s.Id,
                          Name = s.Name,
                          Value = s.Value
                      };
            return res.ToList();
        }
    }

    public class CurrentJobVM
    {
        public long Id { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NameCurrentJobVM> NameCurrentJob { set; get; }
    }
}
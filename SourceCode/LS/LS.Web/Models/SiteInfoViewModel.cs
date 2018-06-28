using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class SiteInfoViewModel
    {
        public long Id { get; set; }
        public string CommonTypeId { get; set; }
        public string Brief { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public bool? CanDelete { get; set; }
        public int? Qty { get; set; }

        public static List<SiteInfoViewModel> Convert(List<CommonCode> list)
        {

            if (list == null)
            {
                return new List<SiteInfoViewModel>();
            }

            var res = from s in list
                      select new SiteInfoViewModel
                      {
                          CommonTypeId= s.CommonTypeId,
                          Qty= s.Qty,
                          Name = s.StrValue1
                      };
            return res.ToList();
        }

        public static List<SiteInfoViewModel> Convert(List<SiteInfo> list)
        {

            if (list == null)
            {
                return new List<SiteInfoViewModel>();
            }

            var res = from s in list
                      select new SiteInfoViewModel
                      {
                          Id = s.Id,
                          Brief = s.brief,
                          Type = s.type,
                          Name = s.Name,
                          Value = s.Value,
                          Status = s.Status,
                          CanDelete = s.CanDelete,
                          Qty = s.qty
                      };
            return res.ToList();
        }

        public static List<SiteInfoViewModel> Convert(List<CommonType> list)
        {

            if (list == null)
            {
                return new List<SiteInfoViewModel>();
            }

            var res = from s in list
                      select new SiteInfoViewModel
                      {
                          CommonTypeId = s.CommonTypeId,
                          Qty= s.Qty
                      };
            return res.ToList();
        }
    }
}
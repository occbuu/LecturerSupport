using System.Collections.Generic;
using System.Linq;
using System;

namespace LS.Web.Models
{
    using Model;

    public class CommonCodeViewModel
    {
        public string CommonTypeId { get; set; }

        public string ValueDisplay { get; set; }

        public string CommonId { get; set; }

        public decimal NumValue1 { get; set; }

        public decimal NumValue2 { get; set; }

        public bool? CanDelete { get; set; }

        public string CreateBy { get; set; }

        public string CreateDate { get; set; }

        public List<CommonCodeDetailVM> commonCodeDetailsVM { get; set; }

        public static List<CommonCodeViewModel> Convert(List<CommonCode> list)
        {
            if (list == null)
            {
                return new List<CommonCodeViewModel>();
            }

            var res = from s in list
                      select new CommonCodeViewModel
                      {
                          CommonTypeId = s.CommonTypeId,
                          CommonId = s.CommonId,
                          ValueDisplay = s.StrValue1,
                          NumValue1 = s.NumValue1.HasValue ? s.NumValue1.Value : 0,
                          NumValue2 = s.NumValue2.HasValue ? s.NumValue2.Value : 0,
                          CanDelete = s.CanDelete,
                          CreateBy = s.CreatedBy,
                          CreateDate = s.CreatedDate.HasValue ? s.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                      };
            return res.ToList();
        }
    }

    public class CommonCodeDetailVM
    {
        public string CommonId { get; set; }

        public string CommonTypeId { get; set; }

        public string StrValue1 { get; set; }

        public string StrValue2 { get; set; }

        public string StrValue3 { get; set; }

        public decimal? Number1 { get; set;}

        public static List<CommonCodeDetailVM> Convert(List<CommonCode> list)
        {
            if (list == null)
            {
                return new List<CommonCodeDetailVM>();
            }
            var res = from s in list
                      select new CommonCodeDetailVM
                      {
                          CommonId = s.CommonId,
                          CommonTypeId = s.CommonTypeId,
                          StrValue1 = s.StrValue1,
                          StrValue2 = s.StrValue2,
                          StrValue3 = s.StrValue3,
                          Number1 = s.NumValue1
                      };
            return res.ToList();
        }
    }
}
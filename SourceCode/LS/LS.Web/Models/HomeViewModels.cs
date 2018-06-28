using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;
    public class HomeViewModels
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }
        public static List<HomeViewModels> Convert(List<SiteInfo> list)
        {
            if (list == null)
            {
                return new List<HomeViewModels>();
            }

            var res = from s in list
                      select new HomeViewModels
                      {
                          Name = s.Name,
                          Value = s.Value,
                          ParentId = s.ParentId
                      };

            return res.ToList();
        }

        public List<CommentVM> CommentVM { get; set; }

        public List<CommonCodeVM> CommonCodeVM { get; set; }

        public List<TopBarVM> TopBarVM { get; set; }

        public List<FooterVM> FooterVM { get; set; }

        public List<ContentVM> ContentVM { get; set; }

        public List<TeacherMemoryViewModel> TeacherMemoryVM { get; set; }

        public List<DashBoardVM> DashBoardVM { get; set; }

        public List<TeacherDelegateStudentViewModel> TeacherDelegateStudentVM { get; set; }

        public List<SocialNetworkVM> SocialNetworkVM { get; set; }

    }

    public class CommonCodeVM
    {
        public string CommonTypeId { get; set; }
        public string CommonId { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public int? Qty { get; set; }
        public List<CommonCodeDetailsVM> commonCodeDetailsVM { get; set; }
        public static List<CommonCodeVM> Convert(List<CommonCode> list)
        {
            if (list == null)
            {
                return new List<CommonCodeVM>();
            }

            var res = from s in list
                      select new CommonCodeVM
                      {
                          CommonTypeId = s.CommonTypeId,
                          CommonId = s.CommonId,
                          Value1 = s.StrValue1,
                          Value2 = s.StrValue2,
                          Value3 = s.StrValue3,
                          Qty = s.Qty
                      };

            return res.ToList();
        }
    }

    public class CommonCodeDetailsVM
    {
        public string CommonId { get; set; }
        public string CommonTypeId { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }

        public static List<CommonCodeDetailsVM> Convert(List<CommonCode> list)
        {
            if (list == null)
            {
                return new List<CommonCodeDetailsVM>();
            }
            var res = from s in list
                      select new CommonCodeDetailsVM
                      {
                          CommonId = s.CommonId,
                          CommonTypeId = s.CommonTypeId,
                          Value1 = s.StrValue1,
                          Value2 = s.StrValue2,
                          Value3 = s.StrValue3
                      };
            return res.ToList();
        }
    }

    public class TopBarVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }
    }

    public class SocialNetworkVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }
    }

    public class FooterVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }
        public List<FooterDetailsVM> footerDetailsVM { get; set; }
    }

    public class FooterDetailsVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }

        public static List<FooterDetailsVM> Convert(List<SiteInfo> list)
        {
            if (list == null)
            {
                return new List<FooterDetailsVM>();
            }
            var res = from s in list
                      select new FooterDetailsVM
                      {
                          Name = s.Name,
                          Value = s.Value,
                          ParentId = s.ParentId
                      };
            return res.ToList();
        }
    }

    public class ContentVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }
        public List<ContentDetailsVM> contentDetailsVM { get; set; }
    }

    public class ContentDetailsVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }

        public static List<ContentDetailsVM> Convert(List<SiteInfo> list)
        {
            if (list == null)
            {
                return new List<ContentDetailsVM>();
            }
            var res = from s in list
                      select new ContentDetailsVM
                      {
                          Name = s.Name,
                          Value = s.Value,
                          ParentId = s.ParentId
                      };
            return res.ToList();
        }
    }

    public class DashBoardVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }
        public List<DashBoardDetailsVM> dashBoardDetailsVM { get; set; }
    }

    public class DashBoardDetailsVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentId { get; set; }

        public static List<DashBoardDetailsVM> Convert(List<SiteInfo> list)
        {
            if (list == null)
            {
                return new List<DashBoardDetailsVM>();
            }
            var res = from s in list
                      select new DashBoardDetailsVM
                      {
                          Name = s.Name,
                          Value = s.Value,
                          ParentId = s.ParentId
                      };
            return res.ToList();
        }
    }

    public class CommentDetailVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Brief { get; set; }

        public static List<CommentDetailVM> Convert(List<SiteInfo> list)
        {
            if (list == null)
            {
                return new List<CommentDetailVM>();
            }
            var res = from s in list
                      select new CommentDetailVM
                      {
                          Name = s.Name,
                          Value = s.Value,
                          Brief = s.brief
                      };
            return res.ToList();
        }
    }

    public class CommentVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Brief { get; set; }
        public List<CommentDetailVM> commentDetailVM { get; set; }
    }
}
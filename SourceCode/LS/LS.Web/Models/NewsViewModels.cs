using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{

    using Model;
    using IBLL;
    using BLL;
    using System;

    public class NewsViewModels
    {
        private static ICommonCodeService _commonCodeService = new CommonCodeService();
        private static ILinksService _linksService = new LinksService();

        public long Id { get; set; }
        public string CategoryId { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string Hometown { get; set; }
        public string Editor { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public string Links { get; set; }
        public string NewsBrief { get; set; }
        public string NewsDetail { get; set; }
        public string Images { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int TotalComment { get; set; }
        public List<ListUrlImages> LstImages { get; set; }

        public static List<NewsViewModels> Convert(List<News> list)
        {
            if (list == null)
            {
                return new List<NewsViewModels>();
            }
            var res = from s in list
                      select new NewsViewModels
                      {
                          Id = s.Id,
                          CategoryId = _commonCodeService.getStrValue1(s.CategoryId, "NewsCategory"),
                          Category = s.CategoryId,
                          Title = s.Title,
                          CreatedBy = s.CreatedBy,
                          FullName = s.User == null ? string.Empty : s.User.Object.FullName,
                          Birthday = s.User == null ? string.Empty : s.User.Object.DoB.HasValue ? s.User.Object.DoB.Value.ToString("dd/MM/yyyy") : string.Empty,
                          Hometown = s.User == null ? string.Empty : s.User.Object.PoB,
                          Editor = s.Editor,
                          Time = s.Time.HasValue ? s.Time.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          Date = s.Time.HasValue ? s.Time.Value : DateTime.Now,
                          Links = s.Links,
                          NewsBrief = s.NewsBrief,
                          NewsDetail = s.NewsDetail,
                          Images = s.Images,
                          Description = s.Description,
                          Keyword = s.Keyword,
                          LstImages = ListUrlImages.Convert(_linksService.GetUrlImagesOfPost(s.Id.ToString()))
                      };

            return res.ToList();
        }

        public static NewsViewModels Convert(News s)
        {
            if (s == null)
            {
                return new NewsViewModels();
            }

            var res = new NewsViewModels
            {
                Id = s.Id,
                CategoryId = _commonCodeService.getStrValue1(s.CategoryId, "NewsCategory"),
                Category = s.CategoryId,
                Title = s.Title,
                CreatedBy = s.CreatedBy,
                Editor = s.Editor,
                Time = s.Time.HasValue ? s.Time.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                Date = s.Time.HasValue ? s.Time.Value : DateTime.Now,
                Links = s.Links,
                NewsBrief = s.NewsBrief,
                NewsDetail = s.NewsDetail,
                Images = s.Images,
                Keyword = s.Keyword,
                Description = s.Description
            };

            return res;
        }
    }

    public class CategoryViewModel
    {
        public CommonCode Category { get; set; }
        public CommonCode Category_Parent { get; set; }
        public List<NewsViewModels> LstNews { get; set; }
        public List<NewsViewModels> LstNewsPagination { get; set; }
        public int TotalNews { get; set; }
        public List<CommonCodeViewModel> LstCategory { get; set; }
        public int TotalCategory { get; set; }
        public List<CommonCodeViewModel> LstChildCategory { get; set; }
        public List<CommonCodeViewModel> LstTypePost { get; set; }

        public NewsViewModels DetailNew { get; set; }
        public List<CommentsViewModel> ListComment { get; set; }
        public int TotalComment { get; set; }
        public List<LinksViewModel> ListImage { get; set; }
        public List<TagsViewModel> ListTags { get; set; }
    }

    public class ListUrlImages
    {
        public string Url { get; set; }

        public static List<ListUrlImages> Convert(List<string> list)
        {
            if (list == null)
            {
                return new List<ListUrlImages>();
            }
            var res = from s in list
                      select new ListUrlImages
                      {
                          Url = s
                      };

            return res.ToList();
        }
    }
}
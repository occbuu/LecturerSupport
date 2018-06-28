using LS.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Model;

    public class AnnouncementController : Controller
    {
        private INewsService _newsService = new NewsService();
        private ICommentService _commentService = new CommentService();
        private ILinksService _linksService = new LinksService();
        private ITagsService _tagsService = new TagsService();
        private ICommonCodeService _commonCodeService = new CommonCodeService();

        public static string page_keyword { get; set; }
        public static string page_description { get; set; }

        public ActionResult Index(string categoryId)
        {
            try
            {
                if (categoryId != null)
                {
                    var model = new CategoryViewModel();
                    var lstNews = new List<NewsViewModels>();
                    var lst = _newsService.GetNews(categoryId);
                    var category = _commonCodeService.SearchByCommonIdAndCommonType(categoryId, "NewsCategory").FirstOrDefault();
                    //Get list Tags
                    var lstTags = new List<TagsViewModel>();
                    lstTags = TagsViewModel.Convert(_tagsService.GetListTag(categoryId, "categoryid"));

                    //Get list news
                    var lstNewsPa = new List<NewsViewModels>();
                    int total = 0;
                    var lstTemp = _newsService.SearchCate(categoryId, 1, 4, out total);
                    lstNewsPa = NewsViewModels.Convert(lstTemp);

                    ViewBag.CategoryId = categoryId;

                    lstNews = NewsViewModels.Convert(lst);
                    model.LstNews = lstNews;
                    model.ListTags = lstTags;
                    model.TotalNews = total;
                    model.LstNewsPagination = lstNewsPa;

                    return View("Index", model);
                }
                else
                {
                    return PartialView("_404");
                }
            }
            catch (Exception)
            {
                return PartialView("_404");
            }
        }

        [Route("DetailAnnouncement/{linkthanthien}")]
        public ActionResult DetailAnnouncement(string linkthanthien)
        {
            try
            {
                string id = "";
                string[] str = linkthanthien.Split('-');
                id = str[str.Length - 1];
                if (id != null)
                {
                    CategoryViewModel model = new CategoryViewModel();

                    //Get news
                    var news = new News();
                    news = _newsService.GetById(Int64.Parse(id));
                    var cate = news.CategoryId;

                    //Get detail news
                    var detailNews = new NewsViewModels();
                    detailNews = NewsViewModels.Convert(_newsService.GetDetailNews(Int64.Parse(id)));
                    model.DetailNew = detailNews;

                    //Get comment
                    var lstCmt = new List<CommentsViewModel>();
                    lstCmt = CommentsViewModel.Convert(_commentService.SearchByNewsLimit(Int64.Parse(id), "1", 0, 2));
                    model.ListComment = lstCmt;
                    model.TotalComment = _commentService.TotalComments(Int64.Parse(id));

                    //Get list Images
                    var lstImages = new List<LinksViewModel>();
                    var data = _linksService.GetImagesOfPost(id);
                    lstImages = LinksViewModel.Convert(data);

                    //Get list Tags
                    var lstTags = new List<TagsViewModel>();
                    lstTags = TagsViewModel.Convert(_tagsService.GetListTag(detailNews.Category, "categoryid"));

                    //Get list news
                    var lstNews = new List<NewsViewModels>();
                    int total = 0;
                    var lst = _newsService.SearchCate(cate, 1, 4, out total);
                    lstNews = NewsViewModels.Convert(lst);

                    page_keyword = model.DetailNew.Keyword;
                    page_description = model.DetailNew.Description;

                    ViewBag.Category = detailNews.CategoryId;
                    ViewBag.CategoryId = detailNews.Category;

                    model.TotalNews = total;
                    model.LstNews = lstNews;
                    model.ListTags = lstTags;
                    model.ListImage = lstImages;
                    return View("DetailAnnouncement", model);
                }
                else
                {
                    return PartialView("_404");
                }
            }
            catch (Exception ex)
            {
                return PartialView("_404");
            }
        }

        [HttpPost]
        public ActionResult getDataNewsPage(int page, string categoryId)
        {
            var res = Json(new { status = 0, TotalRecord = 0, sErr = "" });
            try
            {
                var lstNews = new List<NewsViewModels>();
                int total = 0;
                var lst = _newsService.SearchCate(categoryId, page, 4, out total);

                lstNews = NewsViewModels.Convert(lst);
                res = Json(new { status = 1, TotalRecord = total, sErr = "", data = lstNews });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, TotalRecord = 0, sErr = ex.Message });
            }
            return res;
        }
    }
}
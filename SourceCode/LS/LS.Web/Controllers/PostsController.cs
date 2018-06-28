using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LS.Web.Controllers
{

    using BLL;
    using IBLL;
    using Model;
    using Models;
    using Utility;

    /// <summary>
    /// Post controller
    /// </summary>
    public class PostsController : Controller
    {
        #region --Properties--

        private INewsService _newsService = new NewsService();
        private ICommentService _commentService = new CommentService();
        private IUsersService _userService = new UsersService();
        private ICommonCodeService _commonCodeService = new CommonCodeService();
        private ILinksService _linksService = new LinksService();
        private ITagsService _tagsService = new TagsService();

        public static string page_keyword { get; set; }

        public static string page_description { get; set; }

        #endregion

        #region -- View --

        public ActionResult Index(string categoryId, string id)
        {
            try
            {
                if (categoryId != null)
                {
                    var category = _commonCodeService.SearchByCommonIdAndCommonType(categoryId, "NewsCategory").FirstOrDefault();
                    var category_Parents = category;

                    if (category.NumValue1 == 2)
                    {
                        string CatId_Parents = categoryId;
                        var a_str = categoryId.Split('-');
                        CatId_Parents = a_str[0] + "-" + a_str[1];
                        category_Parents = _commonCodeService.SearchByCommonIdAndCommonType(CatId_Parents, "NewsCategory").FirstOrDefault();
                    }
                    if (category != null)
                    {
                        var model = new CategoryViewModel();
                        var lstNews = new List<NewsViewModels>();
                        var lstCategory = new List<CommonCodeViewModel>();
                        int total = 0;
                        int total1 = 0;
                        var lst = _newsService.SearchCate(categoryId, 1, 4, out total);
                        var listCate = _commonCodeService.SearchByCommonIdAndCommonTypeWithPagination(categoryId, "NewsCategory", 1, 4, out total1);

                        lstNews = NewsViewModels.Convert(lst);
                        lstCategory = CommonCodeViewModel.Convert(listCate);

                        //Get list Tags
                        var lstTags = new List<TagsViewModel>();
                        lstTags = TagsViewModel.Convert(_tagsService.GetListTag(categoryId, "categoryid"));

                        model.ListTags = lstTags;
                        model.LstNews = lstNews;
                        model.TotalNews = total;
                        model.LstCategory = lstCategory;
                        model.TotalCategory = total1;
                        model.Category = category;
                        model.Category_Parent = category_Parents;

                        ViewBag.Category = category.StrValue1;
                        ViewBag.CategoryId = category.CommonId;
                        return View("Index", model);
                    }
                    else
                    {
                        return PartialView("_404");
                    }
                }
                else if (id != null)
                {
                    CategoryViewModel model = new CategoryViewModel();
                    model.DetailNew = GetDetailNews(Int64.Parse(id));
                    model.ListComment = GetComments(Int64.Parse(id));
                    model.TotalComment = _commentService.TotalComments(Int64.Parse(id));

                    var news = new News();
                    news = _newsService.GetById(Int64.Parse(id));
                    var cate = news.CategoryId;
                    var category = _commonCodeService.SearchByCommonIdAndCommonType(cate, "NewsCategory").FirstOrDefault();
                    var category_Parents = category;

                    if (category.NumValue1 == 2)
                    {
                        string CatId_Parents = cate;
                        var a_str = cate.Split('-');
                        CatId_Parents = a_str[0] + "-" + a_str[1];
                        category_Parents = _commonCodeService.SearchByCommonIdAndCommonType(CatId_Parents, "NewsCategory").FirstOrDefault();
                    }
                    model.Category = category;
                    model.Category_Parent = category_Parents;
                    ViewBag.Category = category.StrValue1;
                    ViewBag.CategoryId = category.CommonId;

                    var lstNews = new List<NewsViewModels>();
                    int total = 0;
                    var lst = _newsService.SearchCate(cate, 1, 4, out total);
                    lstNews = NewsViewModels.Convert(lst);

                    //Get List Images
                    var lstImages = new List<LinksViewModel>();
                    var data = _linksService.GetImagesOfPost(id);
                    lstImages = LinksViewModel.Convert(data);
                    //Get list Tags
                    var lstTags = new List<TagsViewModel>();
                    lstTags = TagsViewModel.Convert(_tagsService.GetListTag(category.CommonId, "categoryid"));

                    model.ListTags = lstTags;
                    model.ListImage = lstImages;
                    model.TotalNews = total;
                    model.LstNews = lstNews;
                    return View("PostDetail", model);
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

        [Route("ViewPost/{linkthanthien}")]
        public ActionResult ViewPost(string linkthanthien)
        {
            try
            {
                string id = "";
                string[] str = linkthanthien.Split('-');
                id = str[str.Length - 1];
                if (id != null)
                {
                    CategoryViewModel model = new CategoryViewModel();
                    model.DetailNew = GetDetailNews(Int64.Parse(id));
                    model.ListComment = GetComments(Int64.Parse(id));
                    model.TotalComment = _commentService.TotalComments(Int64.Parse(id));

                    var news = new News();
                    news = _newsService.GetById(Int64.Parse(id));
                    var cate = news.CategoryId;
                    var category = _commonCodeService.SearchByCommonIdAndCommonType(cate, "NewsCategory").FirstOrDefault();
                    var category_Parents = category;

                    if (category.NumValue1 == 2)
                    {
                        string CatId_Parents = cate;
                        var a_str = cate.Split('-');
                        CatId_Parents = a_str[0] + "-" + a_str[1];
                        category_Parents = _commonCodeService.SearchByCommonIdAndCommonType(CatId_Parents, "NewsCategory").FirstOrDefault();
                    }
                    model.Category = category;
                    model.Category_Parent = category_Parents;
                    ViewBag.Category = category.StrValue1;
                    ViewBag.CategoryId = category.CommonId;

                    var lstNews = new List<NewsViewModels>();
                    int total = 0;
                    var lst = _newsService.SearchCate(cate, 1, 4, out total);
                    lstNews = NewsViewModels.Convert(lst);

                    //Get list Images
                    var lstImages = new List<LinksViewModel>();
                    var data = _linksService.GetImagesOfPost(id);
                    lstImages = LinksViewModel.Convert(data);

                    //Get list Tags
                    var lstTags = new List<TagsViewModel>();
                    lstTags = TagsViewModel.Convert(_tagsService.GetListTag(category.CommonId, "categoryid"));

                    page_keyword = model.DetailNew.Keyword;
                    page_description = model.DetailNew.Description;

                    model.ListTags = lstTags;
                    model.ListImage = lstImages;
                    model.TotalNews = total;
                    model.LstNews = lstNews;
                    return View("PostDetail", model);
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

        public ActionResult Survey()
        {
            return View();
        }

        public ActionResult DetailSurvey()
        {
            return View();
        }

        public ActionResult Annoucement()
        {
            return View();
        }

        public ActionResult DetailAnnoucement()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DetailGrammar(long idNews)
        {
            try
            {
                DetailNewViewModel detailNewVM = new DetailNewViewModel();
                detailNewVM.DetailNew = GetDetailNews(idNews);
                detailNewVM.ListComment = GetComments(idNews);
                detailNewVM.ListPopularNews = GetPopularNews(detailNewVM.DetailNew.CategoryId);
                detailNewVM.TotalComment = _commentService.TotalComments(idNews);
                return View("DetailGrammar", detailNewVM);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult SearchChildrenComment(long objectLinkId, long parentId, int commentNumber, int commentSize)
        {
            try
            {
                var listResult = CommentsViewModel.Convert(_commentService.SearchChildrenComment(objectLinkId, parentId, "1", commentNumber, commentSize));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult SearchCommentByNewsLimit(long newsId, int commentNumber, int commentSize)
        {
            try
            {
                var listResult = CommentsViewModel.Convert(_commentService.SearchByNewsLimit(newsId, "1", commentNumber, commentSize));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        #endregion

        #region -- Action --

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

        [HttpPost]
        public ActionResult getDataCategoryPage(int page, string commonId)
        {
            var res = Json(new { status = 0, TotalRecord = 0, sErr = "" });
            try
            {
                var lstCategory = new List<CommonCodeViewModel>();
                int total = 0;
                var lst = _commonCodeService.SearchByCommonIdAndCommonTypeWithPagination(commonId, "NewsCategory", page, 4, out total);

                lstCategory = CommonCodeViewModel.Convert(lst);
                res = Json(new { status = 1, TotalRecord = total, sErr = "", data = lstCategory });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, TotalRecord = 0, sErr = ex.Message });
            }
            return res;
        }

        [HttpPost]
        public ActionResult Search(string categoryId, string key, string type, int page, int pageSize)
        {
            try
            {
                var list = _newsService.SearchCategory(categoryId, type, key);
                var list2 = list.OrderByDescending(p => p.Id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                var listResult = NewsViewModels.Convert(list2);
                return Json(new { status = 1, data = listResult, TotalRecord = list.Count });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult SearchCate(string categoryId, string type, string key)
        {
            try
            {
                var listResult = NewsViewModels.Convert(_newsService.SearchCategory(categoryId, type, key));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult GetChildCategory(string commonIdParent)
        {
            try
            {
                var listResult = CommonCodeViewModel.Convert(_commonCodeService.GetCommonChildByCommonParent(commonIdParent));

                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult InsertCommentParent()
        {
            var res = Json(new { status = 0, sErr = "" });
            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<CommentsViewModel>(Request.Params["obj"]);

                var cmt = new Comment();
                cmt.CommentType = "News";
                cmt.ParentId = 0;
                cmt.Status = Constants.Comment_Status.InactiveStatus;
                cmt.CreatedBy = UserFrontVM.CurrentUser.UserId; ;
                cmt.CreatedBy = "admin";
                cmt.CreateDate = DateTime.Now;
                cmt.ObjectLinkID = objTmp.ObjectLinkID;
                cmt.Level = "1";
                cmt.Content = objTmp.Content;

                _commentService.Insert(cmt);
                res = Json(new { status = 1 });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;
        }

        [HttpPost]
        public ActionResult InsertCommentChild()
        {
            var res = Json(new { status = 0, sErr = "" });
            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<CommentsViewModel>(Request.Params["obj"]);

                var cmt = new Comment();
                cmt.CommentType = "News";
                cmt.ParentId = objTmp.ParentId;
                cmt.Status = Constants.Comment_Status.InactiveStatus;
                cmt.CreatedBy = UserFrontVM.CurrentUser.UserId;
                cmt.CreatedBy = "admin";
                cmt.CreateDate = DateTime.Now;
                cmt.ObjectLinkID = objTmp.ObjectLinkID;
                cmt.Level = "2";
                cmt.Content = objTmp.Content;

                _commentService.Insert(cmt);
                res = Json(new { status = 1 });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;
        }

        #endregion

        #region -- Private Function --

        private List<CommentsViewModel> GetComments(long newsId)
        {
            try
            {
                var data = _commentService.SearchByNewsLimit(newsId, "1", 0, 2);
                var listCmt = CommentsViewModel.Convert(data);

                return listCmt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private NewsViewModels GetDetailNews(long newsId)
        {
            try
            {
                var data = _newsService.GetDetailNews(newsId);
                var detailNews = NewsViewModels.Convert(data);

                return detailNews;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<NewsViewModels> GetPopularNews(string categoryId)
        {
            try
            {
                var data = _newsService.GetPopularNews(categoryId);
                var detailNews = NewsViewModels.Convert(data);

                return detailNews;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
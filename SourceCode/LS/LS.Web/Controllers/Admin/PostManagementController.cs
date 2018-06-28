using System;
using System.IO;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web.Hosting;
using System.Collections.Generic;

namespace LS.Web.Controllers.Admin
{
    using BLL;
    using IBLL;
    using Model;
    using Models;
    using Utility;

    public class PostManagementController : BaseController
    {
        #region -- Properties --

        private ICommonCodeService _commonCodeService = new CommonCodeService();
        private INewsService _newsService = new NewsService();
        private ILinksService _linksService = new LinksService();
        private ITagsService _tagsService = new TagsService();
        private ICommentService _commentService = new CommentService();

        #endregion

        #region -- View --

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexAnnouncement()
        {
            return View();
        }

        #endregion

        #region -- Action --

        public ActionResult Create()
        {
            try
            {
                var commonCodeVM = new List<CommonCodeViewModel>();
                commonCodeVM = CommonCodeViewModel.Convert(_commonCodeService.GetListPostType());
                return View(commonCodeVM);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult CreateAnnouncement()
        {
            try
            {
                var model = new CategoryViewModel();
                var lstTag = TagsViewModel.Convert(_tagsService.GetListTag("Announcement-2","categoryid"));

                model.ListTags = lstTag;
                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult AddNews()
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<NewsViewModels>(Request.Params["obj"]);

                var news = new News();
                news.Title = objTmp.Title;
                news.NewsBrief = objTmp.NewsBrief;
                news.NewsDetail = objTmp.NewsDetail;
                news.Keyword = objTmp.Keyword;
                news.Description = objTmp.Description;
                news.Editor = objTmp.Editor;
                news.CategoryId = objTmp.CategoryId;
                news.Status = objTmp.Status;
                news.CreatedBy = UserFrontVM.CurrentUser.UserId;
                news.Time = DateTime.Now;

                _newsService.Insert(news);

                string link = ConvertToUnSign3(news.Title).ToLower();
                link = RemoveSpeacialChar(link);
                link = link.Replace(" ", "-");
                var img = Request.Files[0];
                var fileName = news.Id + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
                var fileExtension = Path.GetExtension(img.FileName);
                string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlImages.ImagesPost; //duong dan
                var physicalPath = path + news.Id.ToString();

                if (!Directory.Exists(physicalPath))
                {
                    Directory.CreateDirectory(physicalPath);
                    img.SaveAs(physicalPath + "/" + fileName + fileExtension);
                }
                else
                {
                    img.SaveAs(physicalPath + "/" + fileName + fileExtension);
                }

                news.Links = link + "-" + news.Id;
                news.Images = fileName + fileExtension;

                _newsService.Update(news);

                res = Json(new { status = 1, id = news.Id, url = UrlImages.ImagesPost + news.Id + "/" + news.Images, linksPost = news.Links });
            }
            catch (Exception e)
            {
                res = Json(new { status = 0, result = e.Message });
            }
            return res;
        }

        public ActionResult Edit(long id)
        {
            CategoryViewModel detailNewVM = new CategoryViewModel();
            try
            {
                var lstTags = new List<TagsViewModel>();
                string categoryId = _newsService.GetDetailNews(id).CategoryId;
                lstTags = TagsViewModel.Convert(_tagsService.GetListTag(categoryId, "categoryid"));

                var data = _commentService.GetAllCommentWithPagination(id, 0, 2);
                var listCmt = CommentsViewModel.Convert(data);

                detailNewVM.ListComment = listCmt;
                detailNewVM.TotalComment = _commentService.TotalCommentsBE(id);

                detailNewVM.ListTags = lstTags;
                detailNewVM.DetailNew = GetDetailNews(id);
                detailNewVM.ListImage = GetImageOfPost(id.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(detailNewVM);
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult Edit()
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<NewsViewModels>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);
                var news = _newsService.GetById(objTmp.Id);
                if (cof == true)
                {
                    var img = Request.Files[0];
                    string path = HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlImages.ImagesPost;

                    if (System.IO.File.Exists(path + "/" + news.Id + "/" + news.Images))
                    {
                        // Xóa file
                        System.IO.File.Delete(path + "/" + news.Id + "/" + news.Images);
                    }

                    var fileName = news.Id + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
                    var fileExtension = Path.GetExtension(img.FileName);
                    var physicalPath = path + news.Id.ToString();
                    if (Directory.Exists(physicalPath))
                    {
                        img.SaveAs(physicalPath + "/" + fileName + fileExtension);
                    }
                    news.Images = fileName + fileExtension;
                }
                if (news.Title != objTmp.Title)
                {
                    news.Title = objTmp.Title;
                    string link = ConvertToUnSign3(news.Title).ToLower();
                    link = RemoveSpeacialChar(link);
                    link = link.Replace(" ", "-");
                    news.Links = link + "-" + (objTmp.Id);
                }
                if (news.NewsBrief != objTmp.NewsBrief)
                {
                    news.NewsBrief = objTmp.NewsBrief;
                }
                if (news.NewsDetail != objTmp.NewsDetail)
                {
                    news.NewsDetail = objTmp.NewsDetail;
                }
                if (news.Editor != objTmp.Editor)
                {
                    news.Editor = objTmp.Editor;
                }
                if (news.Keyword != objTmp.Keyword)
                {
                    news.Keyword = objTmp.Keyword;
                }
                if (news.Description != objTmp.Description)
                {
                    news.Description = objTmp.Description;
                }
                if (news.CategoryId != objTmp.CategoryId)
                {
                    news.CategoryId = objTmp.CategoryId;
                }
                if (news.Status != objTmp.Status)
                {
                    news.Status = objTmp.Status;
                }
                news.ModifiedOn = DateTime.Now;
                news.ModifiedBy = UserFrontVM.CurrentUser.UserId;
                _newsService.Update(news);
                res = Json(new { status = 1, result = "", linksPost = news.Links });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }
            return res;
        }

        public ActionResult EditAnnouncement(long id)
        {
            CategoryViewModel detailNewVM = new CategoryViewModel();
            try
            {
                var lstTags = new List<TagsViewModel>();
                string categoryId = _newsService.GetDetailNews(id).CategoryId;
                lstTags = TagsViewModel.Convert(_tagsService.GetListTag(categoryId, "categoryid"));

                var data = _commentService.GetAllCommentWithPagination(id, 0, 2);
                var listCmt = CommentsViewModel.Convert(data);

                detailNewVM.ListComment = listCmt;
                detailNewVM.TotalComment = _commentService.TotalCommentsBE(id);

                detailNewVM.ListTags = lstTags;
                detailNewVM.DetailNew = GetDetailNews(id);
                detailNewVM.ListImage = GetImageOfPost(id.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(detailNewVM);
        }

        [HttpPost]
        public ActionResult DeletePost()
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<List<string>>(Request.Params["obj"]);

                var news = new News();
                _newsService.DeleteListNews(objTmp);
                res = Json(new { status = 1, result = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }
            return res;
        }

        [HttpPost]
        public ActionResult AddTag()
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<TagsViewModel>(Request.Params["obj"]);
                var tag = new Tag();
                tag.TagName = objTmp.TagName;
                tag.TagId = objTmp.TagId;
                tag.Type = "categoryid";

                _tagsService.Insert(tag);
                res = Json(new { status = 1, data = tag });
            }
            catch (Exception ex)
            {
                return res = Json(new { status = 0, result = ex.Message });
            }

            return res;
        }

        [HttpPost]
        public ActionResult DeleteTag(long id)
        {
            var res = Json(new { status = 0, sErr = "" });
            try
            {
                var tag = new Tag();
                tag = _tagsService.GetById(id);
                _tagsService.Delete(tag);

                res = Json(new { status = 1, result = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }
            return res;
        }

        [HttpPost]
        public ActionResult DeleteCmtChild(long id)
        {
            var res = Json(new { status = 0, sErr = "" });
            try
            {
                var cmt = new Comment();
                cmt = _commentService.GetById(id);
                _commentService.Delete(cmt);

                res = Json(new { status = 1, result = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }
            return res;
        }

        [HttpPost]
        public ActionResult DeleteLinkImage(long id)
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var n = new Link();
                n = _linksService.GetById(id);
                _linksService.Delete(n);
                string path = HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlImages.ImagesPost;
                string fileName = n.FileName;
                string fileExtension = n.FileExtension;
                string phy = path + id + "/" + fileName + fileExtension;
                if (System.IO.File.Exists(phy))
                {
                    // Xóa file
                    System.IO.File.Delete(phy);
                }

                res = Json(new { status = 1, result = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }

            return res;
        }

        [HttpPost]
        public ActionResult GetCategory(string type)
        {
            try
            {
                var listResult = CommonCodeViewModel.Convert(_commonCodeService.GetCategoryId(type));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult GetCategoryChild(string commonId)
        {
            try
            {
                var listResult = CommonCodeViewModel.Convert(_commonCodeService.GetCategoryIdChild(commonId));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult UpdateImage()
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var js = new JavaScriptSerializer();
                var img = Request.Files[0];
                string id = "";
                if (Request.Params["idPost"] != null)
                {
                    id = js.Deserialize<string>(Request.Params["idPost"]);
                }

                var physicalPath = "";
                var fileName = "";
                var fileExtension = "";
                if (img != null)
                {
                    fileName = id + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
                    fileExtension = Path.GetExtension(img.FileName);
                    string path = HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlImages.ImagesPost;
                    physicalPath = path + id + "/" + fileName + fileExtension;
                    img.SaveAs(physicalPath);
                }

                var link = new Link();
                link.ObjectId = id;
                link.URL = UrlImages.ImagesPost + id + "/" + fileName + fileExtension;
                link.Type = "NewsImage";
                link.FileExtension = fileExtension;
                link.FileName = fileName;
                link.Status = Constants.News_Status.ActiveStatus;
                //news.CreatedBy = userService.SearchFor(x => x.UserID == Current_UserId).FirstOrDefault().ObjectID;
                link.CreatedOn = DateTime.Now;

                _linksService.Insert(link);
                int count = _linksService.LimitMaxImage(id);

                res = Json(new { status = 1, linkImage = link.FileName + link.FileExtension, id = link.Id, countImage = count });
            }
            catch (Exception e)
            {
                return res = Json(new { status = 0, result = e.Message });
            }
            return res;
        }

        [HttpPost]
        public ActionResult Search(string keyWord, DateTime? ftt, DateTime? ttt, int page, int pageSize)
        {
            try
            {
                var list = _newsService.GetListPost(keyWord, ftt, ttt);
                var list2 = list.OrderByDescending(p => p.Time).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                var listResult = NewsViewModels.Convert(list2);
                return Json(new { status = 1, data = listResult, TotalRecord = list.Count });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult SearchAnnouncement(string keyWord, DateTime? ftt, DateTime? ttt, int page, int pageSize)
        {
            try
            {
                int count = 0;
                var list = _newsService.GetListAnnouncement(keyWord, ftt, ttt, page, pageSize, out count);
                var list2 = list.ToList();
                var listResult = NewsViewModels.Convert(list2);
                return Json(new { status = 1, data = listResult, TotalRecord = count });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult GetAllCommentWithPagination(long newsId, int commentNumber, int commentSize)
        {
            try
            {
                var listResult = CommentsViewModel.Convert(_commentService.GetAllCommentWithPagination(newsId, commentNumber, commentSize));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult GetAllChildrenComment(long objectLinkId, long parentId, int commentNumber, int commentSize)
        {
            try
            {
                var listResult = CommentsViewModel.Convert(_commentService.GetAllChildrenComment(objectLinkId, parentId, commentNumber, commentSize));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult ClickCbCmt(string status, long id)
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var cmt = new Comment();
                cmt = _commentService.GetById((id));
                cmt.Status = status;
                cmt.ApprovedBy = UserFrontVM.CurrentUser.UserId;
                cmt.ApprovedDate = DateTime.Now;

                _commentService.Update(cmt);
                res = Json(new { status = 1 });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        #endregion

        #region -- Private function --

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

        private List<LinksViewModel> GetImageOfPost(string objectId)
        {
            try
            {
                var data = _linksService.GetImagesOfPost(objectId);
                var listImage = LinksViewModel.Convert(data);

                return listImage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ConvertToUnSign3(string s)
        {
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);

            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private string RemoveSpeacialChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] < 65 && s[i] != 32) || ((s[i] > 90 && s[i] < 97) && s[i] != 32) || (s[i] > 122 && s[i] != 32))
                {
                    s = s.Replace(s[i].ToString(), "");
                }
            }
            return s;
        }

        #endregion
    }
}
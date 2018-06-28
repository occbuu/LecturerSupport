using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LS.Web.Controllers.Admin
{
    using BLL;
    using IBLL;
    using Models;

    public class CommentController : Controller
    {
        // GET: Comment
        #region -- Properties --

        private ICommentService _commentService = new CommentService();

        #endregion

        #region -- View --

        public ActionResult Index()
        {
            var list = CommentsViewModel.Convert(_commentService.GetAll());
            var listResult = list.Select(x => x.CommentType).Distinct().ToList();
            return View(listResult);
        }

        #endregion

        #region -- Action --
        [HttpPost]
        public ActionResult GetAllCmt(int commentNumber, int commentSize)
        {
            try
            {
                var list = CommentsViewModel.Convert(_commentService.GetAll());
                var listResult = list.OrderByDescending(x => x.Id).Skip((commentNumber - 1) * commentSize).Take(commentSize).ToList();
                return Json(new { success = true, data = listResult, listAllCmt = list });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult EditStatus(int id)
        {
            try
            {

                var cmt = _commentService.SearchFor(e => e.Id == id).FirstOrDefault();
                if (cmt.Status == "1")
                {
                    cmt.Status = "0";
                }
                else
                {
                    cmt.Status = "1";
                }

                _commentService.Update(cmt);

                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult DeleteCmt()
        {
            try
            {

                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<List<string>>(Request.Params["obj"]);
                _commentService.DeleteListComment(objTmp);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult Search(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, int recordCount)
        {
            try
            {

                var list = _commentService.SearchComment(keyWord, status, type, ftt, ttt, pageNumber, pageSize, out recordCount);
                var listCmt = CommentsViewModel.Convert(list);
                return Json(new { success = true, data = listCmt, TotalRecord = recordCount });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region -- Private Funtion --

        #endregion
    }
}
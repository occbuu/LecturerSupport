using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Model;
    using Models;

    /// <summary>
    /// Library controller
    /// </summary>
    public class LibraryController : Controller
    {
        #region -- properties --

        private ILibraryService _libraryService = new LibraryService();
        private IUsersService _userService = new UsersService();
        private ICommentService _commentService = new CommentService();
        private ICommonCodeService _commonCodeService = new CommonCodeService();
        private ILinksService _linksService = new LinksService();

        public static string page_keyword { get; set; }

        public static string page_description { get; set; }

        #endregion

        #region -- View --
        public ActionResult Index(string type, string id)
        {
            try
            {
                if (type != null)
                {
                    var typeLib = _commonCodeService.SearchByCommonIdAndCommonType(type, "Library").FirstOrDefault();
                    var type_Parent = typeLib;

                    if (typeLib.NumValue1 == 2)
                    {
                        string TypeId_Parents = type;
                        var a_str = type.Split('-');
                        TypeId_Parents = a_str[0] + "-" + a_str[1];
                        type_Parent = _commonCodeService.SearchByCommonIdAndCommonType(TypeId_Parents, "Library").FirstOrDefault();
                    }
                    if (typeLib != null)
                    {
                        var model = new TypeViewModel();
                        var lstLib = new List<LibraryViewModels>();
                        var lstTypeLib = new List<CommonCodeViewModel>();
                        int total = 0;
                        int total1 = 0;
                        var lst = _libraryService.SearchCate(type, 1, 5, out total);
                        var listType = _commonCodeService.SearchByCommonIdAndCommonTypeWithPagination(type, "Library", 1, 5, out total1);

                        lstLib = LibraryViewModels.Convert(lst);
                        lstTypeLib = CommonCodeViewModel.Convert(listType);
                        model.lstLib = lstLib;
                        model.TotalLib = total;
                        model.lstType = lstTypeLib;
                        model.TotalType = total1;
                        model.Type = typeLib;
                        model.Type_Parent = type_Parent;

                        ViewBag.Type = typeLib.StrValue1;
                        ViewBag.TypeId = typeLib.CommonId;
                        return View("Index", model);
                    }
                    else
                    {
                        return PartialView("_404");
                    }
                }
                else if (id != null)
                {
                    TypeViewModel model = new TypeViewModel();
                    model.DetailLib = GetDetailLib(Int64.Parse(id));
                    var typeLib = _commonCodeService.SearchByCommonIdAndCommonType(type, "Library").FirstOrDefault();
                    var type_Parent = typeLib;

                    if (typeLib.NumValue1 == 2)
                    {
                        string TypeId_Parents = type;
                        var a_str = type.Split('-');
                        TypeId_Parents = a_str[0] + "-" + a_str[1];
                        type_Parent = _commonCodeService.SearchByCommonIdAndCommonType(TypeId_Parents, "Library").FirstOrDefault();
                    }
                    model.Type = typeLib;
                    model.Type_Parent = type_Parent;
                    ViewBag.Type = typeLib.StrValue1;
                    ViewBag.TypeId = typeLib.CommonId;

                    var lstLib = new List<LibraryViewModels>();
                    int total = 0;
                    var lst = _libraryService.SearchCate(type, 1, 5, out total);
                    lstLib = LibraryViewModels.Convert(lst);

                    model.TotalLib = total;
                    model.lstLib = lstLib;
                    return View("_DetailLibrary", model);
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

        [Route("ViewLib/{linkthanthien}")]
        public ActionResult ViewLib(string linkthanthien)
        {
            try
            {
                string id = "";
                string[] str = linkthanthien.Split('-');
                id = str[str.Length - 1];
                if (id != null)
                {
                    TypeViewModel model = new TypeViewModel();
                    model.DetailLib = GetDetailLib(Int64.Parse(id));

                    var lib = new Library();
                    lib = _libraryService.GetById(Int64.Parse(id));
                    var type = lib.Type;
                    var typeLib = _commonCodeService.SearchByCommonIdAndCommonType(type, "Library").FirstOrDefault();
                    var type_Parent = typeLib;
                    if (typeLib.NumValue1 == 2)
                    {
                        string TypeId_Parents = type;
                        var a_str = type.Split('-');
                        TypeId_Parents = a_str[0] + "-" + a_str[1];
                        type_Parent = _commonCodeService.SearchByCommonIdAndCommonType(TypeId_Parents, "Library").FirstOrDefault();
                    }
                    model.Type = typeLib;
                    model.Type_Parent = type_Parent;
                    ViewBag.Type = typeLib.StrValue1;
                    ViewBag.TypeId = typeLib.CommonId;

                    var lstLib = new List<LibraryViewModels>();
                    int total = 0;
                    var lst = _libraryService.SearchCate(type, 1, 5, out total);
                    lstLib = LibraryViewModels.Convert(lst);

                    model.TotalLib = total;
                    model.lstLib = lstLib;
                    return View("_DetailLibrary", model);
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

        #endregion

        #region -- Action --

        [HttpPost]
        public ActionResult getDataLibPage(int page, string type)
        {
            var res = Json(new { status = 0, TotalRecord = 0, sErr = "" });
            try
            {
                var lstLib = new List<LibraryViewModels>();
                int total = 0;
                var lst = _libraryService.SearchCate(type, page, 5, out total);

                lstLib = LibraryViewModels.Convert(lst);
                res = Json(new { status = 1, TotalRecord = total, sErr = "", data = lstLib });
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
                var lst = _commonCodeService.SearchByCommonIdAndCommonTypeWithPagination(commonId, "Library", page, 4, out total);

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
        public ActionResult GetFiles(long id)
        {
            try
            {
                var listFile = GetFile(id.ToString());
                return Json(new { success = true, data = listFile });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(new { success = false });
        }
        #endregion

        #region -- Private Function --

        private LibraryViewModels GetDetailLib(long libId)
        {
            try
            {
                var data = _libraryService.GetDetailLib(libId);
                var detailLib = LibraryViewModels.Convert(data);

                return detailLib;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<LinksViewModel> GetFile(string objectId)
        {
            try
            {
                var data = _linksService.GetFiles(objectId);
                var listFiles = LinksViewModel.Convert(data);

                return listFiles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
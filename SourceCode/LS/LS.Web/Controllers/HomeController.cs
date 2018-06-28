using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using W = System.Web;

namespace LS.Web.Controllers
{
    using BLL;
    using Common;
    using IBLL;
    using Models;
    using Utility;
    /// <summary>
    /// Home controller
    /// </summary>
    public class HomeController : BaseController
    {
        public static string site_keyword { get; set; }
        public static string site_description { get; set; }

        public HomeController()
        {
            site_keyword = "ABC site_keyword";
            site_description = "ABC site_description";
        }

        public ActionResult Index()
        {
            ISiteInfoService infoService = new SiteInfoService();
            ITeacherMemoryService teacherMemoryService = new TeacherMemoryService();
            ITeacherDelegateStudentService teacherDelegateStudentService = new TeacherDelegateStudentService();

            var homeVM = new HomeViewModels();
            homeVM.ContentVM = new List<ContentVM>();
            homeVM.CommentVM = new List<CommentVM>();
            homeVM.DashBoardVM = new List<DashBoardVM>();
            homeVM.TeacherMemoryVM = new List<TeacherMemoryViewModel>();
            homeVM.TeacherDelegateStudentVM = new List<TeacherDelegateStudentViewModel>();

            var lstContent = infoService.SeachByType(Constants.Home.Content);
            var lstComment = infoService.SeachByType(Constants.Home.Comment);
            var lstGallery = TeacherMemoryViewModel.Convert(teacherMemoryService.SearchByType("MyClass"));
            var lstDashBoard = infoService.SeachByType(Constants.Home.DashBoard);
            var lstDelegateStudent = TeacherDelegateStudentViewModel.Convert(teacherDelegateStudentService.GetAll());

            foreach (var result in lstContent)
            {
                if (result.ParentId == null)
                {
                    var content = new ContentVM();
                    var lstParentIdContent = infoService.SeachByParentId(result.Name);
                    content.contentDetailsVM = ContentDetailsVM.Convert(lstParentIdContent);
                    content.Name = result.Name;
                    content.Value = result.Value;
                    content.ParentId = result.ParentId;
                    homeVM.ContentVM.Add(content);
                }
            }

            foreach (var result in lstComment)
            {
                if (result.Name == Constants.Home.Comment)
                {
                    var comment = new CommentVM();
                    var lstParentIdComment = infoService.SeachByParentId(result.brief);
                    comment.commentDetailVM = CommentDetailVM.Convert(lstParentIdComment);
                    comment.Name = result.Name;
                    comment.Value = result.Value;
                    comment.Brief = result.brief;
                    homeVM.CommentVM.Add(comment);
                }
            }

            foreach (var result in lstGallery)
            {
                homeVM.TeacherMemoryVM.Add(result);
            }

            foreach (var result in lstDashBoard)
            {
                if (result.ParentId == null)
                {
                    var dashBoard = new DashBoardVM();
                    var lstParentIdDashBoard = infoService.SeachByParentId(result.Name);
                    dashBoard.dashBoardDetailsVM = DashBoardDetailsVM.Convert(lstParentIdDashBoard);
                    dashBoard.Name = result.Name;
                    dashBoard.Value = result.Value;
                    dashBoard.ParentId = result.ParentId;
                    homeVM.DashBoardVM.Add(dashBoard);
                }
            }

            foreach (var result in lstDelegateStudent)
            {
                homeVM.TeacherDelegateStudentVM.Add(result);
            }
            return View(homeVM);
        }

        public ActionResult Policy()
        {
            return View();
        }

        public ActionResult TermAndCondition()
        {
            return View();
        }

        #region -- Login logout --

        [HttpPost]
        public JsonResult Login(string model)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var renUser = serializer.Deserialize<UserFrontVM>(model);

            Authentication(renUser);

            return Json(new { success = UserFrontVM.CurrentUser != null, redirect = Url.Action("Index", "Home") });
        }

        private void Authentication(UserFrontVM vm)
        {
            //if (vm.UserId == null || vm.Pwd == null)
            //{
            //    var renUser = serializer.Deserialize<UserFrontViewModel>(model);
            //}

            //if (renUser.UserId==null || renUser.Pwd==null)
            //{
            //    return;
            //}
            IUsersService usersService = new UsersService();
            var hasPWD = Encryption.GetMd5Hash(vm.Pwd);
            var m = usersService.SearchUserFront(vm.UserId, hasPWD);

            if (m == null)
            {
                return;
            }

            UserFrontVM.CurrentUser = new UserFrontVM(m);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            UserFrontVM.CurrentUser = new UserFrontVM();
            return Json(new { status = true });
        }

        #endregion

        #region -- Helper --

        public JsonResult SetLanguage(string culture)
        {
            var res = Json(new { status = 0, curLang = "", sErr = "" });
            try
            {
                var currentCulture = CultureInfo.CreateSpecificCulture(culture);
                Resources.Resources.Culture = currentCulture;
                Resources.About.ResourcesAbout.Culture = currentCulture;
                Resources.Library.ResourcesLibrary.Culture = currentCulture;
                Resources.Posts.ResourcesPosts.Culture = currentCulture;
                Resources.Users.ResourcesUsers.Culture = currentCulture;
                res = Json(new { status = 1, curLang = culture, sErr = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, curLang = "", sErr = ex.Message });
            }
            return res;
        }

        #endregion
    }
}
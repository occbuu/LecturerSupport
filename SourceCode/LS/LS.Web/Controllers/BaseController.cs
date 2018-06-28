using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using W = System.Web;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Models;
    using Utility;
    using W.Routing;

    public class BaseController : Controller
    {

        #region -- Properties --

        IUsersService _userService = new UsersService();

        /// <summary>
        /// Current host
        /// </summary>
        public static string CurrentHost
        {
            get
            {
                var res = string.Format(StringFormat.Host,
                    W.HttpContext.Current.Request.Url.Scheme,
                    W.HttpContext.Current.Request.Url.Authority);
                return res + SpecialString.Slash;
            }
        }

        public BaseController()
        {
            initData();
        }

        private void initData()
        {
            CheckPermission();
            ISiteInfoService infoService = new SiteInfoService();
            ICommonCodeService commonCodeService = new CommonCodeService();
            var homeVM = new HomeViewModels();
            homeVM.CommonCodeVM = new List<CommonCodeVM>();
            homeVM.TopBarVM = new List<TopBarVM>();
            homeVM.FooterVM = new List<FooterVM>();
            homeVM.SocialNetworkVM = new List<SocialNetworkVM>();
            var lstCommonCode = commonCodeService.GetAll();
            var lstTopBar = infoService.SeachByType(Constants.InfoType.TopBar);
            var lstSocialNetwork = infoService.SeachByType(Constants.InfoType.SocialNetwork);
            var lstFooter = infoService.SeachByType(Constants.InfoType.Footer);

            //W.HttpContext.Current.Session[Constants.InfoType.Header] = lstHeader;

            foreach (var result in lstCommonCode)
            {
                var commonCode = new CommonCodeVM();
                var count = result.NumValue1;
                if (result.CommonTypeId == Constants.InfoType.Introduction)
                {
                    if (count == 1)
                    {
                        var commonIdDetails = lstCommonCode.Where(p => p.NumValue1 == 2 && p.CommonId.Contains(result.CommonId)).ToList();
                        commonCode.CommonTypeId = result.CommonTypeId;
                        commonCode.CommonId = result.CommonId;
                        commonCode.Value1 = result.StrValue1;
                        commonCode.Value2 = result.StrValue2;
                        commonCode.Value3 = result.StrValue3;
                        commonCode.Qty = result.Qty;
                        homeVM.CommonCodeVM.Add(commonCode);
                    }
                }
                else if (result.CommonId.Contains(Constants.InfoType.Announcement))
                {
                    if (count == 1)
                    {
                        var commonIdDetails = lstCommonCode.Where(p => p.NumValue1 == 2 && p.CommonId.Contains(result.CommonId)).ToList();
                        commonCode.commonCodeDetailsVM = CommonCodeDetailsVM.Convert(commonIdDetails);
                        commonCode.CommonTypeId = result.CommonTypeId;
                        commonCode.CommonId = result.CommonId;
                        commonCode.Value1 = result.StrValue1;
                        commonCode.Value2 = result.StrValue2;
                        commonCode.Value3 = result.StrValue3;
                        commonCode.Qty = result.Qty;
                        homeVM.CommonCodeVM.Add(commonCode);
                    }
                }
                else if (result.CommonId.Contains(Constants.InfoType.English))
                {
                    if (count == 1)
                    {
                        var commonIdDetails = lstCommonCode.Where(p => p.NumValue1 == 2 && p.CommonId.Contains(result.CommonId)).ToList();
                        commonCode.commonCodeDetailsVM = CommonCodeDetailsVM.Convert(commonIdDetails);
                        commonCode.CommonTypeId = result.CommonTypeId;
                        commonCode.CommonId = result.CommonId;
                        commonCode.Value1 = result.StrValue1;
                        commonCode.Value2 = result.StrValue2;
                        commonCode.Value3 = result.StrValue3;
                        commonCode.Qty = result.Qty;
                        homeVM.CommonCodeVM.Add(commonCode);
                    }
                }
                else if (result.CommonId.Contains(Constants.InfoType.JapaneseStudies))
                {
                    if (count == 1)
                    {
                        var commonIdDetails = lstCommonCode.Where(p => p.NumValue1 == 2 && p.CommonId.Contains(result.CommonId)).ToList();
                        commonCode.commonCodeDetailsVM = CommonCodeDetailsVM.Convert(commonIdDetails);
                        commonCode.CommonTypeId = result.CommonTypeId;
                        commonCode.CommonId = result.CommonId;
                        commonCode.Value1 = result.StrValue1;
                        commonCode.Value2 = result.StrValue2;
                        commonCode.Qty = result.Qty;
                        homeVM.CommonCodeVM.Add(commonCode);
                    }
                }
            }
            W.HttpContext.Current.Session[Constants.InfoType.Header] = homeVM.CommonCodeVM;

            foreach (var result in lstTopBar)
            {
                var topBar = new TopBarVM();
                topBar.Name = result.Name;
                topBar.Value = result.Value;
                topBar.ParentId = result.ParentId;
                homeVM.TopBarVM.Add(topBar);
            }
            W.HttpContext.Current.Session[Constants.InfoType.TopBar] = homeVM.TopBarVM;

            foreach (var result in lstSocialNetwork)
            {
                var socialNetwork = new SocialNetworkVM();
                socialNetwork.Name = result.Name;
                socialNetwork.Value = result.Value;
                socialNetwork.ParentId = result.ParentId;
                homeVM.SocialNetworkVM.Add(socialNetwork);
            }
            W.HttpContext.Current.Session[Constants.InfoType.SocialNetwork] = homeVM.SocialNetworkVM;

            foreach (var result in lstFooter)
            {
                if (result.ParentId == null)
                {
                    var footer = new FooterVM();
                    var footerDetails = infoService.SeachByParentId(result.Name);
                    footer.footerDetailsVM = FooterDetailsVM.Convert(footerDetails);
                    footer.Name = result.Name;
                    footer.Value = result.Value;
                    footer.ParentId = result.ParentId;
                    homeVM.FooterVM.Add(footer);
                }
            }
            W.HttpContext.Current.Session[Constants.InfoType.Footer] = homeVM.FooterVM;
        }

        private void CheckPermission()
        {
            var context = new RequestContext(new W.HttpContextWrapper(System.Web.HttpContext.Current), new RouteData());
            var urlHelper = new UrlHelper(context);

            var controllerContext = W.HttpContext.Current.Request.RequestContext;
            if (controllerContext != null)
            {
                var tmp = controllerContext.RouteData.Values;
                var action = tmp["action"].ToString();
                var controller = tmp["controller"].ToString();
                var functionCode = ParseToFuction(action, controller);
                if (UserFrontVM.CurrentUser == null)
                {
                    UserFrontVM.CurrentUser = new UserFrontVM();
                }
                if (string.IsNullOrEmpty(UserFrontVM.CurrentUser.UserId) && !string.IsNullOrEmpty(functionCode))
                {
                    var redirect = urlHelper.Action("Index", "Home");
                    System.Web.HttpContext.Current.Response.Redirect(redirect);
                    return;
                }

                var isAccessRight = string.IsNullOrEmpty(UserFrontVM.CurrentUser.UserId)
                    ? true
                    : string.IsNullOrEmpty(functionCode) || UserFrontVM.CurrentUser.Permission.Contains(functionCode);

                if (!isAccessRight)
                {
                    var redirect = urlHelper.Action("Index", "Home");
                    System.Web.HttpContext.Current.Response.Redirect(redirect);
                }
            }
        }

        private string ParseToFuction(string action, string controller)
        {
            var str = string.Empty;
            switch (controller)
            {
                case "Dashboard":
                    if (action == "Index")
                    {
                        str = "BE01";
                    }
                    break;
                case "Class":
                    if (action == "ManageInfoClass")
                    {
                        str = "BE0301";
                    }
                    else if (action == "Index")
                    {
                        str = "BE0302";
                    }
                    else if (action == "Conspectus")
                    {
                        str = "BE0303";
                    }
                    else if (action == "LessonsAndReference")
                    {
                        str = "BE0304";
                    }
                    else if (action == "ExerciseAndAssignment")
                    {
                        str = "BE0305";
                    }
                    else if (action == "ClassListAndPoint")
                    {
                        str = "BE0306";
                    }
                    else if (action == "CheckAttendanceAndEnterPoints")
                    {
                        str = "BE0307";
                    }
                    else if (action == "Discuss")
                    {
                        str = "BE0308";
                    }
                    else if (action == "Notification")
                    {
                        str = "BE0309";
                    }
                    else if (action == "Notification")
                    {
                        str = "BE0306";
                    }
                    break;
                case "PostManagement":
                    if (action == "Create")
                    {
                        str = "BE0501";
                    }
                    else if (action == "Index")
                    {
                        str = "BE0502";
                    }
                    break;
                case "News":
                    if (action == "Create")
                    {
                        str = "BE0601";
                    }
                    else if (action == "Edit")
                    {
                        str = "BE0602";
                    }
                    break;
                case "LibraryBE":
                    if (action == "Create")
                    {
                        str = "BE0701";
                    }
                    else if (action == "Search")
                    {
                        str = "BE0702";
                    }
                    break;
                case "SubjectManagement":
                    if (action == "Create")
                    {
                        str = "BE0901";
                    }
                    else if (action == "SearchAndEdit")
                    {
                        str = "BE0902";
                    }
                    break;
                case "Setting":
                    if (action == "PostType")
                    {
                        str = "BE1002";
                    }
                    else if (action == "Index")
                    {
                        str = "BE1001";
                    }
                    break;

            }
            return str;
        }
        #endregion
    }
}
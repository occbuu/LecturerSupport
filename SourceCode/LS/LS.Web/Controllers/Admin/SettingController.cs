using System;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace LS.Web.Controllers.Admin
{
    using BLL;
    using IBLL;
    using Model;
    using Models;
    using Utility;
    public class SettingController : BaseController
    {
        private ISiteInfoService _siteInfoService = new SiteInfoService();
        private HomeViewModels _homeVM = new HomeViewModels();
        private ICommonCodeService _commonCodeService = new CommonCodeService();
        private ICommonTypeService _commonTypeService = new CommonTypeService();

        // GET: Setting
        #region -- View --
        public ActionResult PostType()
        {
            try
            {
                var listResult = CommonCodeViewModel.Convert(_commonCodeService.SearchParentCommonIdByCommonTypeId(Constants.InfoType.NewsCategory, 0));
                return View(listResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Index()
        {
            try
            {
                var listResult = CommonCodeVM.Convert(_commonCodeService.GetCommonTypeId());
                return View(listResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region -- Create --
        public ActionResult Create()
        {
            return View();
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
        public ActionResult CreateSiteInfo(SiteInfo siteInfo)
        {
            try
            {
                SiteInfo newSiteInfo = new SiteInfo();
                newSiteInfo.Id = siteInfo.Id;
                newSiteInfo.lang = Constants.InfoType.LEnglish;
                newSiteInfo.brief = siteInfo.brief;
                newSiteInfo.type = siteInfo.type;
                newSiteInfo.Name = siteInfo.Name;
                newSiteInfo.Value = siteInfo.Value;
                newSiteInfo.Status = Constants.SiteInfo_Status.ActiveStatus;
                newSiteInfo.CanDelete = true;
                newSiteInfo.qty = 1;
                newSiteInfo.CreatedBy = "Van";
                newSiteInfo.CreatedOn = DateTime.Now;

                _siteInfoService.Insert(newSiteInfo);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult AddType(CommonCode commonCode)
        {
            try
            {
                CommonCode newCommonCode = new CommonCode();
                newCommonCode.CommonTypeId = commonCode.CommonTypeId;
                newCommonCode.CommonId = commonCode.CommonId;
                newCommonCode.StrValue1 = commonCode.StrValue1;
                newCommonCode.NumValue1 = commonCode.NumValue1;
                newCommonCode.CanDelete = true;
                newCommonCode.CreatedBy = commonCode.CreatedBy;
                newCommonCode.CreatedDate = DateTime.Now;
                _commonCodeService.Insert(newCommonCode);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }
        #endregion

        #region -- Edit --
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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
        #endregion

        #region -- Delete --
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
        public ActionResult DeleteSiteInfo(SiteInfo siteInfo)
        {
            try
            {
                var deleteSiteInfo = _siteInfoService.GetById(siteInfo.Id);
                _siteInfoService.Delete(deleteSiteInfo);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }
        #endregion

        #region -- Helper --

        [HttpPost]
        public ActionResult ChangeSiteInfo(string item)
        {
            try
            {
                var listAllResult = SiteInfoViewModel.Convert(_siteInfoService.GetAll());
                var listSetting = _commonCodeService.SearchByStrValue(item);
                var listSiteInfoResult = SiteInfoViewModel.Convert(_siteInfoService.SeachByType(listSetting[0].CommonId));

                return Json(new { success = true, typeCommonCode = listSetting, allResult = listAllResult, lstSiteInfo = listSiteInfoResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult UpdateSiteInfo(SiteInfo siteInfo)
        {
            try
            {
                var idSiteInfo = _siteInfoService.GetById(siteInfo.Id);
                idSiteInfo.Name = siteInfo.Name;
                idSiteInfo.Value = siteInfo.Value;
                idSiteInfo.brief = siteInfo.brief;
                idSiteInfo.type = siteInfo.type;
                idSiteInfo.CanDelete = siteInfo.CanDelete;
                idSiteInfo.Status = siteInfo.Status;
                _siteInfoService.Update(idSiteInfo);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult LoadType(int page, int pageSize, decimal level, string commonId)
        {
            try
            {
                var listAllCommonCode = _commonCodeService.GetAll();
                var listLevel = _commonCodeService.SearchParentCommonIdByCommonTypeId(Constants.InfoType.NewsCategory, level);
                var listDetails = new List<CommonCode>();
                var listCommonCode = new List<CommonCodeViewModel>();
                if ( level != 1)
                {
                    foreach(var item in listLevel)
                    {
                        if(item.CommonId.Contains(commonId))
                        {
                            listDetails.Add(item);
                        }
                    }
                    
                    listCommonCode = CommonCodeViewModel.Convert(listDetails.OrderByDescending(p => p.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList());
                }
                else
                {
                    listCommonCode = CommonCodeViewModel.Convert(listLevel.OrderByDescending(p => p.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList());
                }
                
                return Json(new { status = 1, data = listCommonCode, allCommonCode= listAllCommonCode, listCommonCodeLevel = listLevel, lstCommonCodeDetails= listDetails });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }
        #endregion
    }
}
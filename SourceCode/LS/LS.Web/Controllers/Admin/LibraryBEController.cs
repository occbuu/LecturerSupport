using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LS.Web.Controllers.Admin
{

    using BLL;
    using IBLL;
    using Model;
    using Models;
    using Utility;

    public class LibraryBEController : BaseController
    {
        private ICommonCodeService _commonCodeService = new CommonCodeService();
        private ILibraryService _libraryService = new LibraryService();
        private ILinksService _linksService = new LinksService();

        #region -- View --

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var homeVM = new HomeViewModels();
            homeVM.CommonCodeVM = new List<CommonCodeVM>();

            try
            {
                var lstCommonCode = _commonCodeService.GetAll();
                foreach (var result in lstCommonCode)
                {
                    var count = result.CommonId.Count(p => p == '-');
                    var commonId = result.CommonId + "-";
                    //var commonIdDetails = lstCommonCode.Where(p => p.CommonId.Contains(commonId) && (p.CommonId.Count(t => t == '-') == 2)).ToList();
                    if (result.CommonId.Contains(Constants.InfoType.Announcement))
                    {
                        if (count == 1)
                        {
                            var commonCodeVM = new CommonCodeVM();
                            var commonIdDetails = lstCommonCode.Where(p => p.NumValue1 == 2 && p.CommonId.Contains(result.CommonId)).ToList();
                            commonCodeVM.commonCodeDetailsVM = CommonCodeDetailsVM.Convert(commonIdDetails);
                            commonCodeVM.CommonTypeId = result.CommonTypeId;
                            commonCodeVM.CommonId = result.CommonId;
                            commonCodeVM.Value1 = result.StrValue1;
                            commonCodeVM.Value2 = result.StrValue2;
                            commonCodeVM.Qty = result.Qty;
                            homeVM.CommonCodeVM.Add(commonCodeVM);
                        }
                    }
                }

                if (lstCommonCode != null)
                {
                    return View(homeVM);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult showLibId()
        {
            try
            {
                var listVM = LibraryViewModels.Convert(_libraryService.GetAll());
                //var listLink = ?
                return Json(new { success = true, listLib = listVM });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        #endregion

        #region -- Create --


        [HttpPost]
        public ActionResult Create(string type)
        {
            try
            {
                var listResult = CommonCodeViewModel.Convert(_commonCodeService.GetCategoryIdChild(type));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult AddLibrary()
        {
            var res = Json(new { status = 0, sErr = "" });
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<LibraryViewModels>(Request.Params["obj"]);
                var lib = new Library();
                lib.Title = objTmp.Title;
                lib.Brief = objTmp.Brief;
                lib.CreatedBy = objTmp.CreatedBy;
                lib.Type = objTmp.Type;
                lib.Description = objTmp.Description;
                lib.Status = objTmp.Status;
                lib.CreatedBy = UserFrontVM.CurrentUser.UserId;
                //news.CreatedBy = userService.SearchFor(x => x.UserID == Current_UserId).FirstOrDefault().ObjectID;
                lib.CreatedDate = DateTime.Now;

                _libraryService.Insert(lib);

                string link = ConvertToUnSign3(lib.Title).ToLower();
                link = RemoveSpeacialChar(link);
                link = link.Replace(" ", "-");
                var img = Request.Files[0];
                var fileName = lib.Id + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
                var fileExtension = Path.GetExtension(img.FileName);
                string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlFiles.Library; //duong dan
                var physicalPath = path + lib.Id.ToString();

                if (!Directory.Exists(physicalPath))
                {
                    Directory.CreateDirectory(physicalPath);
                    img.SaveAs(physicalPath + "/" + fileName + fileExtension);
                }

                lib.Links = link + "-" + lib.Id;
                lib.Images = fileName + fileExtension;

                _libraryService.Update(lib);

                res = Json(new { status = 1, id = lib.Id });
            }
            catch (Exception e)
            {
                res = Json(new { status = 0, result = e.Message });
            }
            return res;
        }

        #endregion

        #region -- Edit --
        public ActionResult EditLib(long id)
        {
            DetailLibViewModel detailLibVM = new DetailLibViewModel();
            try
            {
                detailLibVM.DetailLib = GetDetailLib(id);
                detailLibVM.ListFile = GetFile(id.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(detailLibVM);
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

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult EditLib()
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<LibraryViewModels>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);
                var lib = _libraryService.GetById(objTmp.Id);
                if (cof == true)
                {
                    var file = Request.Files[0];
                    string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlFiles.Library;

                    if (System.IO.File.Exists(path + "/" + lib.Id + "/" + lib.Images))
                    {
                        // Xóa file
                        System.IO.File.Delete(path + "/" + lib.Id + "/" + lib.Images);
                    }

                    var fileName = lib.Id + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
                    var fileExtension = Path.GetExtension(file.FileName);
                    var physicalPath = path + lib.Id.ToString();
                    if (Directory.Exists(physicalPath))
                    {
                        file.SaveAs(physicalPath + "/" + fileName + fileExtension);
                    }
                    lib.Images = fileName + fileExtension;
                }
                if (lib.Title != objTmp.Title)
                {
                    lib.Title = objTmp.Title;
                }

                if (lib.Type != objTmp.Type)
                {
                    lib.Type = objTmp.Type;
                }

                if (lib.Brief != objTmp.Brief)
                {
                    lib.Brief = objTmp.Brief;
                }

                if (lib.Description != objTmp.Description)
                {
                    lib.Description = objTmp.Description;
                }

                if (lib.Status != objTmp.Status)
                {
                    lib.Status = objTmp.Status;
                }


                string link = ConvertToUnSign3(lib.Title).ToLower();
                link = RemoveSpeacialChar(link);
                link = link.Replace(" ", "-");
                lib.Links = link + "-" + (lib.Id);
                //lib.Createdate = DateTime.Now;

                _libraryService.Update(lib);
                res = Json(new { status = 1, result = "", linksLib = lib.Links });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }
            return res;
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
        public ActionResult DeleteLib()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<List<string>>(Request.Params["obj"]);
                _libraryService.DeleteListLib(objTmp);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult DeleteFiles(long id)
        {
            var res = Json(new { success = true, status = 0, sErr = "" });
            try
            {
                Link n = new Link();
                n = _linksService.GetById(id);
                _linksService.Delete(n);
                string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlFiles.Library;
                string fileName = n.FileName;
                string fileExtension = n.FileExtension;
                string phy = path + n.ObjectId + "/" + fileName + fileExtension;
                if (System.IO.File.Exists(phy))
                {
                    // Xóa file
                    System.IO.File.Delete(phy);
                }

                res = Json(new { success = true, status = 1, result = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { success = true, status = 0, result = ex.Message });
            }
            return res;
        }
        #endregion

        #region -- Helper --

        public ActionResult Search()
        {
            var homeVM = new HomeViewModels();
            homeVM.CommonCodeVM = new List<CommonCodeVM>();

            try
            {
                var lstCommonCode = _commonCodeService.GetAll();
                foreach (var result in lstCommonCode)
                {
                    var count = result.CommonId.Count(p => p == '-');
                    var commonId = result.CommonId + "-";
                    //var commonIdDetails = lstCommonCode.Where(p => p.CommonId.Contains(commonId) && (p.CommonId.Count(t => t == '-') == 2)).ToList();
                    if (result.CommonId.Contains(Constants.InfoType.Announcement))
                    {
                        if (count == 1)
                        {
                            var commonCodeVM = new CommonCodeVM();
                            var commonIdDetails = lstCommonCode.Where(p => p.NumValue1 == 2 && p.CommonId.Contains(result.CommonId)).ToList();
                            commonCodeVM.commonCodeDetailsVM = CommonCodeDetailsVM.Convert(commonIdDetails);
                            commonCodeVM.CommonTypeId = result.CommonTypeId;
                            commonCodeVM.CommonId = result.CommonId;
                            commonCodeVM.Value1 = result.StrValue1;
                            commonCodeVM.Value2 = result.StrValue2;
                            commonCodeVM.Qty = result.Qty;
                            homeVM.CommonCodeVM.Add(commonCodeVM);
                        }
                    }
                }

                if (lstCommonCode != null)
                {
                    return View(homeVM);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Search(string type, string keyWord, DateTime? ftt, DateTime? ttt, int page, int pageSize)
        {
            try
            {
                var listResult = CommonCodeViewModel.Convert(_commonCodeService.GetCategoryIdChild(type));
                var list = _libraryService.getListLibrary(type, keyWord, ftt, ttt);
                var list2 = list.OrderByDescending(p => p.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                var listLib = LibraryViewModels.Convert(list2);
                return Json(new { success = true, listType = listResult, listKey = listLib, TotalRecord = list.Count });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult GetType(string type)
        {
            try
            {
                var listResult = LibraryViewModels.Convert(_libraryService.SeachByType(type));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult ChangeLib(string type)
        {
            try
            {
                var listResult = LibraryViewModels.Convert(_libraryService.ChangeLib(type));
                return Json(new { success = true, data = listResult });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        public ActionResult UpdateFile()
        {
            var res = Json(new { status = 0, sErr = "" });
            //var linkId = _linksService.GetAll().Count() + 1;
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var fls = Request.Files[0];
                string ojbId = "";
                if (Request.Params["idLib"] != null)
                {
                    ojbId = js.Deserialize<string>(Request.Params["idLib"]);
                }

                var physicalPath = "";
                var fileName = "";
                var fileExtension = "";
                if (fls != null)
                {
                    fileName = "fls" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
                    fileExtension = Path.GetExtension(fls.FileName);
                    string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlFiles.Library;
                    physicalPath = path + ojbId + "/" + fileName + fileExtension;
                    fls.SaveAs(physicalPath);
                }

                Link link = new Link();
                link.ObjectId = ojbId;
                link.URL = UrlFiles.Library + ojbId + "/" + fileName + fileExtension;
                link.Type = "Library";
                link.FileExtension = fileExtension;
                link.FileName = fileName;
                link.Status = Constants.News_Status.ActiveStatus;
                //news.CreatedBy = userService.SearchFor(x => x.UserID == Current_UserId).FirstOrDefault().ObjectID;
                link.CreatedOn = DateTime.Now;
                _linksService.Insert(link);
                int count = _linksService.LimitMaxImage(ojbId);
                res = Json(new { status = 1, data = link });
            }
            catch (Exception e)
            {
                return res = Json(new { status = 0, result = e.Message });
            }
            return res;
        }

        [HttpPost]
        public ActionResult UpdateLib(Library lib)
        {
            try
            {
                var idLib = _libraryService.GetById(lib.Id);
                idLib.Title = lib.Title;
                idLib.Brief = lib.Brief;
                idLib.Type = lib.Type;
                idLib.Status = lib.Status;
                idLib.Description = lib.Description;
                _libraryService.Update(idLib);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
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
        #endregion
    }
}
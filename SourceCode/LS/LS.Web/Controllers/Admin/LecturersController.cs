using System.Collections.Generic;
using System.Web.Mvc;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using LS.Model;
    using Models;
    using System;
    using System.Linq;

    /// <summary>
    /// Lecturers controller
    /// </summary>
    public class LecturersController : BaseController
    {
        private ITeacherService _teacherService = new TeacherService();
        private ITeacherMemoryService _teacherMemoryService = new TeacherMemoryService();
        private ITeacherStudiesService _teacherStudiesService = new TeacherStudiesService();
        private ITeacherBackgroundService _teacherBackgroundService = new TeacherBackgroundService();

        #region -- Views --

        #region -- Manage Information --
        public ActionResult Index()
        {
            var teacherVM = new TeacherViewModel();
            var lstTeacher = TeacherViewModels.ConvertToVM(_teacherService.GetAll());
            teacherVM.TeacherVM = lstTeacher;
            return View(teacherVM);
        }

        [HttpPost]
        public ActionResult GetInformation(string keyword, int page, int pageSize)
        {
            var teacherVM = new TeacherViewModel();
            var vm = new List<TeacherBackgroundViewModel>();
            try
            {
                var list = _teacherBackgroundService.SearchFor(x => x.TeacherId == 1 && (x.Description.Contains(keyword) || x.Title.Contains(keyword)));
                var list2 = list.OrderBy(p => p.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                var listResult = TeacherBackgroundViewModel.Convert(list2);
                return Json(new { status = 1, data = listResult, TotalRecord = list.Count });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult GetInfoByID(int id)
        {
            var m = _teacherBackgroundService.GetById(id);
            var vm = TeacherBackgroundViewModel.Convert(m);

            return Json(new { Status = "success", Result = vm }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteInfo(List<string> ids)
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                if (ids.Count > 0)
                {
                    foreach (var item in ids)
                    {
                        var m = _teacherBackgroundService.GetById(item);
                        _teacherBackgroundService.Delete(m);
                    }
                }

                res = Json(new { status = 1, result = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }
            return res;
        }

        public bool AddForInfo(TeacherBackground m)
        {
            var res = false;
            if (m != null)
            {
                var id = int.Parse(_teacherBackgroundService.GetAll().LastOrDefault().Id);
                id++;

                var result = new TeacherBackground
                {
                    Id = id.ToString(),
                    TeacherId = 1,
                    Description = m.Description,
                    Title = m.Title,
                    Type = "EducationBackground",
                    Status = "ACT",
                    CanDelete = true,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now
                };

                _teacherBackgroundService.Insert(result);
                res = true;
            }

            return res;
        }

        public bool EditForInfo(TeacherBackground m)
        {
            var res = false;
            if (m != null)
            {
                var entity = _teacherBackgroundService.GetById(m.Id);

                entity.Title = m.Title;
                entity.Description = m.Description;

                _teacherBackgroundService.Update(entity);
                res = true;
            }

            return res;
        }

        #endregion

        #region -- Manage Teaching --

        public ActionResult ManageTeaching()
        {
            return View();
        }

        #endregion

        #region -- Manage Studies --

        public ActionResult ManageStudies()
        {
            return View();
        }

        public ActionResult SearchForStudies(string keyword)
        {

            var vm = new List<TeacherStudiesViewModel>();
            if (keyword != null)
            {
                var m = _teacherStudiesService.SearchFor(x => x.TeacherId == 1 && (x.Description.Contains(keyword) || x.Title.Contains(keyword)));
                vm = TeacherStudiesViewModel.Convert(m);
            }

            return Json(new { Status = "success", Result = vm }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SearchById(int id)
        {
            var m = _teacherStudiesService.GetById(id);
            var vm = TeacherStudiesViewModel.Convert(m);

            return Json(new { Status = "success", Result = vm }, JsonRequestBehavior.AllowGet);
        }

        public bool UpdateForStudies(TeacherStudy m)
        {
            var res = false;
            if (m != null)
            {
                var result = _teacherStudiesService.GetById(m.Id);
                result.Description = m.Description;
                result.Title = m.Title;
                result.Year = m.Year;

                _teacherStudiesService.Update(result);
                res = true;
            }

            return res;
        }

        public bool AddForStudies(TeacherStudy m)
        {
            var res = false;
            if (m != null)
            {
                var result = new TeacherStudy();
                result.TeacherId = 1;
                result.Description = m.Description;
                result.Title = m.Title;
                result.Year = m.Year;
                result.Type = "ResearchInterests";
                result.Status = "ACT";
                result.CanDelete = false;
                result.CreatedBy = "admin";
                result.CreatedDate = DateTime.Now;

                _teacherStudiesService.Insert(result);
                res = true;
            }

            return res;
        }

        #endregion

        #region -- Manage DelegateStudents --

        public ActionResult ManageDelegateStudents()
        {
            return View();
        }

        #endregion

        #region -- Manage ResearchWorks --

        public ActionResult ManageResearchWorks()
        {
            return View();
        }

        #endregion

        #region -- Manage Gallery --

        public ActionResult ManageGallery()
        {
            return View();
        }

        #endregion

        #region -- Manage Schedule --

        public ActionResult ManageSchedule()
        {
            return View();
        }

        #endregion

        #region -- Manage Contact --

        public ActionResult ManageContact()
        {
            return View();
        }

        #endregion

        #endregion

        #region -- Helper --

        #endregion
    }
}
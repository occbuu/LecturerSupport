using System.Collections.Generic;
using System.Web.Mvc;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using LS.Model;
    using Models;

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
        public ActionResult GetInformation(int id, string keyword)
        {
            var teacherVM = new TeacherViewModel();
            var vm = new List<TeacherBackgroundViewModel>();
            if (id > 0)
            {
                var m = _teacherBackgroundService.SearchFor(x => x.TeacherId == id && (x.Description.Contains(keyword) || x.Title.Contains(keyword)));
                vm = TeacherBackgroundViewModel.Convert(m);
            }

            return Json(new { Status = "success", Result = vm }, JsonRequestBehavior.AllowGet);
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

                _teacherStudiesService.Update(result);
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
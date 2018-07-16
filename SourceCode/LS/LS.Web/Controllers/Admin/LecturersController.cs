using System.Collections.Generic;
using System.Web.Mvc;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Models;

    /// <summary>
    /// Lecturers controller
    /// </summary>
    public class LecturersController : BaseController
    {
        private ITeacherService _teacherService = new TeacherService();
        private ITeacherMemoryService _teacherMemoryService = new TeacherMemoryService();
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
        public ActionResult GetInformation(int id)
        {
            var teacherVM = new TeacherViewModel();
            var vm = new List<TeacherBackgroundViewModel>();
            if (id > 0)
            {
                var m = _teacherBackgroundService.SearchFor(x => x.TeacherId == id);
                vm = TeacherBackgroundViewModel.Convert(m);
            }

            return Json(new { Status = "success", Result = vm }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        public ActionResult ManageTeaching()
        {
            return View();
        }

        [Route("ManageStudies")]
        public ActionResult ManageStudies()
        {
            return View();
        }

        [Route("ManageDelegateStudents")]
        public ActionResult ManageDelegateStudents()
        {
            return View();
        }

        [Route("ManageResearchWorks")]
        public ActionResult ManageResearchWorks()
        {
            return View();
        }

        [Route("ManageGallery")]
        public ActionResult ManageGallery()
        {
            return View();
        }

        [Route("ManageSchedule")]
        public ActionResult ManageSchedule()
        {
            return View();
        }

        [Route("ManageContact")]
        public ActionResult ManageContact()
        {
            return View();
        }

        #endregion

        #region -- Helper --

        #endregion
    }
}
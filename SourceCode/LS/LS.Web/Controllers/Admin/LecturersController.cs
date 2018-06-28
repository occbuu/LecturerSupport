using System.Web.Mvc;
using System.Collections.Generic;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Models;
    using Utility;


    /// <summary>
    /// Lecturers controller
    /// </summary>
    public class LecturersController : BaseController
    {
        private ITeacherService _teacherService = new TeacherService();
        private ITeacherMemoryService _teacherMemoryService = new TeacherMemoryService();
        private ITeacherBackgroundService _teacherBackgroundService = new TeacherBackgroundService();

        #region -- Views --

        public ActionResult Index()
        {
            var teacherVM = new TeacherViewModel();
            teacherVM.TeacherVM = new List<TeacherViewModels>();
            teacherVM.TeacherMemoryVM = new List<TeacherMemoryViewModel>();
            teacherVM.TeacherBackgroundVM = new List<TeacherBackgroundViewModel>();
            var lstTeacher = TeacherViewModels.Convert(_teacherService.SearchByFullName(Constants.Teacher.TranThiThanhDieu));
            var tmp = _teacherMemoryService.SearchByType(Constants.Teacher.Avartar);
            var lstAvartarTeacher = TeacherMemoryViewModel.Convert(tmp);
            var lstTeacherBackground = TeacherMemoryViewModel.Convert(_teacherMemoryService.GetAll());

            foreach (var result in lstTeacher)
            {
                teacherVM.TeacherVM.Add(result);
            }

            foreach (var result in lstAvartarTeacher)
            {
                teacherVM.TeacherMemoryVM.Add(result);
            }

            foreach (var result in lstTeacherBackground)
            {
                teacherVM.TeacherMemoryVM.Add(result);
            }
            return View(teacherVM);
        }

        [Route("ManageTeaching")]
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
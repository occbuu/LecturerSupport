using System.Web.Mvc;
using System;
using System.Collections.Generic;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Models;
    using Utility;

    /// <summary>
    /// About controller
    /// </summary>
    public class AboutController : Controller
    {
        private ITeacherService _teacherService = new TeacherService();
        private ITeacherMemoryService _teacherMemoryService = new TeacherMemoryService();
        private ITeacherBackgroundService _teacherBackgroundService = new TeacherBackgroundService();
        private ITeacherStudiesService _teacherStudiesService = new TeacherStudiesService();
        private ITeacherResearchWorkService _teacherResearchWorkService = new TeacherResearchWorkService();
        private ITeacherDelegateStudentService _teacherDelegateStudentService = new TeacherDelegateStudentService();

        #region -- View --

        [Route("About")]
        public ActionResult Index()
        {
            var teacherVM = new TeacherViewModel();
            teacherVM.TeacherVM = new List<TeacherViewModels>();
            teacherVM.TeacherMemoryVM = new List<TeacherMemoryViewModel>();
            teacherVM.TeacherBackgroundVM = new List<TeacherBackgroundViewModel>();
            var lstTeacher = TeacherViewModels.Convert(_teacherService.SearchByFullName(Constants.Teacher.TranThiThanhDieu));
            var tmp = _teacherMemoryService.SearchByType(Constants.Teacher.Avartar);
            var lstAvartarTeacher = TeacherMemoryViewModel.Convert(tmp);
            var lstEducationBackground = TeacherMemoryViewModel.Convert(_teacherMemoryService.SearchByType(Constants.Teacher.EducationBackground));
            var lstCurrentJob = TeacherMemoryViewModel.Convert(_teacherMemoryService.SearchByType(Constants.Teacher.CurrentJob));

            foreach (var result in lstTeacher)
            {
                teacherVM.TeacherVM.Add(result);
            }

            foreach (var result in lstAvartarTeacher)
            {
                teacherVM.TeacherMemoryVM.Add(result);
            }

            foreach (var result in lstEducationBackground)
            {
                teacherVM.TeacherMemoryVM.Add(result);
            }

            foreach (var result in lstCurrentJob)
            {
                teacherVM.TeacherMemoryVM.Add(result);
            }
            return View(teacherVM);
        }

        [Route("Teaching")]
        public ActionResult Teaching()
        {
            return View();
        }

        [Route("Studies")]
        public ActionResult Studies()
        {
            var teacherVM = new TeacherViewModel();
            teacherVM.TeacherStudiesVM = new List<TeacherStudiesViewModel>();
            var lstTeacherStudies = TeacherStudiesViewModel.Convert(_teacherStudiesService.GetAll());

            foreach (var result in lstTeacherStudies)
            {
                teacherVM.TeacherStudiesVM.Add(result);
            }

            return View(teacherVM);
        }

        [Route("ResearchWorks")]
        public ActionResult ResearchWorks(string type)
        {
            if (!string.IsNullOrEmpty(type))
            {
                var count = 0;
                var teacherResearchWorkVM = new TeacherResearchWorkViewModel();
                var lst = new List<TeacherResearchWorkViewModel>();
                //var lstTeacherResearchWork = TeacherResearchWorkViewModels.Convert(_teacherResearchWorkService.GetAll());
                var lstJournalArticlesType = TeacherResearchWorkViewModel.Convert(_teacherResearchWorkService.SearchType(type, 1, 4, out count));
                teacherResearchWorkVM.TRJournalArticlesVM = lstJournalArticlesType;
                teacherResearchWorkVM.TotalNews = count;
                teacherResearchWorkVM.TRReseachProjectsVM = TeacherResearchWorkViewModel.Convert(_teacherResearchWorkService.SearchType("ResearchProjects"));
                teacherResearchWorkVM.TRBookVM = TeacherResearchWorkViewModel.Convert(_teacherResearchWorkService.SearchType("Books"));
                teacherResearchWorkVM.TRConferenceProceedings = TeacherResearchWorkViewModel.Convert(_teacherResearchWorkService.SearchType("ConferenceProceedings"));

                return View("ResearchWorks", teacherResearchWorkVM);
            }
            else
            {
                return PartialView("_404");
            }
        }

        [HttpPost]
        public ActionResult getDataNewsPage(int page, string type)
        {
            var res = Json(new { status = 0, TotalRecord = 0, sErr = "" });
            try
            {
                var lstNews = new List<TeacherResearchWorkViewModel>();
                int total = 0;
                var lst = _teacherResearchWorkService.SearchType(type, page, 4, out total);

                lstNews = TeacherResearchWorkViewModel.Convert(lst);
                res = Json(new { status = 1, TotalRecord = total, sErr = "", data = lstNews });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, TotalRecord = 0, sErr = ex.Message });
            }
            return res;
        }

        [Route("MyClass")]
        public ActionResult MyClass()
        {
            return View();
        }

        public ActionResult MyTeachedClass()
        {
            return View();
        }

        [Route("DelegateStudents")]
        public ActionResult DelegateStudents()
        {
            var teacherVM = new TeacherViewModel();
            teacherVM.TeacherDelegateStudentVM = new List<TeacherDelegateStudentViewModel>();
            var lstDelegateStudent = TeacherDelegateStudentViewModel.Convert(_teacherDelegateStudentService.GetAll());

            foreach(var result in lstDelegateStudent)
            {
                teacherVM.TeacherDelegateStudentVM.Add(result);
            }
            return View(teacherVM);
        }

        [Route("DetailClass")]
        public ActionResult DetailClass()
        {
            return View();
        }

        public ActionResult RecentClass()
        {
            return PartialView();
        }

        [Route("Schedule")]
        public ActionResult Schedule()
        {
            return View();
        }

        [Route("Gallery")]
        public ActionResult Gallery()
        {
            var teacherVM = new TeacherViewModel();
            teacherVM.TeacherMemoryVM = new List<TeacherMemoryViewModel>();
            var lstGallery = TeacherMemoryViewModel.Convert(_teacherMemoryService.SearchByType("MyClass"));

            foreach (var result in lstGallery)
            {
                teacherVM.TeacherMemoryVM.Add(result);
            }
            return View(teacherVM);
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
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
                //TODO - Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
                //TODO - Add update logic here
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
                //TODO - Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region -- Helper --

        #endregion
    }
}
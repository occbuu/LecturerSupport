using System;
using System.Web.Mvc;
using System.Linq;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Models;
    using System.Collections.Generic;

    public class ManageUserController : BaseController
    {
        #region -- Properties --
        private IUniversityService _universityService = new UniversityService(); 
        #endregion

        #region -- Views --

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region -- Action --

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetSchool()
        {
            var res = Json(new { status = 0, sErr = "" });
            try
            {
                var lstUniver = new List<UniversityViewModel>();
                var temp = _universityService.GetAll().ToList();
                lstUniver = UniversityViewModel.Convert(temp);

                res = Json(new { status = 1, data=lstUniver });
            }
            catch (Exception)
            {
                return Json(new { status = false });
            }
            return res;
        }

        [HttpPost]
        public ActionResult GetStudent()
        {
            var res = Json(new { status = 0, sErr = "" });
            try
            {
                var lstUniver = new List<UniversityViewModel>();
                var temp = _universityService.GetAll().ToList();
                lstUniver = UniversityViewModel.Convert(temp);

                res = Json(new { status = 1, data = lstUniver });
            }
            catch (Exception)
            {
                return Json(new { status = false });
            }
            return res;
        }

        #endregion
    }
}
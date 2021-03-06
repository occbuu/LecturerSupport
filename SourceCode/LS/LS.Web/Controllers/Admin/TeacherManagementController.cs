﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LS.Web.Controllers.Admin
{
    using BLL;
    using IBLL;
    using Model;
    using Models;

    public class TeacherManagementController : Controller
    {
        // GET: TeacherManagement
        #region -- properties --
        private ITeacherService _teacherService = new TeacherService();


        #endregion

        #region -- View --

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
        #endregion

        #region -- Action --

        // Show all list data in Table Teacher
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult GetAllTeacher(int pageNumber, int pageSize)
        {
            try
            {
                var list = TeacherViewModels.Convert(_teacherService.GetAll());
                var listResult = list.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                return Json(new { success = true, data = listResult, listAllTeacher = list });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        // Insert Teacher and information of that
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult AddTeacher()
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<TeacherViewModels>(Request.Params["obj"]);
                var teacher = new Teacher();
                teacher.FullName = objTmp.FullName;
                teacher.Birthday = DateTime.Parse(objTmp.Birthday);
                teacher.Address = objTmp.Address;
                teacher.Gender = objTmp.Gender;
                teacher.PhoneNumber = objTmp.PhoneNumber;
                teacher.Description = objTmp.Description;
                teacher.Owner = "0";
                teacher.CreatedBy = UserFrontVM.CurrentUser.UserId;
                teacher.CreatedDate = DateTime.Now;

                _teacherService.Insert(teacher);

                return Json(new { success = true, id = teacher.Id });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        // Update Teacher's information
        public ActionResult EditTeacher(Teacher entity)
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var teacher = _teacherService.GetById(entity.Id);
                if (teacher.FullName != entity.FullName)
                {
                    teacher.FullName = entity.FullName;
                }
                if (teacher.Birthday != entity.Birthday)
                {
                    teacher.Birthday = entity.Birthday;
                }
                if (teacher.Address != entity.Address)
                {
                    teacher.Address = entity.Address;
                }
                if (teacher.Gender != entity.Gender)
                {
                    teacher.Gender = entity.Gender;
                }
                if (teacher.PhoneNumber != entity.PhoneNumber)
                {
                    teacher.PhoneNumber = entity.PhoneNumber;
                }
                if (teacher.Description != entity.Description)
                {
                    teacher.Description = entity.Description;
                }
                teacher.ModifiedBy = UserFrontVM.CurrentUser.UserId;
                teacher.ModifiedDate = DateTime.Now;

                _teacherService.Update(teacher);

                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        // Search information of teacher in their teacher
        [HttpPost]
        public ActionResult Search(string keyWord, string gender, int pageNumber, int pageSize, int recordCount)
        {
            try
            {
                var list = _teacherService.SearchTeacher(keyWord, gender, pageNumber, pageSize, out recordCount);
                var listTeacher = TeacherViewModels.Convert(list);
                return Json(new { success = true, data = listTeacher, TotalRecord = recordCount });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        // Delete line data on Table Teacher
        [HttpPost]
        public ActionResult DeleteTeacher()
        {
            try
            {

                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<List<string>>(Request.Params["obj"]);
                _teacherService.DelteTeacher(objTmp);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }
        #endregion

        #region -- Private Function --
        #endregion
    }
}
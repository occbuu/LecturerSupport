using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LS.Web.Controllers.Admin
{
    using BLL;
    using IBLL;
    using Model;
    using Models;
    using System.Web.Script.Serialization;

    public class SubjectManagementController : BaseController
    {

        private ISubjectService _subjectService = new SubjectService();

        #region -- View --
        // GET: SubjectManagement
        public ActionResult SearchAndEdit()
        {
            return View();
        }
        #endregion

        #region -- Create --
        // GET: SubjectManagement/Create
        public ActionResult Create()
        {
            try
            {
                var listSubject = SubjectViewModel.Convert(_subjectService.GetAll());
                return View(listSubject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: SubjectManagement/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateSubject(Subject subject)
        {
            var lstSubject = _subjectService.GetAll();
            foreach (var result in lstSubject)
            {
                if (subject.SubjectName == result.SubjectName)
                {
                    subject.SubjectName = null;
                    break;
                }
            }
            try
            {
                Subject newSubject = new Subject();
                //var idSubject = _subjectService.SeachBySubjectName(subject.SubjectName).ToList();
                //newSubject.Id = idSubject[0].Id;
                newSubject.SubjectName = subject.SubjectName;
                newSubject.Description = subject.Description;
                newSubject.SubjectType = subject.SubjectType;
                newSubject.Unit = subject.Unit;
                newSubject.Practice = subject.Practice;
                newSubject.Theory = subject.Theory;
                newSubject.CanDelete = true;
                newSubject.Status = subject.Status;
                newSubject.CreatedBy = "Van";
                newSubject.CreatedOn = DateTime.Now;

                _subjectService.Insert(newSubject);
                return Json(new { success = true , id= newSubject.Id});
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }
        #endregion

        #region -- Edit --
        // GET: SubjectManagement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectManagement/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult UpdateSubject(Subject subject)
        {
            try
            {
                var idSubject = _subjectService.GetById(subject.Id);
                idSubject.SubjectName = subject.SubjectName;
                idSubject.Description = subject.Description;
                idSubject.SubjectType = subject.SubjectType;
                idSubject.Unit = subject.Unit;
                idSubject.Practice = subject.Practice;
                idSubject.Theory = subject.Theory;
                idSubject.Status = subject.Status;
                _subjectService.Update(idSubject);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }
        #endregion

        #region -- Delete --
        // GET: SubjectManagement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteSubject()
        {
            var res = Json(new { status = 0, sErr = "" });

            try
            {
                var js = new JavaScriptSerializer();
                var objTmp = js.Deserialize<List<string>>(Request.Params["obj"]);

                var news = new News();
                _subjectService.DeleteListSubject(objTmp);
                res = Json(new { status = 1, result = "" });
            }
            catch (Exception ex)
            {
                res = Json(new { status = 0, result = ex.Message });
            }
            return res;
        }

        // POST: SubjectManagement/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region -- Helper --
        [HttpPost]
        public ActionResult Search(string keyWord, DateTime? ftt, DateTime? ttt, int page, int pageSize)
        {
            try
             {
                var list = _subjectService.getListPost(keyWord, ftt, ttt);
                var list2 = list.OrderByDescending(p => p.CreatedOn).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                var listResult = SubjectViewModel.Convert(list2);
                return Json(new { status = 1, data = listResult, TotalRecord = list.Count });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

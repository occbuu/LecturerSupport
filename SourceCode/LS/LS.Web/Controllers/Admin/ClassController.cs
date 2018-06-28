using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.IO;
using System.Collections.Generic;

namespace LS.Web.Controllers
{
    using Common;
    using LS.BLL;
    using LS.IBLL;
    using LS.Utility;
    using Model;
    using Models;

    /// <summary>
    /// Class controller
    /// </summary>
    public class ClassController : BaseController
    {
        #region -- Properties --

        private IUniversityService _universityService = new UniversityService();
        private IClassService _classService = new ClassService();
        private IScheduleService _scheduleService = new ScheduleService();
        private ISubjectService _subjectService = new SubjectService();
        private ITeacherService _teacherService = new TeacherService();
        private ICourseScoreService _courseScoreService = new CourseScoreService();
        private IStudentClassService _studentClassService = new StudentClassService();
        private IDocumentService _documentService = new DocumentService();
        private ICommonCodeService _commonCodeService = new CommonCodeService();
        private IAssignmentConfigService _assignmentConfigService = new AssignmentConfigService();


        #endregion

        #region -- Views --

        public ActionResult Index()
        {
            try
            {
                var getSchool = _universityService.GetAll();
                var lstSchool = UniversityViewModel.Convert(getSchool);
                return View(lstSchool);
            }
            catch
            {
                throw;
            }
        }

        public ActionResult ManageInfoClass()
        {
            try
            {
                var getSchool = _universityService.GetAll();
                var lstSchool = UniversityViewModel.Convert(getSchool);
                return View(lstSchool);
            }
            catch
            {
                throw;
            }
        }

        public ActionResult Conspectus()
        {
            try
            {
                var getSchool = _universityService.GetAll();
                var lstSchool = UniversityViewModel.Convert(getSchool);
                return View(lstSchool);
            }
            catch
            {
                throw;
            }
        }

        public ActionResult LessonsAndReference()
        {
            try
            {
                var getSchool = _universityService.GetAll();
                var lstSchool = UniversityViewModel.Convert(getSchool);
                return View(lstSchool);
            }
            catch
            {
                throw;
            }
        }

        public ActionResult ExerciseAndAssignment()
        {
            try
            {
                var getSchool = _universityService.GetAll();
                var lstSchool = UniversityViewModel.Convert(getSchool);
                return View(lstSchool);
            }
            catch
            {
                throw;
            }
        }

        public ActionResult ClassListAndPoint()
        {
            return View();
        }

        public ActionResult CheckAttendanceAndEnterPoints()
        {
            return View();
        }

        public ActionResult ScoreConfig()
        {
            return View();
        }

        public ActionResult AssignmentConfig()
        {
            try
            {
                var getSchool = _universityService.GetAll();
                var lstSchool = UniversityViewModel.Convert(getSchool);
                return View(lstSchool);
            }
            catch
            {
                throw;
            }
        }

        [Route("Discuss")]
        public ActionResult Discuss()
        {
            return View();
        }

        [Route("Notification")]
        public ActionResult Notification()
        {
            return View();
        }

        #endregion

        #region -- Edit --

        [HttpPost]
        public JsonResult UpdateAssignmentConfig(string model)
        {
            try
            {
                var js = new JavaScriptSerializer();
                var renAgC = js.Deserialize<AssignmentConfigViewModel>(model);
                var temp = _assignmentConfigService.GetById(renAgC.Id);

                if (temp == null)
                {
                    return Json(new
                    {
                        status = -1 //Failed when connected to server
                    });
                }

                var startDate = StringDateTime.StringToFormatDate(renAgC.StartDate);
                var endDate = StringDateTime.StringToFormatDate(renAgC.EndDate);
                if (startDate == null || endDate == null)
                {
                    return Json(new { success = -2 }); //wrong date
                }
                temp.StartDate = DateTime.Parse(startDate);
                temp.EndDate = DateTime.Parse(endDate);
                temp.DocumentId = renAgC.DocumentId;
                temp.Content = renAgC.Content;
                temp.Status = renAgC.Status;
                temp.ModifiedOn = DateTime.Now;
                temp.ModifiedBy = "Admin"; //TODO

                _assignmentConfigService.Update(temp);
                return Json(new
                {
                    status = 1 //Success
                });
            }
            catch
            {
                return Json(new
                {
                    status = -1 //Failed when connected to server
                });
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult UpdateClass()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var model = js.Deserialize<ClassViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                var getClass = _classService.GetById(model.Id);

                if (getClass == null)
                {
                    return Json(new { success = -1 });//cant connect to server
                }

                if (cof)
                {
                    var img = Request.Files[0];
                    //string path = HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlImages.ImagesPost;
                    var year = DateTime.Now.Year.ToString();
                    var month = DateTime.Now.Hour.ToString();
                    var day = DateTime.Now.Day.ToString();

                    var hour = DateTime.Now.Hour.ToString();
                    var minute = DateTime.Now.Minute.ToString();
                    var milisecond = DateTime.Now.Millisecond.ToString();
                    var prefix = year + month + day + hour + minute + milisecond;

                    var fileExtension = Path.GetExtension(img.FileName);
                    var pathFile = Constants.Class.DirSaveImagesClass;
                    var nameImage = getClass.Id + "_" + prefix + fileExtension;

                    var exit = Directory.Exists(Server.MapPath(pathFile));
                    if (!exit)
                    {
                        Directory.CreateDirectory(Server.MapPath(pathFile));
                    }
                    var path = Path.Combine(Server.MapPath(pathFile), nameImage);
                    img.SaveAs(path);
                    getClass.Images = nameImage;
                }

                var startDate = StringDateTime.StringToFormatDate(model.StartDate);

                var endDate = StringDateTime.StringToFormatDate(model.EndDate);
                if (startDate == null || endDate == null)
                {
                    return Json(new { success = -2 }); //wrong date
                }
                var universityId = model.UniversityId.ToString();
                var teacherAssistantId = model.TeacherAssistantId.ToString();
                var teacherId = model.TeacherId.ToString();
                var subjectId = model.SubjectId.ToString();

                if (subjectId == null || model.Code == null || teacherAssistantId == null ||
                    teacherId == null || universityId == null || model.Prerequisition == null ||
                    model.Value == null)
                {
                    return Json(new { success = -1 });//cant connect to server
                }

                getClass.Status = model.Status;
                getClass.Code = model.Code;

                getClass.Name = model.Name;
                getClass.StartDate = DateTime.Parse(startDate);
                getClass.EndDate = DateTime.Parse(endDate);
                getClass.TeacherId = model.TeacherId;
                getClass.TeachingAssistantId = model.TeacherAssistantId;

                getClass.SubjectId = model.SubjectId;
                getClass.UniversityId = model.UniversityId;
                getClass.Description = model.Value;

                getClass.Prerequisition = model.Prerequisition;
                getClass.ModifiedBy = "Admin";//TODO
                getClass.ModifiedOn = DateTime.Now;

                _classService.Update(getClass);
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult UpdateConspectusDocument()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var model = js.Deserialize<DocumentViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                var getDoc = _documentService.GetById(model.Id);

                if (cof)
                {
                    var file = Request.Files[0];
                    var year = DateTime.Now.Year.ToString();
                    var month = DateTime.Now.Hour.ToString();
                    var day = DateTime.Now.Day.ToString();

                    var hour = DateTime.Now.Hour.ToString();
                    var minute = DateTime.Now.Minute.ToString();
                    var milisecond = DateTime.Now.Millisecond.ToString();
                    var prefix = year + month + day + hour + minute + milisecond;

                    var fileExtension = Path.GetExtension(file.FileName);
                    var pathFile = Constants.Document.DirSaveConspectusDoc;
                    var nameFile = getDoc.Id + "_" + prefix + fileExtension;

                    var exit = Directory.Exists(Server.MapPath(pathFile));
                    if (!exit)
                    {
                        Directory.CreateDirectory(Server.MapPath(pathFile));
                    }
                    var path = Path.Combine(Server.MapPath(pathFile), nameFile);
                    file.SaveAs(path);
                    getDoc.Linkl = Constants.Document.DirConspectusDoc + nameFile;
                    getDoc.FileName = nameFile;
                    getDoc.FileExtension = fileExtension;
                }
                getDoc.ClassId = model.ClassId;
                getDoc.Status = model.Status;
                getDoc.Title = model.Title;

                getDoc.ModidiedBy = "admin";
                getDoc.ModidiedOn = DateTime.Now;
                getDoc.Content = model.Content;
                getDoc.Type = model.CommonId;

                _documentService.Update(getDoc);
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult UpdateLessonDocument()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var model = js.Deserialize<DocumentViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                var getDoc = _documentService.GetById(model.Id);

                if (cof)
                {
                    var file = Request.Files[0];
                    var year = DateTime.Now.Year.ToString();
                    var month = DateTime.Now.Hour.ToString();
                    var day = DateTime.Now.Day.ToString();
                    var hour = DateTime.Now.Hour.ToString();
                    var minute = DateTime.Now.Minute.ToString();
                    var milisecond = DateTime.Now.Millisecond.ToString();
                    var prefix = year + month + day + hour + minute + milisecond;
                    var fileExtension = Path.GetExtension(file.FileName);
                    var pathFile = Constants.Document.DirSaveLessonDoc;
                    var nameFile = getDoc.Id + "_" + prefix + fileExtension;
                    var exit = Directory.Exists(Server.MapPath(pathFile));
                    if (!exit)
                    {
                        Directory.CreateDirectory(Server.MapPath(pathFile));
                    }
                    var path = Path.Combine(Server.MapPath(pathFile), nameFile);
                    file.SaveAs(path);
                    getDoc.Linkl = Constants.Document.DirLessonDoc + nameFile;
                    getDoc.FileName = nameFile;
                    getDoc.FileExtension = fileExtension;
                }
                getDoc.ClassId = model.ClassId;
                getDoc.Status = model.Status;
                getDoc.Title = model.Title;
                getDoc.ModidiedBy = "admin";
                getDoc.ModidiedOn = DateTime.Now;
                getDoc.Content = model.Content;
                getDoc.Type = model.CommonId;
                _documentService.Update(getDoc);
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }
        #endregion

        #region -- Create --

        [HttpPost]
        public JsonResult CreateAssignmentConfig(string model)
        {
            try
            {
                var js = new JavaScriptSerializer();
                var renAgC = js.Deserialize<AssignmentConfigViewModel>(model);
                var temp = new AssignmentConfig();

                var startDate = StringDateTime.StringToFormatDate(renAgC.StartDate);
                var endDate = StringDateTime.StringToFormatDate(renAgC.EndDate);
                if (startDate == null || endDate == null)
                {
                    return Json(new { success = -2 }); //wrong date
                }
                temp.ClassId = renAgC.ClassId;
                temp.CreatedBy = "admin"; //TODO
                temp.CreatedOn = DateTime.Now;
                temp.StartDate = DateTime.Parse(startDate);
                temp.EndDate = DateTime.Parse(endDate);
                temp.DocumentId = renAgC.DocumentId;
                temp.Content = renAgC.Content;
                temp.Status = renAgC.Status;

                _assignmentConfigService.Insert(temp);
                return Json(new
                {
                    status = 1 //Success
                });
            }
            catch
            {
                return Json(new
                {
                    status = -1 //Failed when connected to server
                });
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult CreateClass()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var model = js.Deserialize<ClassViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                var iClass = new Class();

                var startDate = StringDateTime.StringToFormatDate(model.StartDate);

                var endDate = StringDateTime.StringToFormatDate(model.EndDate);
                if (startDate == null || endDate == null)
                {
                    return Json(new { success = -2 }); //wrong date
                }
                iClass.Status = model.Status;
                iClass.Code = model.Code;
                iClass.Name = model.Name;
                iClass.StartDate = DateTime.Parse(startDate);
                iClass.EndDate = DateTime.Parse(endDate);
                iClass.TeacherId = model.TeacherId;
                iClass.TeachingAssistantId = model.TeacherAssistantId;
                iClass.SubjectId = model.SubjectId;
                iClass.UniversityId = model.UniversityId;
                iClass.Description = model.Value;
                iClass.Prerequisition = model.Prerequisition;
                _classService.Insert(iClass);

                if (cof)
                {
                    var img = Request.Files[0];
                    //string path = HostingEnvironment.ApplicationPhysicalPath.Replace("\\", "/") + UrlImages.ImagesPost;
                    var year = DateTime.Now.Year.ToString();
                    var month = DateTime.Now.Hour.ToString();
                    var day = DateTime.Now.Day.ToString();
                    var hour = DateTime.Now.Hour.ToString();
                    var minute = DateTime.Now.Minute.ToString();
                    var milisecond = DateTime.Now.Millisecond.ToString();
                    var prefix = year + month + day + hour + minute + milisecond;
                    var fileExtension = Path.GetExtension(img.FileName);
                    var pathFile = Constants.Class.DirSaveImagesClass;
                    var nameImage = iClass.Id + "_" + prefix + fileExtension;
                    var exit = Directory.Exists(Server.MapPath(pathFile));
                    if (!exit)
                    {
                        Directory.CreateDirectory(Server.MapPath(pathFile));
                    }
                    var path = Path.Combine(Server.MapPath(pathFile), nameImage);
                    img.SaveAs(path);
                    iClass.Images = nameImage;
                }

                _classService.Update(iClass);
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult CreateConspectusDocument()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var model = js.Deserialize<DocumentViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                var getDoc = new Document();

                getDoc.ClassId = model.ClassId;
                getDoc.Status = model.Status;
                getDoc.Title = model.Title;
                getDoc.CreatedBy = "admin";
                getDoc.CreateDate = DateTime.Now;
                getDoc.Content = model.Content;
                getDoc.Type = model.CommonId;
                getDoc.DocumentType = Constants.Document.Conspectus;
                _documentService.Insert(getDoc);

                if (cof)
                {
                    var file = Request.Files[0];
                    var year = DateTime.Now.Year.ToString();
                    var month = DateTime.Now.Hour.ToString();
                    var day = DateTime.Now.Day.ToString();
                    var hour = DateTime.Now.Hour.ToString();
                    var minute = DateTime.Now.Minute.ToString();
                    var milisecond = DateTime.Now.Millisecond.ToString();
                    var prefix = year + month + day + hour + minute + milisecond;
                    var fileExtension = Path.GetExtension(file.FileName);
                    var pathFile = Constants.Document.DirSaveConspectusDoc;
                    var nameFile = getDoc.Id + "_" + prefix + fileExtension;
                    var exit = Directory.Exists(Server.MapPath(pathFile));
                    if (!exit)
                    {
                        Directory.CreateDirectory(Server.MapPath(pathFile));
                    }
                    var path = Path.Combine(Server.MapPath(pathFile), nameFile);
                    file.SaveAs(path);
                    getDoc.Linkl = Constants.Document.DirConspectusDoc + nameFile;
                    getDoc.FileName = nameFile;
                    getDoc.FileExtension = fileExtension;
                    _documentService.Update(getDoc);
                }
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult CreateLessonDocument()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var model = js.Deserialize<DocumentViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                var getDoc = new Document();

                getDoc.ClassId = model.ClassId;
                getDoc.Status = model.Status;
                getDoc.Title = model.Title;
                getDoc.CreatedBy = "admin";
                getDoc.CreateDate = DateTime.Now;
                getDoc.Content = model.Content;
                getDoc.Type = model.CommonId;
                getDoc.DocumentType = Constants.Document.LessonReferences;
                _documentService.Insert(getDoc);

                if (cof)
                {
                    var file = Request.Files[0];
                    var year = DateTime.Now.Year.ToString();
                    var month = DateTime.Now.Hour.ToString();
                    var day = DateTime.Now.Day.ToString();
                    var hour = DateTime.Now.Hour.ToString();
                    var minute = DateTime.Now.Minute.ToString();
                    var milisecond = DateTime.Now.Millisecond.ToString();
                    var prefix = year + month + day + hour + minute + milisecond;
                    var fileExtension = Path.GetExtension(file.FileName);
                    var pathFile = Constants.Document.DirSaveLessonDoc;
                    var nameFile = getDoc.Id + "_" + prefix + fileExtension;
                    var exit = Directory.Exists(Server.MapPath(pathFile));
                    if (!exit)
                    {
                        Directory.CreateDirectory(Server.MapPath(pathFile));
                    }
                    var path = Path.Combine(Server.MapPath(pathFile), nameFile);
                    file.SaveAs(path);
                    getDoc.Linkl = Constants.Document.DirLessonDoc + nameFile;
                    getDoc.FileName = nameFile;
                    getDoc.FileExtension = fileExtension;
                    _documentService.Update(getDoc);
                }
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult CreateExcerciseDocument()
        {
            try
            {
                var js = new JavaScriptSerializer();
                var model = js.Deserialize<DocumentViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                var getDoc = new Document();

                getDoc.ClassId = model.ClassId;
                getDoc.Status = model.Status;
                getDoc.Title = model.Title;
                getDoc.CreatedBy = "admin";
                getDoc.CreateDate = DateTime.Now;
                getDoc.Content = model.Content;
                getDoc.Type = model.CommonId;
                getDoc.DocumentType = Constants.Document.Exercise;
                _documentService.Insert(getDoc);

                if (cof)
                {
                    var file = Request.Files[0];
                    var year = DateTime.Now.Year.ToString();
                    var month = DateTime.Now.Hour.ToString();
                    var day = DateTime.Now.Day.ToString();
                    var hour = DateTime.Now.Hour.ToString();
                    var minute = DateTime.Now.Minute.ToString();
                    var milisecond = DateTime.Now.Millisecond.ToString();
                    var prefix = year + month + day + hour + minute + milisecond;
                    var fileExtension = Path.GetExtension(file.FileName);
                    var pathFile = Constants.Document.DirSaveExercisenDoc;
                    var nameFile = getDoc.Id + "_" + prefix + fileExtension;
                    var exit = Directory.Exists(Server.MapPath(pathFile));
                    if (!exit)
                    {
                        Directory.CreateDirectory(Server.MapPath(pathFile));
                    }
                    var path = Path.Combine(Server.MapPath(pathFile), nameFile);
                    file.SaveAs(path);
                    getDoc.Linkl = Constants.Document.DirExerciseDoc + nameFile;
                    getDoc.FileName = nameFile;
                    getDoc.FileExtension = fileExtension;
                    _documentService.Update(getDoc);
                }
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }


        #endregion

        #region -- Delete --

        [HttpPost]
        public JsonResult DeleteConfig(long id)
        {
            try
            {
                var temp = _assignmentConfigService.GetById(id);
                if (temp == null)
                {
                    return Json(new { success = -1 });//cant connect to server
                }
                _assignmentConfigService.Delete(temp);
                return Json(new { success = 1 });//success
            }
            catch
            {
                {
                    return Json(new { success = -1 });//cant connect to server
                }
            }


        }

        [HttpPost]
        public ActionResult DeleteClass(ClassViewModel model)
        {
            try
            {
                var getClass = _classService.GetById(model.Id);
                getClass.Status = Constants.Class_Status.DeleteStatus;
                _classService.Update(getClass);
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }

        [HttpPost]
        public ActionResult DeleteDocument(long? id)
        {
            try
            {
                var getDoc = _documentService.GetById(id);
                getDoc.Status = Constants.Document_Status.DeleteStatus;
                _documentService.Update(getDoc);
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }


        #endregion

        #region -- Helper --

        //[HttpPost]
        //public JsonResult GetStudentExercise(long? docId, long? classId, int pageNumber, int pageSize=3)
        //{
            
        //}

        [HttpPost]
        public JsonResult SearchBySelectedLsit(string model, int pageNumber, int pageSize = 3)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                var renClass = serializer.Deserialize<SearchSelectedListViewModel>(model);
                if (renClass.SchoolId.ToString() == Constants.University_Staus.All)
                {
                    renClass.SchoolId = null;
                }
                if (renClass.Status == Constants.Class_Status.All)
                {
                    renClass.Status = null;
                }
                var count = 0;
                var getClass = _classService.SearchBySelectedList(renClass.Status, renClass.SchoolId, renClass.FromDate, renClass.ToDate, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listClass = ClassViewModel.Convert(getClass);
                return Json(new
                {
                    status = true,
                    listClass = listClass,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult SearchByTying(string keyWord, int pageNumber, int pageSize = 3)
        {
            try
            {
                var count = 0;
                var getClass = _classService.SearchByTyping(keyWord, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listClass = ClassViewModel.Convert(getClass);
                return Json(new
                {
                    status = true,
                    listClass = listClass,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult ClassSchedule(long id, int pageNumber, int pageSize)
        {
            try
            {
                var count = 0;
                var getClassSchedule = _scheduleService.SearchByClassId(null, null, id, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listClass = ScheduleDetail.Convert(getClassSchedule);
                return Json(new
                {
                    status = true,
                    listClass = listClass,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult LoadSubject()
        {
            try
            {
                var getSubject = _subjectService.GetAll();
                var listSubject = SubjectViewModel.Convert(getSubject);
                return Json(new
                {
                    status = true,
                    listSubject = listSubject
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult LoadSchool()
        {
            try
            {
                var getSubject = _subjectService.GetAll();
                var listSubject = SubjectViewModel.Convert(getSubject);
                return Json(new
                {
                    status = true,
                    listSubject = listSubject
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult LoadTeacher()
        {
            try
            {
                var getTeacher = _teacherService.GetAll();
                var listTeacher = TeacherViewModels.Convert(getTeacher);
                return Json(new
                {
                    status = true,
                    listTeacher = listTeacher
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult LoadStudent(long? classId, int pageNumber, int pageSize)
        {
            var count = 0;
            var lstCourseScore = _courseScoreService.GetCourseScoreByClassId(classId, out count);
            var lstStudentClass = _studentClassService.SearchByClassId(classId, pageNumber, pageSize, out count);

            StudentScoreViewModel studentScore = null;
            var lstStudentScore = new List<StudentScoreViewModel>();
            foreach (var lsl in lstStudentClass)
            {
                var percent = 0;
                float totalScore = 0;
                studentScore = new StudentScoreViewModel();
                foreach (var lcs in lstCourseScore)
                {
                    if (lcs.StudentId == lsl.StudentId)
                    {
                        percent += int.Parse(lcs.PercentScore);
                        totalScore += float.Parse(lcs.Score) * float.Parse(lcs.PercentScore);
                    }
                }

                studentScore.StudentId = lsl.StudentId;
                studentScore.Name = lsl.Student.Object.FullName;
                studentScore.Birthday = lsl.Student.Object.DoB.Value.ToString("dd/MM/yyyy");
                studentScore.TemAdd = lsl.Student.Object.TemAdd;

                studentScore.TotalMark = string.Empty;
                if (percent == 100)
                {
                    studentScore.TotalMark = (totalScore / percent).ToString();
                }
                lstStudentScore.Add(studentScore);
            }
            return Json(new
            {
                status = 1,
                lstStudentScore = lstStudentScore,
                total = count
            });
        }

        [HttpPost]
        public JsonResult LoadConspectus(long? classId, int pageNumber, int pageSize)
        {
            var count = 0;
            var getComsectus = _documentService.SearchByClassId(classId, Constants.Document.Conspectus, pageNumber, pageSize, out count);
            var lstComsectus = DocumentViewModel.Convert(getComsectus);
            return Json(new
            {
                status = 1,
                lstComsectus = lstComsectus,
                total = count
            });
        }

        [HttpPost]
        public JsonResult LoadLessonDocumentType()
        {
            var getComsectus = _commonCodeService.GetValue1(Constants.Document.CommonTypeId, Constants.Document.LessonReferences);

            var lstLesson = DocumentTypeViewModel.Convert(getComsectus);
            return Json(new
            {
                status = 1,
                lstLesson = lstLesson,
            });
        }

        [HttpPost]
        public JsonResult LoadExerciseDocumentType()
        {
            var getComsectus = _commonCodeService.GetValue1(Constants.Document.CommonTypeId, Constants.Document.Exercise);

            var lstExercise = DocumentTypeViewModel.Convert(getComsectus);
            return Json(new
            {
                status = 1,
                lstExercise = lstExercise,
            });
        }


        [HttpPost]
        public JsonResult LoadConspectusDocumentType()
        {
            var getComsectus = _commonCodeService.GetValue1(Constants.Document.CommonTypeId, Constants.Document.Conspectus);

            var lstConspectus = DocumentTypeViewModel.Convert(getComsectus);
            return Json(new
            {
                status = 1,
                lstConspectus = lstConspectus,
            });
        }

        [HttpPost]
        public JsonResult LoadClassBySchool(long? schoolId)
        {
            try
            {
                if (schoolId == Constants.Document.All)
                {
                    schoolId = null;
                }
                var getClass = _classService.GetClassBySchoolId(schoolId);

                var lstClass = ClassViewModel.Convert(getClass);
                return Json(new
                {
                    status = 1,//Success
                    lstClass = lstClass
                });
            }
            catch
            {
                return Json(new
                {
                    status = 0, //Error
                });
            }
        }

        [HttpPost]
        public JsonResult SearchConspectusBySelectedLsit(string model, int pageNumber, int pageSize = 3)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                var renClass = serializer.Deserialize<SearchSelectedListViewModel>(model);
                if (renClass.Status == Constants.Document_Status.All)
                {
                    renClass.Status = null;
                }
                if (renClass.Type == Constants.Document.All.ToString())
                {
                    renClass.Type = null;
                }
                var count = 0;
                var getDocument = _documentService.SearchBySelectedList(renClass.Status, renClass.ClassId, Constants.Document.Conspectus, renClass.Type, renClass.FromDate, renClass.ToDate, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listClass = DocumentViewModel.Convert(getDocument);
                return Json(new
                {
                    status = true,
                    listClass = listClass,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult SearchConspectusByTying(string keyWord, int pageNumber, int pageSize = 3)
        {
            try
            {
                var count = 0;
                var getDocument = _documentService.SearchByTyping(keyWord, Constants.Document.Conspectus, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listDocument = DocumentViewModel.Convert(getDocument);
                return Json(new
                {
                    status = true,
                    listDocument = listDocument,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult SearchLessonByTying(string keyWord, int pageNumber, int pageSize = 3)
        {
            try
            {
                var count = 0;
                var getDocument = _documentService.SearchByTyping(keyWord, Constants.Document.LessonReferences, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listDocument = DocumentViewModel.Convert(getDocument);
                return Json(new
                {
                    status = true,
                    listDocument = listDocument,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }


        [HttpPost]
        public JsonResult SearchLessonBySelectedLsit(string model, int pageNumber, int pageSize = 3)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                var renClass = serializer.Deserialize<SearchSelectedListViewModel>(model);
                if (renClass.Status == Constants.Document_Status.All)
                {
                    renClass.Status = null;
                }
                if (renClass.Type == Constants.Document.All.ToString())
                {
                    renClass.Type = null;
                }
                var count = 0;
                var getDocument = _documentService.SearchBySelectedList(renClass.Status, renClass.ClassId, Constants.Document.LessonReferences, renClass.Type, renClass.FromDate, renClass.ToDate, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listClass = DocumentViewModel.Convert(getDocument);
                return Json(new
                {
                    status = true,
                    listClass = listClass,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult SearchExerciseBySelectedLsit(string model, int pageNumber, int pageSize = 3)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                var renClass = serializer.Deserialize<SearchSelectedListViewModel>(model);
                if (renClass.Status == Constants.Document_Status.All)
                {
                    renClass.Status = null;
                }
                if (renClass.Type == Constants.Document.All.ToString())
                {
                    renClass.Type = null;
                }
                var count = 0;
                var getDocument = _documentService.SearchBySelectedList(renClass.Status, renClass.ClassId, Constants.Document.Exercise, renClass.Type, renClass.FromDate, renClass.ToDate, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listClass = DocumentViewModel.Convert(getDocument);
                return Json(new
                {
                    status = true,
                    listClass = listClass,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }
        [HttpPost]

        public JsonResult SearchExerciseByTying(string keyWord, int pageNumber, int pageSize = 3)
        {
            try
            {
                var count = 0;
                var getDocument = _documentService.SearchByTyping(keyWord, Constants.Document.Exercise, pageNumber, pageSize, out count);
                if (count == 0)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                var listDocument = DocumentViewModel.Convert(getDocument);
                return Json(new
                {
                    status = true,
                    listDocument = listDocument,
                    total = count
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }
        }

        [HttpPost]
        public JsonResult getAssignmentConfig(long? docId, long? classId)
        {
            try
            {
                var getAgC = _assignmentConfigService.GetAssignmentConfig(docId, classId);

                var lstAgC = AssignmentConfigViewModel.Convert(getAgC);

                return Json(new
                {
                    status = 1,
                    lstAgC = lstAgC
                });
            }
            catch
            {
                return Json(new
                {
                    status = -1
                });
            }
        }

        #endregion
    }
}
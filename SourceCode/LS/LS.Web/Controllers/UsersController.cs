using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LS.Web.Controllers
{
    using BLL;
    using IBLL;
    using Models;
    using Utility;
    using Common;
    using Model;

    /// <summary>
    /// User controller
    /// </summary>
    public class UsersController : Controller
    {
        #region -- Propertites --

        private IStudentClassService _studentClassService = new StudentClassService();
        private IClassService _classService = new ClassService();
        private IStudentExerciseService _studentExerciseService = new StudentExerciseService();
        private IStudentService _studentService = new StudentService();

        #endregion

        #region -- View --

        [Route("User")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateProfile(string userId, string birthday, string address1, string fName, string lName, HttpPostedFileBase avt)
        {
            IUsersService usersService = new UsersService();
            var profileUpdate = usersService.GetById(userId);
            try
            {
                if (ModelState.IsValid)
                {
                    if (avt != null)
                    {
                        var year = DateTime.Now.Year.ToString();
                        var month = DateTime.Now.Hour.ToString();
                        var day = DateTime.Now.Day.ToString();
                        var hour = DateTime.Now.Hour.ToString();
                        var minute = DateTime.Now.Minute.ToString();
                        var milisecond = DateTime.Now.Millisecond.ToString();
                        var prefix = year + month + day + hour + minute + milisecond;
                        var fileName = Path.GetFileName(avt.FileName);
                        var pathFile = Constants.UserFront.DirSaveImagesUser;
                        var nameImage = prefix + "-" + fileName;
                        var path = Path.Combine(Server.MapPath(pathFile), nameImage);
                        avt.SaveAs(path);
                        profileUpdate.Avatar = nameImage;
                    }
                    if (!string.IsNullOrEmpty(birthday) && !string.IsNullOrEmpty(address1) && !string.IsNullOrEmpty(lName) && !string.IsNullOrEmpty(lName))
                    {
                        try
                        {
                            var bDay = DateTime.Parse(birthday);
                            profileUpdate.Birthday = bDay;
                            profileUpdate.Address1 = address1;
                            profileUpdate.FullName = fName + ";" + lName;
                            usersService.Update(profileUpdate);
                            var newUser = UserFrontVM.Convert(profileUpdate);
                            Session["IsLogin"] = newUser;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult ChangePassword(string model)
        {
            IUsersService usersService = new UsersService();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var renUser = serializer.Deserialize<ChangePassword>(model);
            if (renUser.UserId == null || renUser.OldPassword.Length < 6 || renUser.NewPassword.Length < 6)
            {
                return Json(new
                {
                    success = -3 // when UserId  or OldPassword  or NewPassword is null or <6 characters
                });
            }
            if (renUser.NewPassword != renUser.ConfirmPassword)
            {
                return Json(new
                {
                    success = -2 // NewPassword not equal to ConfirmPassword
                });
            }
            var hasOPWD = Encryption.GetMd5Hash(renUser.OldPassword);
            var res = usersService.GetById(renUser.UserId);
            var hasNPWD = Encryption.GetMd5Hash(renUser.NewPassword);
            if (res == null || res.Pwd != hasOPWD)
            {
                return Json(new
                {
                    success = -1 // Old Password was wrong
                });
            }
            try
            {
                res.Pwd = hasNPWD;
                usersService.Update(res);
                return Json(new
                {
                    success = 1
                });
            }
            catch
            {
                return Json(new
                {
                    success = 0 // A problem occured
                });
            }
        }

        [Route("User/Class")]
        public ActionResult MyClass()
        {
            return View();
        }

        [Route("User/DetailClass")]
        public ActionResult DetailClass(long? ClassId)
        {
            if (ClassId == null)
            {
                return null;
            }
            try
            {
                var getClass = ClassViewModel.Convert2(_classService.GetById(ClassId));
                return View(getClass);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region -- Create --

        [HttpPost]
        public ActionResult CreateStudentExercise()
        {
            try
            {
                var std = UserFrontVM.CurrentUser.StudentId;

                var js = new JavaScriptSerializer();
                var model = js.Deserialize<StudentExerciseViewModel>(Request.Params["obj"]);

                var cof = js.Deserialize<bool>(Request.Params["cofile"]);

                if (!cof)
                {
                    return Json(new { success = -2 });//there is not the file

                }
                var student = new StudentExcercise();

                student.Status = model.Status;
                student.AssignmentConfigId = model.AssignmentConfigId;
                student.ClassId = model.ClassId;
                student.DocumentId = model.DocumentId;
                student.CreatedOn = DateTime.Now;
                student.StudentId = model.StudentId;

                _studentExerciseService.Insert(student);

                var file = Request.Files[0];
                var year = DateTime.Now.Year.ToString();
                var month = DateTime.Now.Hour.ToString();
                var day = DateTime.Now.Day.ToString();
                var hour = DateTime.Now.Hour.ToString();
                var minute = DateTime.Now.Minute.ToString();

                var milisecond = DateTime.Now.Millisecond.ToString();
                var prefix = year + month + day + hour + minute + milisecond;
                var fileExtension = Path.GetExtension(file.FileName);
                var pathFile = Constants.StudentExercise.DirSaveExercise;
                var nameFile = student.Id + "_" + prefix + fileExtension;
                var exit = Directory.Exists(Server.MapPath(pathFile));
                if (!exit)
                {
                    Directory.CreateDirectory(Server.MapPath(pathFile));
                }
                var path = Path.Combine(Server.MapPath(pathFile), nameFile);
                file.SaveAs(path);
                student.Link = Constants.StudentExercise.DirExercise + nameFile;
                student.FileName = nameFile;
                student.FileExtension = fileExtension;

                _studentExerciseService.Update(student);

                _studentExerciseService.Update(student);
                return Json(new { success = 1 }); //success
            }
            catch
            {
                return Json(new { success = -1 });//cant connect to server
            }
        }

        #endregion

        #region -- Helper --

        [HttpPost]
        public JsonResult StudyingSubjects()
        {

            try
            {
                var count = 0;
                var subject = _studentClassService.SearchByStudentId(1, 1, 100, out count);//Demo with StudentId = 1
                if (count == 0)
                {
                    return Json(new { status = 0 });// When the user does not have any class
                }
                var lstSubject = StudentClassViewModel.Convert(subject);
                return Json(new { status = 1, lstSubject = lstSubject, total = count }); //success
            }
            catch
            {
                return Json(new { status = -1 });//cant connect to server
            }

            //return Json(new { status = -1 });
        }

        [HttpPost]
        public JsonResult StudiedSubjects()
        {

            try
            {
                var count = 0;
                var subject = _studentClassService.SearchByStudentId2(1, 1, 100, out count); //Demo with StudentId =1 
                if (count == 0)
                {
                    return Json(new { status = 0 });// When the user does not have any class
                }
                var lstSubject = StudentClassViewModel.Convert(subject);
                return Json(new { status = 1, lstSubject = lstSubject, total = count }); //success
            }
            catch
            {
                return Json(new { status = -1 });//cant connect to server
            }

            //return Json(new { status = -1 });//cant connect to server

        }

        #endregion
    }
}
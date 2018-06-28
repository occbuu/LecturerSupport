using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using IBLL;
    using Model;
    using Utility;

    public class StudentClassService : Repository<StudentClass>, IStudentClassService
    {
        /// <summary>
        /// Get a list of student's class that is studying
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<StudentClass> SearchByStudentId(long? studentId, int pageNumber, int pageSize, out int count)
        {
            var lstStudentClass = new List<StudentClass>();
            IQueryable<StudentClass> temp = null;
            if (studentId != null)
            {
                DateTime? dateTimeNow = DateTime.Now;
                temp = SearchFor2(x => x.StudentId == studentId && x.Status != Constants.Class_Status.DeleteStatus && (x.Class.StartDate <= dateTimeNow && x.Class.EndDate >= dateTimeNow));
                count = temp.Count();
                lstStudentClass = temp.OrderByDescending(x => x.Class.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                lstStudentClass = null;
                count = 0;
            }
            return lstStudentClass;
        }

        /// <summary>
        /// Get a list of Student's Class that was studied
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<StudentClass> SearchByStudentId2(long? studentId, int pageNumber, int pageSize, out int count)
        {
            var lstStudentClass = new List<StudentClass>();
            IQueryable<StudentClass> temp = null;
            if (studentId != null)
            {
                DateTime? dateTimeNow = DateTime.Now;
                temp = SearchFor2(x => x.StudentId == studentId && x.Status != Constants.Class_Status.DeleteStatus && (x.Class.EndDate <= dateTimeNow));
                count = temp.Count();
                lstStudentClass = temp.OrderByDescending(x => x.Class.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                lstStudentClass = null;
                count = 0;
            }
            return lstStudentClass;
        }

        /// <summary>
        /// Search by ClassId to get a list of StudentClass
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<StudentClass> SearchByClassId(long? classId,int pageNumber, int pageSize, out int count)
        {
            var lstStudentClass = new List<StudentClass>();
            IQueryable<StudentClass> temp = null;
            if (classId != null)
            {
                temp = SearchFor2(x => x.ClassId == classId && x.Status != Constants.Class_Status.DeleteStatus);
                count = temp.Count();
                lstStudentClass = temp.OrderBy(x=>x.Student.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            }
            else
            {
                lstStudentClass = null;
                count = 0;
            }
            return lstStudentClass;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using IBLL;
    using Model;
    using Utility;

    public class CourseScoreService : Repository<CourseScore>, ICourseScoreService
    {
        /// <summary>
        /// Get a list Course Score of a class
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<CourseScore> GetCourseScoreByClassId(long? classId, out int count)
        {
            var lstCourse = new List<CourseScore>();
            IQueryable<CourseScore> temp = null;
            temp = SearchFor2(x => x.ClassId == classId && x.Status != Constants.CourseScore_Status.DeleteStatus);
            count = temp.Count();
            lstCourse = temp.ToList();
            return lstCourse;
        }
    }
}
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ICourseScoreService : IRepository<CourseScore>
    {
        List<CourseScore> GetCourseScoreByClassId(long? classId, out int count);

    }
}
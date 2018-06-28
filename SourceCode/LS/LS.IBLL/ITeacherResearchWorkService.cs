using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ITeacherResearchWorkService : IRepository<TeacherResearchWork>
    {
        List<TeacherResearchWork> SearchType(string type, int pageNumber, int pageSize, out int count);

        List<TeacherResearchWork> SearchType(string type);
    }
}
using System.Collections.Generic;

namespace LS.IDAL
{
    using Model;

    public interface ITeacherDao : IRepository<Teacher>
    {
        List<Teacher> SearchTeacher(string keyWord, string gender, int pageNumber, int pageSize, out int recordCount);
    }
}
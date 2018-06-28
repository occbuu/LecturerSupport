using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ITeacherService : IRepository<Teacher>
    {
        List<Teacher> SearchByFullName(string fullName);

        List<Teacher> SearchTeacher(string keyWord, string gender, int pageNumber, int pageSize, out int recordCount);

        void DelteTeacher(List<string> lstId);
    }
}
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface IStudentClassService : IRepository<StudentClass>
    {
        List<StudentClass> SearchByStudentId(long? studentId, int pageNumber, int pageSize, out int count);
        List<StudentClass> SearchByStudentId2(long? studentId, int pageNumber, int pageSize, out int count);
        List<StudentClass> SearchByClassId(long? classId,int pageNumber, int pageSize, out int count);
    }
}
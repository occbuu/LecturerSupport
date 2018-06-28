using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface IStudentService : IRepository<Student>
    {
        long? getSudentIdByObjectId(string objectId);

        List<Student> getStudentBySchool(long schoolId);
    }
}
using System.Linq;
using System.Collections.Generic;

namespace LS.BLL
{
    using IBLL;
    using Model;
    using IDAL;
    using DAL;

    public class StudentService : Repository<Student>, IStudentService
    {
        private IStudentDao _studentDao = new StudentDao();

        public List<Student> getStudentBySchool(long schoolId)
        {
            var lst = _studentDao.SearchFor2(p => p.SchoolId == schoolId).ToList();
            return lst;
        }

        public long? getSudentIdByObjectId(string objectId)
        {
            var student = _studentDao.getStudentByObjectId(objectId);
            if (student != null)
            {
                var studentId = student.Id;
                return studentId;
            }
            return null;
        }
    }
}
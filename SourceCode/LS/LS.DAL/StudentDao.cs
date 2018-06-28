using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.DAL
{
    using Model;
    using IDAL;

    public class StudentDao : Repository<Student> , IStudentDao
    {
       public Student getStudentByObjectId(string objectId)
        {
            var student = SearchFor2(x => x.ObjectId == objectId).FirstOrDefault();
            return student ;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.IDAL
{
    using Model;

    public interface IStudentDao : IRepository<Student>
    {
        Student getStudentByObjectId(string objectId);

    }
}
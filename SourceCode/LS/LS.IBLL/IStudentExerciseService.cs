using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.IBLL
{
    using Model;

    public interface IStudentExerciseService : IRepository<StudentExcercise>
    {
        List<StudentExcercise> GetStudentExercise(long? docId, long? classId, int pageNumber, int pageSize, out int count);

    }
}
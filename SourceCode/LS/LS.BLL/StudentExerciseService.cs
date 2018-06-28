using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.BLL
{
    using IBLL;
    using Model;

    public class StudentExerciseService : Repository<StudentExcercise>, IStudentExerciseService
    {
        public List<StudentExcercise> GetStudentExercise(long? docId, long? classId, int pageNumber, int pageSize, out int count)
        {
            var lstStudentExercise = new List<StudentExcercise>();
            IQueryable<StudentExcercise> temp = null;
            if (docId != null && classId != null)
            {
                temp = SearchFor2(x => x.DocumentId == docId && x.ClassId == classId);
                count = temp.Count();
                lstStudentExercise = temp.OrderByDescending(x => x.CreatedOn).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            count = 0;
            return lstStudentExercise;
        }
    }
}
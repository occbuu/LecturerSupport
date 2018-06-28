using System.Collections.Generic;
using System.Linq;

namespace LS.DAL
{
    using IDAL;
    using Model;

    public class TeacherDao : Repository<Teacher>, ITeacherDao
    {
        public List<Teacher> SearchTeacher(string keyWord, string gender, int pageNumber, int pageSize, out int recordCount)
        {
            var data = new List<Teacher>();
            recordCount = 0;

            var listtemp = this.SearchFor2(x =>
            (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.FullName.Contains(keyWord)))
            && (string.IsNullOrEmpty(gender) || (!string.IsNullOrEmpty(gender) && x.Gender == gender)));

            recordCount = listtemp.Count();
            data = listtemp
                .OrderByDescending(b => b.CreatedDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return data;
        }
    }
}
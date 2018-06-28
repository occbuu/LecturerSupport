using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using IBLL;
    using IDAL;
    using DAL;
    using Model;

    public class UniversityService : Repository<University>, IUniversityService
    {
        private IUniversityDao UniversityDao = new UniversityDao();

        /// <summary>
        /// Search to get a list of University by keyWord, Id
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="id"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<University> Search(string keyWord, long? id, int pageNum, int pageSize, out int count)
        {
            var lstUniversity = new List<University>();
            IQueryable<University> temp;
            if ((!string.IsNullOrEmpty(keyWord)) && id != null)
            {
                temp = SearchFor2(x => (x.Id == id) && (x.Name.Contains(keyWord)));
                count = temp.Count();
                lstUniversity = temp.Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                if (string.IsNullOrEmpty(keyWord) && id == null)
                {
                    count = GetAll().Count();
                    lstUniversity = GetAll().Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        temp = SearchFor2(x => x.Id == id);
                        count = temp.Count();
                        lstUniversity = temp.Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();
                    }
                    else
                    {
                        temp = SearchFor2(x => x.Name.Contains(keyWord));
                        count = temp.Count();
                        lstUniversity = temp.Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();
                    }
                }
            }
            return lstUniversity;
        }
    }
}
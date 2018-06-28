using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.SqlServer;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;
    using Utility;

    public class ClassService : Repository<Class>, IClassService
    {
        private IClassDao ClassDao = new ClassDao();

        /// <summary>
        /// Search ExcelsClass
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Class> ExcelsClass(string keyWord, DateTime? ftt, DateTime? ttt, string id)
        {
            var data = new List<Class>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Name.Contains(keyWord)))

                            && (x.CreatedOn.Value.CompareTo(ftt.Value) >= 0 && x.CreatedOn.Value.CompareTo(ttt.Value) <= 0)
                        );
            }
            else
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Name.Contains(keyWord)))

                        );
            }
            return data;
        }


        /// <summary>
        /// Seach Class to get list by keyWord, ftt(from time), ttt(to time)
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="id"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Class> Search(string keyWord, DateTime? ftt, DateTime? ttt, string id, int pageNumber, int pageSize, out int count)
        {
            List<Class> lstClass = new List<Class>();
            IQueryable<Class> temp;
            if (ftt != null && ttt != null)
            {
                // Search from X time to Y time
                temp = SearchFor2(x =>
                           ((x.Name.Contains(keyWord))
                           || (SqlFunctions.StringConvert((double)x.Id).Contains(keyWord)))
                           && (x.StartDate >= ftt && x.StartDate <= ttt)
                    );
                count = temp.Count();
                lstClass = temp.OrderByDescending(x => x.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                var nowDateTime = DateTime.Parse(DateTime.Now.ToString()); // get DateTime now to search StartDate <= nowDateTime >= EndDate
                temp = this.SearchFor2(x =>
                          ((x.CreatedBy.Contains(keyWord))
                          || (x.Name.Contains(keyWord))
                          || (SqlFunctions.StringConvert((double)x.Id).Contains(keyWord)))
                          && (x.StartDate <= nowDateTime && x.EndDate >= nowDateTime)
                    );
                count = temp.Count();
                lstClass = temp.OrderByDescending(x => x.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            return lstClass;
        }

        /// <summary>
        /// Search Class to get a old list when comparing Datetime now
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="id"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Class> SearchOlder(string keyWord, string id, int pageNumber, int pageSize, out int count)
        {
            List<Class> lstClass = new List<Class>();
            IQueryable<Class> temp;
            var nowDateTime = DateTime.Parse(DateTime.Now.ToString()); // get DateTime now to search StartDate <= nowDateTime >= EndDate
            temp = this.SearchFor2(x =>
                      ((x.CreatedBy.Contains(keyWord))
                      || (x.Name.Contains(keyWord))
                      || (SqlFunctions.StringConvert((double)x.Id).Contains(keyWord)))
                      && (x.EndDate <= nowDateTime)
                );
            count = temp.Count();
            lstClass = temp.OrderByDescending(x => x.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return lstClass;
        }

        /// <summary>
        /// Search by category with status, shcoolId
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="id"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Class> SearchBySelectedList(string status, long? schoolId, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int count)
        {
            var lstClass = new List<Class>();
            IQueryable<Class> temp;
            if (ftt != null && ttt != null)
            {
                if (status == null && schoolId == null)
                {
                    temp = SearchFor2(x => x.StartDate >= ftt && x.EndDate <= ttt);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    if (status == null)
                    {
                        temp = SearchFor2(x => x.StartDate >= ftt && x.EndDate <= ttt && x.UniversityId == schoolId);
                        count = temp.Count();
                        lstClass = temp.OrderByDescending(x => x.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                    }
                    else
                    {
                        if (schoolId == null)
                        {
                            temp = SearchFor2(x => x.StartDate >= ftt && x.EndDate <= ttt && x.Status == status);
                            count = temp.Count();
                            lstClass = temp.OrderByDescending(x => x.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                        }
                        else
                        {
                            temp = SearchFor2(x => x.StartDate >= ftt && x.EndDate <= ttt && x.Status == status && x.UniversityId == schoolId);
                            count = temp.Count();
                            lstClass = temp.OrderByDescending(x => x.StartDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                        }
                    }
                }
                // Search from X time to Y time

            }
            else
            {
                if (status == null && schoolId == null)
                {
                    temp = SearchFor2(x => true);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    if (status == null)
                    {
                        temp = SearchFor2(x => x.UniversityId == schoolId);
                        count = temp.Count();
                        lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                    }
                    else
                    {
                        if (schoolId == null)
                        {
                            temp = SearchFor2(x => x.Status == status);
                            count = temp.Count();
                            lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                        }
                        else
                        {
                            temp = SearchFor2(x => x.Status == status && x.UniversityId == schoolId);
                            count = temp.Count();
                            lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                        }
                    }
                }
            }
            return lstClass;
        }

        public List<Class> SearchByTyping(string keyWord, int pageNumber, int pageSize, out int count)
        {
            var lstClass = new List<Class>();
            IQueryable<Class> temp;
            count = 0;
            if (keyWord != null)
            {
                temp = SearchFor2(x => x.Name.Contains(keyWord) || x.Code.Contains(keyWord) || x.Id.ToString() == keyWord || x.Subject.SubjectName.Contains(keyWord));
                count = temp.Count();
                lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            return lstClass;
        }

        /// <summary>
        /// Get a list of class by schoolId
        /// </summary>
        /// <param name="schoolId"></param>
        /// <returns></returns>
        public List<Class> GetClassBySchoolId(long? schoolId)
        {
            var lstClass = new List<Class>();
            IQueryable<Class> temp;
            if(schoolId!=null)
            {
                temp = SearchFor2(x=>x.UniversityId==schoolId && x.Status!=Constants.Class_Status.DeleteStatus);
                lstClass = temp.ToList();
            }
            else
            {
                temp = SearchFor2(x => true && x.Status != Constants.Class_Status.DeleteStatus);
                lstClass = temp.ToList();
            }
            return lstClass;
        }
    }
}
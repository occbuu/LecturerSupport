using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;

    public class ScheduleService : Repository<Schedule>, IScheduleService
    {
        private IScheduleDao ScheduleDao = new ScheduleDao();

        /// <summary>
        /// Search to get a list of Schedule by ftt(from time), ttt(to time), SchoolId
        /// </summary>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="schoolId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Schedule> SearchBySchool(DateTime? ftt, DateTime? ttt, long? schoolId, int pageNumber, int pageSize, out int count)
        {
            List<Schedule> lstClass = new List<Schedule>();
            IQueryable<Schedule> temp;
            if (ftt != null && ttt != null)
            {
                // Search from X time to Y time
                if (schoolId != null)
                {
                    temp = SearchFor2(x => (x.Date >= ftt && x.Date <= ttt) && x.UniversityId == schoolId);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    temp = SearchFor2(x => (x.Date >= ftt && x.Date <= ttt));
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
            }
            else
            {
                if (schoolId != null)
                {
                    temp = SearchFor2(x => x.UniversityId == schoolId);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    temp = SearchFor2(x => x.Date != null);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
            }
            return lstClass.ToList();
        }

        public List<Schedule> SearchByClassId(DateTime? ftt, DateTime? ttt, long? classlId, int pageNumber, int pageSize, out int count)
        {
            List<Schedule> lstClass = new List<Schedule>();
            IQueryable<Schedule> temp;
            if (ftt != null && ttt != null)
            {
                // Search from X time to Y time
                if (classlId != null)
                {
                    temp = SearchFor2(x => (x.Date >= ftt && x.Date <= ttt) && x.ClassId == classlId);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    temp = SearchFor2(x => (x.Date >= ftt && x.Date <= ttt));
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
            }
            else
            {
                if (classlId != null)
                {
                    temp = SearchFor2(x => x.ClassId == classlId);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    temp = SearchFor2(x => true);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Date).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
            }
            return lstClass.ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.BLL
{
    using System.Linq.Expressions;
    using IBLL;
    using Model;
    using IDAL;
    using DAL;

    public class TeacherResearchWorkService : ITeacherResearchWorkService
    {
        private ITeacherResearchWorkDao _teacherResearchWorkDao = new TeacherResearchWorkDao();

        public void Delete(TeacherResearchWork entity)
        {
            _teacherResearchWorkDao.Delete(entity);
        }

        public List<TeacherResearchWork> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _teacherResearchWorkDao.ExecuteSQLQuery(query, parameters);
        }

        public List<TeacherResearchWork> GetAll()
        {
            return _teacherResearchWorkDao.GetAll();
        }

        public TeacherResearchWork GetById(object id)
        {
            return _teacherResearchWorkDao.GetById(id);
        }

        public void Insert(TeacherResearchWork entity)
        {
            _teacherResearchWorkDao.Insert(entity);
        }

        public List<TeacherResearchWork> SearchFor(Expression<Func<TeacherResearchWork, bool>> predicate)
        {
            return _teacherResearchWorkDao.SearchFor(predicate);
        }

        public IQueryable<TeacherResearchWork> SearchFor2(Expression<Func<TeacherResearchWork, bool>> predicate)
        {
            return _teacherResearchWorkDao.SearchFor2(predicate);
        }

        public void Update(TeacherResearchWork entity)
        {
            _teacherResearchWorkDao.Update(entity);
        }

        public List<TeacherResearchWork> SearchType(string type, int pageNumber, int pageSize, out int count)
        {
            var lstType = new List<TeacherResearchWork>();
            var temp = this.SearchFor2(x => x.Type == type)
                .OrderByDescending(x => x.Time);
            count = temp.Count();
            lstType = temp.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return lstType.ToList();
        }

        public List<TeacherResearchWork> SearchType(string type)
        {
            return _teacherResearchWorkDao.SearchFor2(e=> e.Type == type).ToList();
        }
    }
}

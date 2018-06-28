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
    using DAL;
    using IDAL;

    public class TeacherBackgroundService : ITeacherBackgroundService
    {
        private ITeacherBackgroundDao _teacherBackgroundDao = new TeacherBackgroundDao();

        public void Delete(TeacherBackground entity)
        {
            _teacherBackgroundDao.Delete(entity);
        }

        public List<TeacherBackground> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _teacherBackgroundDao.ExecuteSQLQuery(query, parameters);
        }

        public List<TeacherBackground> GetAll()
        {
            return _teacherBackgroundDao.GetAll();
        }

        public TeacherBackground GetById(object id)
        {
            return _teacherBackgroundDao.GetById(id);
        }

        public void Insert(TeacherBackground entity)
        {
            _teacherBackgroundDao.Insert(entity);
        }

        public List<TeacherBackground> SearchByType(string type)
        {
            return _teacherBackgroundDao.SearchFor2(t => t.Type == type).ToList();
        }

        public List<TeacherBackground> SearchFor(Expression<Func<TeacherBackground, bool>> predicate)
        {
            return _teacherBackgroundDao.SearchFor(predicate);
        }

        public IQueryable<TeacherBackground> SearchFor2(Expression<Func<TeacherBackground, bool>> predicate)
        {
            return _teacherBackgroundDao.SearchFor2(predicate);
        }

        public void Update(TeacherBackground entity)
        {
            _teacherBackgroundDao.Update(entity);
        }
    }
}

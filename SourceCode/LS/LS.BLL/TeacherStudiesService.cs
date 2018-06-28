using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using System.Linq.Expressions;
    using IBLL;
    using Model;
    using IDAL;
    using DAL;

    public class TeacherStudiesService : ITeacherStudiesService
    {
        private ITeacherStudiesDao _teacherStudiesDao = new TeacherStudiesDao();

        public void Delete(TeacherStudy entity)
        {
            _teacherStudiesDao.Delete(entity);
        }

        public List<TeacherStudy> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _teacherStudiesDao.ExecuteSQLQuery(query, parameters);
        }

        public List<TeacherStudy> GetAll()
        {
            return _teacherStudiesDao.GetAll();
        }

        public TeacherStudy GetById(object id)
        {
            return _teacherStudiesDao.GetById(id);
        }

        public void Insert(TeacherStudy entity)
        {
            _teacherStudiesDao.Insert(entity);
        }

        public List<TeacherStudy> SearchFor(Expression<Func<TeacherStudy, bool>> predicate)
        {
            return _teacherStudiesDao.SearchFor(predicate);
        }

        public IQueryable<TeacherStudy> SearchFor2(Expression<Func<TeacherStudy, bool>> predicate)
        {
            return _teacherStudiesDao.SearchFor2(predicate);
        }

        public void Update(TeacherStudy entity)
        {
            _teacherStudiesDao.Update(entity);
        }
    }
}

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

    public class TeacherDelegateStudentService : ITeacherDelegateStudentService
    {
        private ITeacherDelegateDao _teacherDelegateDao = new TeacherDelegateDao();

        public void Delete(TeacherDelegateStudent entity)
        {
            _teacherDelegateDao.Delete(entity);
        }

        public List<TeacherDelegateStudent> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _teacherDelegateDao.ExecuteSQLQuery(query, parameters);
        }

        public List<TeacherDelegateStudent> GetAll()
        {
            return _teacherDelegateDao.GetAll();
        }

        public TeacherDelegateStudent GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TeacherDelegateStudent entity)
        {
            _teacherDelegateDao.Insert(entity);
        }

        public List<TeacherDelegateStudent> SearchFor(Expression<Func<TeacherDelegateStudent, bool>> predicate)
        {
            return _teacherDelegateDao.SearchFor(predicate);
        }

        public IQueryable<TeacherDelegateStudent> SearchFor2(Expression<Func<TeacherDelegateStudent, bool>> predicate)
        {
           return _teacherDelegateDao.SearchFor2(predicate);
        }

        public void Update(TeacherDelegateStudent entity)
        {
            _teacherDelegateDao.Update(entity);
        }
    }
}

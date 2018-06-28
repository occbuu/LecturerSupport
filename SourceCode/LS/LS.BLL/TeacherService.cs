using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;

    public class TeacherService : ITeacherService
    {
        private ITeacherDao _teacherDao = new TeacherDao();

        public List<Teacher> GetAll()
        {
            return _teacherDao.GetAll();
        }

        public Teacher GetById(object id)
        {
            return _teacherDao.GetById(id);
        }

        public void Insert(Teacher entity)
        {
            _teacherDao.Insert(entity);
        }

        public void Update(Teacher entity)
        {
            _teacherDao.Update(entity);
        }

        public void Delete(Teacher entity)
        {
            _teacherDao.Delete(entity);
        }

        public List<Teacher> SearchFor(Expression<Func<Teacher, bool>> predicate)
        {
            return _teacherDao.SearchFor(predicate);
        }

        public IQueryable<Teacher> SearchFor2(Expression<Func<Teacher, bool>> predicate)
        {
            return _teacherDao.SearchFor2(predicate);
        }

        public List<Teacher> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _teacherDao.ExecuteSQLQuery(query, parameters);
        }

        public List<Teacher> SearchByFullName(string fullName)
        {
            return _teacherDao.SearchFor2(t => t.FullName == fullName).ToList();
        }

        public List<Teacher> SearchTeacher(string keyWord, string gender, int pageNumber, int pageSize, out int recordCount)
        {
            return _teacherDao.SearchTeacher(keyWord, gender, pageNumber, pageSize, out recordCount);
        }

        public void DelteTeacher(List<string> lstId)
        {
            using (var tran = new TransactionScope())
            {
                if (lstId.Count() > 0)
                {
                    foreach (var item in lstId)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            long id = long.Parse(item);
                            Teacher teacher = _teacherDao.SearchFor(x => x.Id == id).FirstOrDefault();
                            if (teacher.Owner != "1")
                            {
                                _teacherDao.Delete(teacher);
                            }
                        }
                    }
                }
                tran.Complete();
            }
        }
    }
}
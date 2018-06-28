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

    public class TeacherMemoryService : ITeacherMemoryService
    {
        private ITeacherMemoryDao _teacherMemoryDao = new TeacherMemoryDao();

        public void Delete(TeacherMemory entity)
        {
           _teacherMemoryDao.Delete(entity);
        }

        public List<TeacherMemory> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _teacherMemoryDao.ExecuteSQLQuery(query, parameters);
        }

        public List<TeacherMemory> GetAll()
        {
            return _teacherMemoryDao.GetAll();
        }

        public TeacherMemory GetById(object id)
        {
            return _teacherMemoryDao.GetById(id);
        }

        public void Insert(TeacherMemory entity)
        {
            _teacherMemoryDao.Insert(entity);
        }

        public List<TeacherMemory> SearchByType(string type)
        {
            return _teacherMemoryDao.SearchFor2(t=> t.Type == type).ToList();
        }

        public List<TeacherMemory> SearchFor(Expression<Func<TeacherMemory, bool>> predicate)
        {
            return _teacherMemoryDao.SearchFor(predicate);
        }

        public IQueryable<TeacherMemory> SearchFor2(Expression<Func<TeacherMemory, bool>> predicate)
        {
            return _teacherMemoryDao.SearchFor2(predicate);
        }

        public void Update(TeacherMemory entity)
        {
            _teacherMemoryDao.Update(entity);
        }
    }
}

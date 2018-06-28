using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LS.BLL
{
    using IBLL;
    //using LS.Utility;

    public class Repository<T> : IRepository<T> where T : class
    {
        private IDAL.IRepository<T> IRepositoryDao = new DAL.Repository<T>();
        public void Delete(T entity)
        {
            IRepositoryDao.Delete(entity);
        }


        public List<T> ExecuteSQLQuery(string query, object[] parameters)
        {
            return IRepositoryDao.ExecuteSQLQuery(query, parameters);
        }

        public List<T> GetAll()
        {
            return IRepositoryDao.GetAll();
        }

        public T GetById(object id)
        {
            return IRepositoryDao.GetById(id);
        }

        public void Insert(T entity)
        {
            IRepositoryDao.Insert(entity);
        }

        public List<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return IRepositoryDao.SearchFor(predicate);
        }

        public IQueryable<T> SearchFor2(Expression<Func<T, bool>> predicate)
        {
            return IRepositoryDao.SearchFor2(predicate);
        }

        public void Update(T entity)
        {
            IRepositoryDao.Update(entity);
        }
    }
}
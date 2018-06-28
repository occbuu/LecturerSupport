using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LS.IDAL
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        T GetById(object id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> SearchFor2(Expression<Func<T, bool>> predicate);
        List<T> ExecuteSQLQuery(string query, object[] parameters);
    }
}
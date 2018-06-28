using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class CommonTypeService : ICommonTypeService
    {
        private ICommonTypeDao CommonTypeDao = new CommonTypeDao();

        public List<CommonType> GetAll()
        {
            return CommonTypeDao.GetAll();
        }

        public CommonType GetById(object id)
        {
            return CommonTypeDao.GetById(id);
        }

        public void Insert(CommonType entity)
        {
            CommonTypeDao.Insert(entity);
        }

        public void Update(CommonType entity)
        {
            CommonTypeDao.Update(entity);
        }

        public void Delete(CommonType entity)
        {
            CommonTypeDao.Delete(entity);
        }

        public List<CommonType> SearchFor(System.Linq.Expressions.Expression<Func<CommonType, bool>> predicate)
        {
            return CommonTypeDao.SearchFor(predicate);
        }

        public IQueryable<CommonType> SearchFor2(System.Linq.Expressions.Expression<Func<CommonType, bool>> predicate)
        {
            return CommonTypeDao.SearchFor2(predicate);
        }

        public List<CommonType> ExecuteSQLQuery(string query, object[] parameters)
        {
            return CommonTypeDao.ExecuteSQLQuery(query, parameters);
        }

        public List<CommonType> SearchByCommonTypeId(string commonType)
        {
            return SearchFor2(t => t.CommonTypeId.Contains(commonType)).ToList();
        }

        public List<CommonType> SearchByDescription(string description)
        {
            return SearchFor2(t => t.Description.Contains(description)).ToList();
        }
    }
}
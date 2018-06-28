using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;
    using Utility;

    public class CommonCodeService : ICommonCodeService
    {
        private ICommonCodeDao _commonCodeDao = new CommonCodeDao();

        public List<CommonCode> GetAll()
        {
            return _commonCodeDao.GetAll();
        }

        public CommonCode GetById(object id)
        {
            return _commonCodeDao.GetById(id);
        }

        public void Insert(CommonCode entity)
        {
            _commonCodeDao.Insert(entity);
        }

        public void Update(CommonCode entity)
        {
            _commonCodeDao.Update(entity);
        }

        public void Delete(CommonCode entity)
        {
            _commonCodeDao.Delete(entity);
        }

        public List<CommonCode> SearchFor(System.Linq.Expressions.Expression<Func<CommonCode, bool>> predicate)
        {
            return _commonCodeDao.SearchFor(predicate);
        }

        public IQueryable<CommonCode> SearchFor2(System.Linq.Expressions.Expression<Func<CommonCode, bool>> predicate)
        {
            return _commonCodeDao.SearchFor2(predicate);
        }

        public List<CommonCode> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _commonCodeDao.ExecuteSQLQuery(query, parameters);
        }

        /// <summary>
        /// Get category by type
        /// </summary>
        /// <param name="type">Common type id</param>
        /// <returns>List category</returns>
        public List<CommonCode> GetCategoryId(string type)
        {
            try
            {
                var listResult = new List<CommonCode>();
                var list = _commonCodeDao.SearchFor2(x => x.CommonTypeId == Constants.InfoType.NewsCategory && x.CommonId.Contains(type)).ToList();
                for (var i = 0; i < list.Count(); i++)
                {
                    var dem = list[i].CommonId.Count(t => t == '-');
                    if (dem == 1)
                    {
                        listResult.Add(list[i]);
                    }
                }

                if (listResult != null)
                {
                    return listResult;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get children category by common id
        /// </summary>
        /// <param name="commonId"> Common id</param>
        /// <returns>List children Category </returns>
        public List<CommonCode> GetCategoryIdChild(string commonId)
        {
            try
            {
                var listResult = new List<CommonCode>();
                var list = _commonCodeDao.SearchFor2(x => x.CommonId.Contains(commonId)).ToList();
                for (var i = 0; i < list.Count(); i++)
                {
                    var dem = list[i].CommonId.Count(t => t == '-');
                    if (dem == 2)
                    {
                        listResult.Add(list[i]);
                    }
                }

                if (listResult != null)
                {
                    return listResult;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CommonCode> SearchParentCommonIdByCommonTypeId(string commonTypeId, decimal level)
        {
            return SearchFor2(c => c.CommonTypeId == commonTypeId && c.NumValue1 == level).ToList();
        }

        public List<CommonCode> GetCommonTypeId()
        {
            try
            {
                var lstCommonTypeId = new List<CommonCode>();
                foreach (var result in GetAll())
                {
                    if (result.CommonTypeId == Constants.InfoType.SiteInfoHome)
                    {
                        lstCommonTypeId.Add(result);
                    }
                }
                if (lstCommonTypeId != null)
                {
                    return lstCommonTypeId;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CommonCode> SearchByStrValue(string value)
        {
            return SearchFor2(t => t.StrValue1.Contains(value)).ToList();
        }

        public List<CommonCode> SearchByCommonTypeId(string commonTypeId)
        {
            var lstCommonTypeId = SearchFor2(t => t.CommonTypeId.Contains(commonTypeId)).ToList();
            return lstCommonTypeId.Select(p => p.CommonTypeId.Distinct()).OfType<CommonCode>().ToList();
        }

        /// <summary>
        /// Get string value 1 by category id
        /// </summary>
        /// <param name="commonId">Category id</param>
        /// <param name="commonTypeId">Common type id</param>
        /// <returns></returns>
        public string getStrValue1(string commonId, string commonTypeId)
        {
            try
            {
                var res = SearchFor2(x => x.CommonId == commonId && x.CommonTypeId == commonTypeId).FirstOrDefault();
                if (res != null)
                {
                    return res.StrValue1;
                }

                return string.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CommonCode> SearchByCommonIdAndCommonType(string commonId, string commonTypeId)
        {
            return _commonCodeDao.SearchFor2(x => x.CommonId == commonId && x.CommonTypeId == commonTypeId).ToList();
        }

        public List<CommonCode> SearchByCommonIdAndCommonTypeWithPagination(string commonId, string commonTypeId, int pageNumber, int pageSize, out int count)
        {
            try
            {
                var lstNewsCategory = new List<CommonCode>();
                var charCount = commonId.Count(t => t == '-');
                if (charCount == 2)
                {
                    commonId = commonId.Substring(0, commonId.Count() - 2);
                    var temp = this.SearchFor2(x => x.CommonId.Contains(commonId) && x.CommonTypeId == commonTypeId).OrderByDescending(x => x.CreatedDate).ToList();
                    for (var i = 0; i < temp.Count(); i++)
                    {
                        var dem = temp[i].CommonId.Count(t => t == '-');
                        if (dem == 2)
                        {
                            lstNewsCategory.Add(temp[i]);
                        }
                    }
                    count = lstNewsCategory.Count();
                    lstNewsCategory = lstNewsCategory.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    commonId = commonId.Substring(0, commonId.Count() - 1);
                    var temp = this.SearchFor2(x => x.CommonId.Contains(commonId) && x.CommonTypeId == commonTypeId).OrderByDescending(x => x.CreatedDate).ToList();
                    for (var i = 0; i < temp.Count(); i++)
                    {
                        var dem = temp[i].CommonId.Count(t => t == '-');
                        if (dem == 1)
                        {
                            lstNewsCategory.Add(temp[i]);
                        }
                    }
                    count = lstNewsCategory.Count();
                    lstNewsCategory = lstNewsCategory.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                return lstNewsCategory.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CommonCode> GetCommonChildByCommonParent(string commonParent)
        {
            var lstChildCommon = new List<CommonCode>();
            try
            {
                lstChildCommon = _commonCodeDao.SearchFor2(s => s.CommonId.Contains(commonParent) && s.NumValue1 == 2).OrderByDescending(x => x.CreatedDate).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstChildCommon;
        }

        /// <summary>
        /// Get a list of common code by commonTypeId and commonId
        /// </summary>
        /// <param name="commonTypeId"></param>
        /// <param name="commonId"></param>
        /// <returns></returns>
        public List<CommonCode> GetValue1(string commonTypeId, string commonId)
        {
            var lstCommonCode = new List<CommonCode>();
            IQueryable<CommonCode> temp = null;
            if (commonTypeId != null && commonId != null)
            {
                temp = SearchFor2(x => x.CommonTypeId == commonTypeId && x.CommonId.Contains(commonId) && x.NumValue1 != 1);
                lstCommonCode = temp.ToList();
            }
            return lstCommonCode;
        }

        public List<CommonCode> GetListPostType()
        {
            var lstType = new List<CommonCode>();

            try
            {
                lstType = _commonCodeDao.SearchFor2(s => !s.CommonId.Contains("Announcement") && s.CommonTypeId == "NewsCategory" && s.NumValue1 == 0).OrderByDescending(x => x.CreatedDate).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstType;
        }

    }
}
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;
    using System;

    public class LinksService : Repository<Link>, ILinksService
    {
        ILinksDao _linkDao = new LinksDao();

        public void SetMainImage(long id, string objectId)
        {
            Link lnk = GetById(id);
            string sql1 = "Update [Links] set [Status]='0' where [ObjectIDD]='" + objectId + "' and [Type]='" + lnk.Type + "'";
            string sql2 = "Update [Links] set [Status]='1' where [Id]=" + id.ToString();

            int i = _linkDao.ExecuteSqlCmd(sql1);
            int j = _linkDao.ExecuteSqlCmd(sql2);
        }

        /// <summary>
        /// Limits the maximum number of image in a post
        /// </summary>
        /// <param name="id">Id of post</param>
        /// <returns></returns>
        public int LimitMaxImage(string id)
        {
            List<Link> link = _linkDao.SearchFor(x => x.ObjectId == id);
            int count = 0;

            foreach (var item in link)
            {
                count++;
            }

            if (count >= 10)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Get iamges of post
        /// </summary>
        /// <param name="id">Id of post</param>
        /// <returns>List images</returns>
        public List<Link> GetImagesOfPost(string id)
        {
            var list = new List<Link>();

            try
            {
                list = SearchFor2(x => x.ObjectId == id && x.Type == "NewsImage").OrderByDescending(x => x.CreatedOn).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }

        /// <summary>
        /// Get images of post
        /// </summary>
        /// <param name="id">Id of post</param>
        /// <returns>List images</returns>
        public List<string> GetUrlImagesOfPost(string id)
        {
            var list = new List<string>();

            try
            {
                list = SearchFor2(x => x.ObjectId == id && x.Type == "NewsImage").OrderByDescending(x => x.CreatedOn).Select(x=>x.URL).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }

        public List<Link> GetFiles(string id)
        {
            var list = new List<Link>();

            try
            {
                list = SearchFor2(x => x.ObjectId == id && x.Type == "Library").OrderByDescending(x => x.CreatedOn).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }
    }
}
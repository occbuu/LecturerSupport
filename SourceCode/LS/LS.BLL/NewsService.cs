using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Transactions;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;

    public class NewsService : Repository<News>, INewsService
    {
        private INewsDao _newsDao = new NewsDao();
        private ILinksDao _linksDao = new LinksDao();

        public List<News> ExcelsNews(string keyWord, DateTime? ftt, DateTime? ttt, string id)
        {
            var data = new List<News>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Title.Contains(keyWord)))
                            && (x.Time.Value.CompareTo(ftt.Value) >= 0 && x.Time.Value.CompareTo(ttt.Value) <= 0)
                        );
            }
            else
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Title.Contains(keyWord)))
                        );
            }
            return data;
        }

        public List<News> SearchCategory(string categoryId, string type, string keyWord)
        {
            var lstNews = SearchFor2(x => x.CategoryId == categoryId);

            if (!string.IsNullOrEmpty(keyWord))
            {
                switch (type)
                {
                    case "title":
                        lstNews = lstNews.Where(x => x.Title.Contains(keyWord));
                        break;
                    case "newsdetails":
                        lstNews = lstNews.Where(x => x.NewsDetail.Contains(keyWord));
                        break;
                    default: break;
                }
            }

            return lstNews.OrderByDescending(x => x.Time).ToList();
        }

        public List<News> SearchCate(string categoryId, int pageNumber, int pageSize, out int count)
        {
            var lstNewsPosts = new List<News>();
            var temp = this.SearchFor2(x => x.CategoryId == categoryId)
                .OrderByDescending(x => x.Time);
            count = temp.Count();
            lstNewsPosts = temp.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return lstNewsPosts.ToList();
        }

        public List<News> Search(string keyWord, DateTime? ftt, DateTime? ttt, string id, int pageNumber, int pageSize, out int count)
        {
            List<News> lstNewsPosts = new List<News>();
            IQueryable<News> temp;
            if (ftt != null && ttt != null)
            {
                temp = this.SearchFor2(x =>
                           ((x.Title.Contains(keyWord))
                           || (SqlFunctions.StringConvert((double)x.Id).Contains(keyWord)))
                           && (x.Time >= ftt && x.Time <= ttt)
                    );
                count = temp.Count();
                lstNewsPosts = temp.OrderByDescending(x => x.Time).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                temp = this.SearchFor2(x =>
                          ((x.CreatedBy.Contains(keyWord))
                          || (x.Title.Contains(keyWord))
                          || (SqlFunctions.StringConvert((double)x.Id).Contains(keyWord))
                          )
                    );
                count = temp.Count();
                lstNewsPosts = temp.OrderByDescending(x => x.Time).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            return lstNewsPosts;
        }

        /// <summary>
        /// Get news
        /// </summary>
        /// <param name="categoryId">Id of news category</param>
        /// <returns>List news</returns>
        public List<News> GetNews(string categoryId)
        {
            var listNews = new List<News>();

            try
            {
                listNews = SearchFor(x => x.CategoryId == categoryId).OrderByDescending(x => x.Time).ToList();
                return listNews;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get detail new
        /// </summary>
        /// <param name="newsId"> Id of one new</param>
        /// <returns>A new</returns>
        public News GetDetailNews(long newsId)
        {
            var news = new News();

            try
            {
                news = SearchFor(x => x.Id == newsId).FirstOrDefault();
                return news;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get 3 popular news
        /// </summary>
        /// <param name="categoryId"> Id of category</param>
        /// <returns>3 news</returns>
        public List<News> GetPopularNews(string categoryId)
        {
            var listNews = new List<News>();

            try
            {
                listNews = SearchFor(x => x.CategoryId == categoryId).OrderByDescending(x => x.Time).Take(3).ToList();
                return listNews;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteListNews(List<string> lsId)
        {
            using (var trans = new TransactionScope())
            {
                if (lsId.Count() > 0)
                {
                    foreach (var item in lsId)
                    {
                        //int iid = long.Parse(item);
                        if (!string.IsNullOrEmpty(item))
                        {
                            long id = long.Parse(item);
                            News news = _newsDao.SearchFor(x => x.Id == id).FirstOrDefault();
                            List<Link> link = _linksDao.SearchFor(x => x.ObjectId == item);
                            _newsDao.Delete(news);
                            foreach (var tempdelete in link)
                            {
                                _linksDao.Delete(tempdelete);
                            }
                        }
                    }
                }
                trans.Complete();
            }
        }

        /// <summary>
        /// Get max id
        /// </summary>
        /// <returns>Max id</returns>
        public long GetMaxId()
        {
            try
            {
                var item = GetAll().LastOrDefault();
                if (item != null)
                {
                    return item.Id;
                }
                return -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get list post(English & Japan)
        /// </summary>
        /// <param name="keyWord"> Key word to search</param>
        /// /// <param name="ftt"> From date</param>
        /// <param name="ttt"> To date</param>
        /// <returns>List post</returns>
        public List<News> GetListPost(string keyWord, DateTime? ftt, DateTime? ttt)
        {
            var list = new List<News>();

            try
            {
                if (ftt != null && ttt != null)
                {
                    ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                    list = SearchFor2(x => !x.CategoryId.Contains("Announcement") && x.Title.Contains(keyWord) && ftt <= x.Time && x.Time <= ttt).ToList();
                }
                else if (ftt != null && ttt == null)
                {
                    list = SearchFor2(x => !x.CategoryId.Contains("Announcement") && x.Title.Contains(keyWord) && ftt <= x.Time).ToList();
                }
                else if (ftt == null && ttt != null)
                {
                    ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                    list = SearchFor2(x => !x.CategoryId.Contains("Announcement") && x.Title.Contains(keyWord) && x.Time <= ttt).ToList();
                }
                else
                {
                    list = SearchFor2(x => !x.CategoryId.Contains("Announcement") && x.Title.Contains(keyWord)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list.OrderByDescending(x => x.Time).ToList();
        }

        public List<News> GetListAnnouncement(string keyWord, DateTime? ftt, DateTime? ttt, int pageIndex, int pageSize, out int count)
        {
            var list = new List<News>();

            try
            {
                if (ftt != null && ttt != null)
                {
                    ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                    list = SearchFor2(x => x.CategoryId.Contains("Announcement") && ftt <= x.Time && x.Time <= ttt).ToList();
                }
                else if (ftt != null && ttt == null)
                {
                    list = SearchFor2(x => x.CategoryId.Contains("Announcement") && ftt <= x.Time).ToList();
                }
                else if (ftt == null && ttt != null)
                {
                    ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                    list = SearchFor2(x => x.CategoryId.Contains("Announcement") && x.Time <= ttt).ToList();
                }
                else
                {
                    list = SearchFor2(x => x.CategoryId.Contains("Announcement")).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            count = list.Count();
            return list.OrderByDescending(x => x.Time).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
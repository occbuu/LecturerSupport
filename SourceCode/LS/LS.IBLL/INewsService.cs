using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface INewsService : IRepository<News>
    {
        List<News> Search(string keyWord, DateTime? ftt, DateTime? ttt, string id, int pageNumber, int pageSize, out int count);

        void DeleteListNews(List<string> lsId);

        List<News> SearchCategory(string categoryId, string type, string keyWord);

        List<News> ExcelsNews(string keyWord, DateTime? ftt, DateTime? ttt, string id);

        /// <summary>
        /// Get news
        /// </summary>
        /// <param name="categoryId">Id of news category</param>
        /// <returns>List news</returns>
        List<News> GetNews(string categoryId);

        /// <summary>
        /// Get detail news
        /// </summary>
        /// <param name="newsId"> Id of one news</param>
        /// <returns>A new</returns>
        News GetDetailNews(long newsId);

        /// <summary>
        /// Get 3 popular news
        /// </summary>
        /// <param name="categoryId"> Id of category</param>
        /// <returns>3 news</returns>
        List<News> GetPopularNews(string categoryId);

        /// <summary>
        /// Get max id
        /// </summary>
        /// <returns>Max id</returns>
        long GetMaxId();

        /// <summary>
        /// Get list post(English & Japan)
        /// </summary>
        /// <param name="keyWord"> Key word to search</param>
        /// <param name="ftt"> From date</param>
        /// <param name="ttt"> To date</param>
        /// <returns>List post</returns>
        List<News> GetListPost(string keyWord, DateTime? ftt, DateTime? ttt);

        List<News> SearchCate(string categoryId, int pageNumber, int pageSize, out int count);

        List<News> GetListAnnouncement(string keyWord, DateTime? ftt, DateTime? ttt, int pageIndex, int pageSize, out int count);
    }
}
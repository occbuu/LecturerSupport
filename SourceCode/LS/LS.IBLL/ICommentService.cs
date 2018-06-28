using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ICommentService : IRepository<Comment>
    {
        List<Comment> SearchComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int recordCount);

        void DeleteListComment(List<string> lsId);

        List<Comment> ExcelsComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt);

        /// <summary>
        /// Search comments by parent id
        /// </summary>
        /// <param name="objectLinkId">Id of news</param>
        /// <param name="parentId">Parent id</param>
        /// <param name="commentNumber">Times taken</param>
        /// <param name="commentSize">Some news is taken in one time</param>
        /// <returns></returns>
        List<Comment> SearchChildrenComment(long objectLinkId, long parentId, string status, int commentNumber, int commentSize);

        /// <summary>
        /// Takes some comments to show
        /// </summary>
        /// <param name="newsId">Id of news</param>
        /// <param name="commentNumber">Times taken</param>
        /// <param name="commentSize">Some news is taken in one time</param>
        /// <returns></returns>
        List<Comment> SearchByNewsLimit(long newsId, string status, int commentNumber, int commentSize);

        /// <summary>
        /// Counting the total number of comments
        /// </summary>
        /// <param name="objectLinkId">id of news</param>
        /// <returns>count</returns>
        int TotalComments(long objectLinkId);

        /// <summary>
        /// Get all comment with pagination
        /// </summary>
        /// <param name="newsId"></param>
        /// <param name="commenNumber"></param>
        /// <param name="commentSize"></param>
        /// <returns></returns>

        List<Comment> GetAllCommentWithPagination(long newsId, int commentNumber, int commentSize);

        /// <summary>
        /// Get all comments by parent id
        /// </summary>
        /// <param name="objectLinkId">Id of news</param>
        /// <param name="parentId">Parent id</param>
        /// <param name="commentNumber">Times taken</param>
        /// <param name="commentSize">Some news is taken in one time</param>
        /// <returns></returns>
        List<Comment> GetAllChildrenComment(long objectLinkId, long parentId, int commentNumber, int commentSize);

        int TotalCommentsBE(long objectLinkId);

    }
}
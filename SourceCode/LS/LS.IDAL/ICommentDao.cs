using System;
using System.Collections.Generic;

namespace LS.IDAL
{
    using Model;

    public interface ICommentDao : IRepository<Comment>
    {
        List<Comment> SearchComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int recordCount);

        List<Comment> ExcelsComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt);

        /// <summary>
        /// Takes some comments to show
        /// </summary>
        /// <param name="newsId">Id of news</param>
        /// <param name="commentNumber">Times taken</param>
        /// <param name="commentSize">Some news is taken in one time</param>
        /// <returns></returns>
        List<Comment> SearchByNewsLimit(long newsId, string status, int commentNumber, int commentSize);
    }
}
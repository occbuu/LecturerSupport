using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.DAL
{
    using IDAL;
    using Model;

    public class CommentDao : Repository<Comment>, ICommentDao
    {
        public List<Comment> SearchComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int recordCount)
        {
            var data = new List<Comment>();
            recordCount = 0;

            if (ftt != null && ttt != null)
            {
                var listemp = this.SearchFor2(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && (x.News.Title.Contains(keyWord) || x.CreatedBy.Contains(keyWord))))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status == status))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.CommentType.Contains(type)))
                               && (x.CreateDate >= ftt && x.CreateDate <= ttt)
                        ).Where(x => x.CommentType == "News" || x.CommentType == "Products");

                recordCount = listemp.Count();

                data = listemp
                    .OrderByDescending(b => b.CreateDate)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            else
            {
                var listemp = this.SearchFor2(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && (x.News.Title.Contains(keyWord) || x.CreatedBy.Contains(keyWord))))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status == status))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.CommentType.Contains(type)))
                        ).Where(x => x.CommentType == "News" || x.CommentType == "Products");
                recordCount = listemp.Count();
                data = listemp
                     .OrderByDescending(b => b.CreateDate)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            return data;
        }

        public List<Comment> ExcelsComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt)
        {
            var data = new List<Comment>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Content.Contains(keyWord)))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status.Contains(status)))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.CommentType.Contains(type)))
                               && (x.CreateDate.Value.CompareTo(ftt.Value) >= 0 && x.CreateDate.Value.CompareTo(ttt.Value) <= 0)
                        ).Where(x => x.CommentType == "News" || x.CommentType == "Products").ToList();
            }
            else
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Content.Contains(keyWord)))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status.Contains(status)))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.CommentType.Contains(type)))

                        ).Where(x => x.CommentType == "News" || x.CommentType == "Products").ToList(); ;
            }
            return data;
        }

        /// <summary>
        /// Takes some comments to show
        /// </summary>
        /// <param name="newsId">Id of news</param>
        /// <param name="commentNumber">Times taken</param>
        /// <param name="commentSize">Some news is taken in one time</param>
        /// <returns></returns>
        public List<Comment> SearchByNewsLimit(long newsId, string status, int commentNumber, int commentSize)
        {
            var data = new List<Comment>();
            try
            {
                data = this.SearchFor(x => x.ObjectLinkID == newsId && x.Level == status && x.Status == "1").OrderByDescending(x => x.CreateDate).Skip((commentNumber) * commentSize).Take(commentSize).ToList();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
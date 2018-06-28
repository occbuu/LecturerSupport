using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;

    public class CommentService : Repository<Comment>, ICommentService
    {
        private ICommentDao _commentDao = new CommentDao();

        public List<Comment> SearchComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int recordCount)
        {
            return _commentDao.SearchComment(keyWord, status, type, ftt, ttt, pageNumber, pageSize, out recordCount);
        }

        public void DeleteListComment(List<string> lsId)
        {
            using (var tran = new TransactionScope())
            {
                //string[] ls = lsId.Split(';');
                if (lsId.Count() > 0)
                {
                    foreach (var item in lsId)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            //int iid = long.Parse(item);
                            long id = long.Parse(item);
                            Comment cmt = _commentDao.SearchFor(x => x.Id == id).FirstOrDefault();
                            List<Comment> cmtList = _commentDao.GetAll();
                            if (cmt.ParentId != 0)
                            {
                                _commentDao.Delete(cmt);
                            }
                            else
                            {
                                foreach (var tempDelete in cmtList)
                                {
                                    if (tempDelete.ParentId == cmt.Id)
                                    {
                                        _commentDao.Delete(tempDelete);
                                        foreach (var item1 in lsId)
                                        {
                                            if (item1 == tempDelete.Id.ToString())
                                            {
                                                lsId.Remove(item1);
                                            }
                                        }

                                    }
                                }
                                _commentDao.Delete(cmt);
                            }
                        }
                    }
                }
                tran.Complete();
            }
        }

        public List<Comment> ExcelsComment(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt)
        {
            return _commentDao.ExcelsComment(keyWord, status, type, ftt, ttt);
        }

        /// <summary>
        /// Search comments by parent id
        /// </summary>
        /// param name="objectLinkId">Id of news</param>
        /// <param name="parentId">Parent id</param>
        /// <param name="commentNumber">Times taken</param>
        /// <param name="commentSize">Some news is taken in one time</param>
        /// <returns></returns>
        public List<Comment> SearchChildrenComment(long objectLinkId, long parentId, string status, int commentNumber, int commentSize)
        {
            var data = new List<Comment>();
            try
            {
                string id = parentId.ToString();
                data = this.SearchFor(x => x.ParentId == parentId && x.Status == status && x.ObjectLinkID == objectLinkId).OrderByDescending(x => x.CreateDate).Skip((commentNumber - 1) * commentSize).Take(commentSize).ToList();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            return _commentDao.SearchByNewsLimit(newsId, status, commentNumber, commentSize);
        }

        /// <summary>
        /// Counting the total number of comments
        /// </summary>
        /// <param name="objectLinkId">id of news</param>
        /// <returns>count</returns>
        public int TotalComments(long objectLinkId)
        {
            return _commentDao.SearchFor2(x => x.ObjectLinkID == objectLinkId && x.Status == "1").Count();
        }

        /// <summary>
        /// Get all comment with pagination
        /// </summary>
        /// <param name="newsId"></param>
        /// <param name="commenNumber"></param>
        /// <param name="commentSize"></param>
        /// <returns></returns>

        public List<Comment> GetAllCommentWithPagination(long newsId, int commentNumber, int commentSize)
        {
            var data = new List<Comment>();
            try
            {
                data = this.SearchFor(x => x.ObjectLinkID == newsId && x.Level == "1").OrderByDescending(x => x.CreateDate).Skip((commentNumber) * commentSize).Take(commentSize).ToList();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Comment> GetAllChildrenComment(long objectLinkId, long parentId, int commentNumber, int commentSize)
        {
            var data = new List<Comment>();
            try
            {
                string id = parentId.ToString();
                data = this.SearchFor(x => x.ParentId == parentId && x.ObjectLinkID == objectLinkId).OrderByDescending(x => x.CreateDate).Skip((commentNumber - 1) * commentSize).Take(commentSize).ToList();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int TotalCommentsBE(long objectLinkId)
        {
            return _commentDao.SearchFor2(x => x.ObjectLinkID == objectLinkId).Count();
        }
    }
}
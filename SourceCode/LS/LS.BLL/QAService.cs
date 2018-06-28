using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class QAService : Repository<QA>, IQAService
    {
        private IQADao QADao = new QADao();

        /// <summary>
        /// Search SearchQA to get a list QA by keyword, type, ftt(from time), ttt(to time)
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public List<QA> SearchQA(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int recordCount)
        {
            var data = new List<QA>();
            recordCount = 0;

            if (ftt != null && ttt != null)
            {
                var listemp = this.SearchFor2(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Question.Contains(keyWord)))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status == status))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.QuestionType.Contains(type)))
                               && (x.CreatedDate >= ftt && x.CreatedDate <= ttt)
                        );

                recordCount = listemp.Count();

                data = listemp
                    .OrderByDescending(b => b.AskedDate)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            else
            {
                var listemp = this.SearchFor2(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Question.Contains(keyWord)))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status == status))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.QuestionType.Contains(type)))
                        );
                recordCount = listemp.Count();
                data = listemp
                     .OrderByDescending(b => b.CreatedDate)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            return data;
        }

        /// <summary>
        /// Excel ExcelsQA to get a list QA by keyword, status, type, ftt(from time), ttt(to time)
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public List<QA> ExcelsQA(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt)
        {
            var data = new List<QA>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Question.Contains(keyWord)))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status.Contains(status)))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.QuestionType.Contains(type)))
                               && (x.AskedDate.Value.CompareTo(ftt.Value) >= 0 && x.AskedDate.Value.CompareTo(ttt.Value) <= 0)
                        );
            }
            else
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Question.Contains(keyWord)))
                               && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status.Contains(status)))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.QuestionType.Contains(type)))

                        );
            }
            return data;
        }

        public void DeleteListQA(string lsId)
        {
            using (var tran = new TransactionScope())
            {
                string[] ls = lsId.Split(';');
                if (ls.Count() > 0)
                {
                    foreach (var item in ls)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            QA qa = QADao.GetById(Int64.Parse(item));
                            QADao.Delete(qa);
                        }
                    }
                }
                tran.Complete();
            }
        }
    }
}
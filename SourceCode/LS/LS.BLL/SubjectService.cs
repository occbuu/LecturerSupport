using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace LS.BLL
{
    using System;
    using IBLL;
    using Model;
    using IDAL;
    using DAL;

    public class SubjectService : Repository<Subject>, ISubjectService
    {
        private ISubjectDao _subjectDao = new SubjectDao();
        public List<Subject> getListPost(string keyWord, DateTime? ftt, DateTime? ttt)
        {
            var list = new List<Subject>();

            try
            {
                if (keyWord == "" && ftt != null && ttt != null)
                {
                    ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                    list = SearchFor2(x => ftt <= x.CreatedOn && x.CreatedOn <= ttt).ToList();
                }
                else if (ftt != null && ttt == null && keyWord == "")
                {
                    list = SearchFor2(x => ftt <= x.CreatedOn).ToList();
                }
                else if (ftt == null && ttt != null && keyWord == "")
                {
                    list = SearchFor2(x => x.CreatedOn <= ttt).ToList();
                }
                else if (ftt == null && ttt == null && keyWord != "")
                {
                    list = SearchFor2(x => x.SubjectName.Contains(keyWord)).ToList();
                }
                else if (ftt == null && ttt == null && keyWord != "")
                {
                    list = SearchFor2(x => x.SubjectName == keyWord).ToList();
                }
                else if (ftt != null && ttt == null && keyWord != "")
                {
                    list = SearchFor2(x => x.SubjectName.Contains(keyWord) && ftt <= x.CreatedOn).ToList();
                }
                else if (ftt == null && ttt != null && keyWord != "")
                {
                    list = SearchFor2(x => x.SubjectName.Contains(keyWord) && x.CreatedOn <= ttt).ToList();
                }
                else
                {
                    list = GetAll();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list.OrderByDescending(x => x.CreatedOn).ToList();
        }

        public List<Subject> SeachBySubjectName(string subjectName)
        {
            return SearchFor2(s => s.SubjectName == subjectName).ToList();
        }

        public void DeleteListSubject(List<string> lsId)
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
                            Subject subject = _subjectDao.SearchFor(x => x.Id == id).FirstOrDefault();
                            _subjectDao.Delete(subject);
                        }
                    }
                }
                trans.Complete();
            }
        }
    }
}
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

    public class LibraryService : Repository<Library>, ILibraryService
    {

        private ILibraryDao _libsDao = new LibraryDao();
        private ILinksDao _linksDao = new LinksDao();
        private ICommonCodeDao _codeDao = new CommonCodeDao();


        public List<Library> SeachByType(string type)
        {
            return SearchFor2(t => t.Type == type).ToList();
        }

        public List<Library> SearchCate(string type, int pageNumber, int pageSize, out int count)
        {
            var lstLib = new List<Library>();
            var temp = this.SearchFor2(x => x.Type == type)
                .OrderByDescending(x => x.CreatedDate);
            count = temp.Count();
            lstLib = temp.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return lstLib.ToList();
        }

        public List<Library> GetType()
        {
            try
            {
                var lstInfoService = GetAll();
                if (lstInfoService != null)
                {
                    return lstInfoService;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Library GetDetailLib(long libId)
        {
            var lib = new Library();
            try
            {
                lib = SearchFor(x => x.Id == libId).FirstOrDefault();
                return lib;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public List<Library> getListLibrary(string type, string keyWord, DateTime? ftt, DateTime? ttt)
        {
            var list = new List<Library>();
            var tmp = SeachByType(type);
            try
            {
                if (type == "Type")
                {
                    if (ftt != null && ttt != null)
                    {
                        ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                        list = SearchFor2(x => (x.Type.Contains("Announcement-3-1") || x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord) && ftt <= x.CreatedDate && x.CreatedDate <= ttt).ToList();
                    }
                    else if (ftt != null && ttt == null)
                    {
                        list = SearchFor2(x => (x.Type.Contains("Announcement-3-1") || x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord) && ftt <= x.CreatedDate).ToList();
                    }
                    else if (ftt == null && ttt != null)
                    {
                        list = SearchFor2(x => (x.Type.Contains("Announcement-3-1") || x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord) && x.CreatedDate <= ttt).ToList();
                    }
                    else
                    {
                        list = SearchFor2(x => (x.Type.Contains("Announcement-3-1") || x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord)).ToList();
                    }
                }
                else
                {
                    if (type == "Announcement-3-1")
                    {
                        if (ftt != null && ttt != null)
                        {
                            ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-1")) && x.Title.Contains(keyWord) && ftt <= x.CreatedDate && x.CreatedDate <= ttt).ToList();
                        }
                        else if (ftt != null && ttt == null)
                        {
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-1")) && x.Title.Contains(keyWord) && ftt <= x.CreatedDate).ToList();
                        }
                        else if (ftt == null && ttt != null)
                        {
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-1")) && x.Title.Contains(keyWord) && x.CreatedDate <= ttt).ToList();
                        }
                        else
                        {
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-1")) && x.Title.Contains(keyWord)).ToList();
                        }
                    }
                    else if (type == "Announcement-3-2")
                    {
                        if (ftt != null && ttt != null)
                        {
                            ttt = ttt.Value.AddDays(1).AddSeconds(-1);
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord) && ftt <= x.CreatedDate && x.CreatedDate <= ttt).ToList();
                        }
                        else if (ftt != null && ttt == null)
                        {
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord) && ftt <= x.CreatedDate).ToList();
                        }
                        else if (ftt == null && ttt != null)
                        {
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord) && x.CreatedDate <= ttt).ToList();
                        }
                        else
                        {
                            list = SearchFor2(x => (x.Type.Contains("Announcement-3-2")) && x.Title.Contains(keyWord)).ToList();
                        }
                    }
                }
                var lsCode = _codeDao.GetAll().Where(p => p.CommonTypeId == "Library");
                var tmp2 = from a in list
                           join b in lsCode
                           on a.Type equals b.CommonId
                           select new Library
                           {
                               Id = a.Id,
                               Title = a.Title,
                               Type = b.StrValue1,
                               Brief = a.Brief,
                               Status = a.Status,
                               Description = a.Description,
                               CreatedBy = a.CreatedBy,
                               CreatedDate = a.CreatedDate,
                               Images = a.Images,
                               // add value in table Library

                           };

                return tmp2.OrderByDescending(x => x.CreatedDate).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return new List<Library>();
        }

        public List<Library> ChangeLib(string type)
        {
            try
            {
                var lstInfoService = SeachByType(type);
                if (lstInfoService != null)
                {
                    return lstInfoService;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteListLib(List<string> lsId)
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
                            Library lib = _libsDao.SearchFor(x => x.Id == id).FirstOrDefault();
                            List<Link> link = _linksDao.SearchFor(x => x.ObjectId == item);
                            _libsDao.Delete(lib);
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
    }
}
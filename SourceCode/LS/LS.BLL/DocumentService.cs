using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LS.BLL
{
    using Model;
    using IBLL;
    using Utility;


    public class DocumentService : Repository<Document>, IDocumentService
    {
        /// <summary>
        /// Get a list of documents by classId and type of document
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Document> SearchByClassId(long? classId, string documentType, int pageNumber, int pageSize, out int count)
        {
            var lstDocument = new List<Document>();
            IQueryable<Document> temp = null;
            if (classId != null)
            {
                temp = SearchFor2(x => x.ClassId == classId && x.DocumentType == documentType && x.Status != Constants.Document_Status.DeleteStatus);
                count = temp.Count();
                lstDocument = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                count = 0;
                lstDocument = null;
            }
            return lstDocument;
        }

        /// <summary>
        /// Get a list of Document by documentTypeId
        /// </summary>
        /// <param name="documentType"></param>
        /// <returns></returns>
        public List<Document> GetTypeOfDocument(string documentTypeId)
        {
            var lstDocument = new List<Document>();
            IQueryable<Document> temp = null;
            if (documentTypeId != null)
            {
                temp = SearchFor2(x => x.DocumentType == documentTypeId);
                lstDocument = temp.ToList();
            }
            return lstDocument;
        }

        /// <summary>
        /// Get a list of document by status, classId, documentType, type, time
        /// </summary>
        /// <param name="status"></param>
        /// <param name="classId"></param>
        /// <param name="documentType"></param>
        /// <param name="type"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Document> SearchBySelectedList(string status, List<long?> classId, string documentType, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int count)
        {
            var lstClass = new List<Document>();
            IQueryable<Document> temp;
            if (ftt != null && ttt != null)
            {
                if (status == null && type == null && classId == null)
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (status == null && type == null)
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && classId.Contains(x.ClassId) && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (status == null && classId == null)
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && x.Type == type && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (type == null && classId == null)
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && x.Status == status && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }

                else if (type == null)
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && x.Status == status && classId.Contains(x.ClassId) && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (status == null)
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && x.Type == type && classId.Contains(x.ClassId) && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (classId == null)
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && x.Type == type && x.Status == status && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    temp = SearchFor2(x => x.CreateDate >= ftt && x.CreateDate <= ttt && x.Type == type && x.Status == status && classId.Contains(x.ClassId) && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }

            }
            else
            {
                if (status == null && type == null && classId == null)
                {
                    temp = SearchFor2(x => x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (status == null && type == null)
                {
                    temp = SearchFor2(p => classId.Contains(p.ClassId) && p.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.CreateDate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (status == null && classId == null)
                {
                    temp = SearchFor2(x => x.Type == type && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (type == null && classId == null)
                {
                    temp = SearchFor2(x => x.Status == status && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }

                else if (type == null)
                {
                    temp = SearchFor2(x => x.Status == status && classId.Contains(x.ClassId) && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (status == null)
                {
                    temp = SearchFor2(x => x.Type == type && classId.Contains(x.ClassId) && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else if (classId == null)
                {
                    temp = SearchFor2(x => x.Type == type && x.Status == status && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    temp = SearchFor2(x => x.Type == type && x.Status == status && classId.Contains(x.ClassId) && x.DocumentType == documentType);
                    count = temp.Count();
                    lstClass = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }
            }
            return lstClass;
        }

        /// <summary>
        /// Get a list of document by keyWord for Title or Content
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="documentType"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Document> SearchByTyping(string keyWord, string documentType, int pageNumber, int pageSize, out int count)
        {
            var lstDocument = new List<Document>();
            IQueryable<Document> temp;
            count = 0;
            if (keyWord != null)
            {
                temp = SearchFor2(x => (x.Title.Contains(keyWord) || x.Content.Contains(keyWord) ) && x.DocumentType==documentType);
                count = temp.Count();
                lstDocument = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                temp = SearchFor2(x => true && x.DocumentType == documentType);
                count = temp.Count();
                lstDocument = temp.OrderByDescending(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            return lstDocument;
        }
    }
}
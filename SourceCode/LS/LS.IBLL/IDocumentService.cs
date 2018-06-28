using System.Collections.Generic;
using System;

namespace LS.IBLL
{
    using Model;

    public interface IDocumentService : IRepository<Document>
    {
        List<Document> SearchByClassId(long? classId, string documentType, int pageNumber, int pageSize, out int count);
        List<Document> GetTypeOfDocument(string documentTypeId);

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
        List<Document> SearchBySelectedList(string status, List<long?> classId, string documentType, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int count);

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
        List<Document> SearchByTyping(string keyWord, string documentType, int pageNumber, int pageSize, out int count);

    }
}
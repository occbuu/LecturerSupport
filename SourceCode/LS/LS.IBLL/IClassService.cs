using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface IClassService : IRepository<Class>
    {
        List<Class> Search(string keyWord, DateTime? ftt, DateTime? ttt, string id, int pageNumber, int pageSize, out int count);
        List<Class> SearchOlder(string keyWord, string id, int pageNumber, int pageSize, out int count);
        List<Class> ExcelsClass(string keyWord, DateTime? ftt, DateTime? ttt, string id);
        List<Class> SearchBySelectedList(string status, long? schoolId, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int count);
        List<Class> SearchByTyping(string keyWord, int pageNumber, int pageSize, out int count);

        /// <summary>
        /// Get a list of class by schoolId
        /// </summary>
        /// <param name="schoolId"></param>
        /// <returns></returns>
        List<Class> GetClassBySchoolId(long? schoolId);

    }
}
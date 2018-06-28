using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using LS.Model;

    public interface IQAService : IRepository<QA>
    {
        List<QA> SearchQA(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt, int pageNumber, int pageSize, out int recordCount);
        void DeleteListQA(string lsId);

        List<QA> ExcelsQA(string keyWord, string status, string type, DateTime? ftt, DateTime? ttt);
    }

}
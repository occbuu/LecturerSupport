using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using LS.Model;

    public interface ILogsService : IRepository<Log>
    {
       List<Log> Search(string keyWord, DateTime? ftt, DateTime? ttt);
    }
}
using System;
using System.Collections.Generic;

namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class LogsService : Repository<Log>, ILogsService
    {
        private ILogsDao LogsDao = new LogsDao();

        public List<Log> Search(string keyWord, DateTime? ftt, DateTime? ttt)
        {
            var data = new List<Log>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.Action.Contains(keyWord)))
                            && (x.CreatedDate.Value.CompareTo(ftt.Value) >= 0 && x.CreatedDate.Value.CompareTo(ttt.Value) <= 0)
                        );
            }
            else
            {
                data = this.SearchFor(x =>
                              (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.CreatedBy.Contains(keyWord)))

                        );
            }
            return data;
        }

    }
}
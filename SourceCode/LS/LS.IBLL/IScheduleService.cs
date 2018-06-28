using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface IScheduleService : IRepository<Schedule>
    {
        List<Schedule> SearchBySchool(DateTime? ftt, DateTime? ttt, long? schoolId, int pageNumber, int pageSize, out int count);
        List<Schedule> SearchByClassId(DateTime? ftt, DateTime? ttt, long? classlId, int pageNumber, int pageSize, out int count);

    }
}
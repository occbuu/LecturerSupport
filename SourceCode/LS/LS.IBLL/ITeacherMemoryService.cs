using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ITeacherMemoryService : IRepository<TeacherMemory>
    {
        List<TeacherMemory> SearchByType(string type);
    }
}

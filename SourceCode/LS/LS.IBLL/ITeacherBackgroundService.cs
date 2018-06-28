using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ITeacherBackgroundService : IRepository<TeacherBackground>
    {
        List<TeacherBackground> SearchByType(string type);
    }
}

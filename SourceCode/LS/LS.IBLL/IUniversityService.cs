using System.Collections.Generic;
namespace LS.IBLL
{
    using Model;

    public interface IUniversityService : IRepository<University>
    {
        List<University> Search(string keyWord, long? Id, int pageNum, int pageSize, out int count);
    }
}
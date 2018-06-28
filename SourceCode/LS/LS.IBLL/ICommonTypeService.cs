using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ICommonTypeService : IRepository<CommonType>
    {
        List<CommonType> SearchByCommonTypeId(string commonType);
        List<CommonType> SearchByDescription(string description);
    }
}
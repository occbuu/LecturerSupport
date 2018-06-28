using System.Collections.Generic;

namespace LS.IDAL
{
    using LS.Model;

    public interface IFunctionDao : IRepository<Function>
    {
        List<Function> GetAccessibleFunctions(string userId);
    }
}
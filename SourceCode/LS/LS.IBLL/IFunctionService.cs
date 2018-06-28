using System.Collections;

namespace LS.IBLL
{
    using LS.Model;

    public interface IFunctionService : IRepository<Function>
    {
        Hashtable GetAccessibleFunctions(string userId);
    }
}
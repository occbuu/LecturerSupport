using System.Collections.Generic;
using System.Linq;

namespace LS.DAL
{
    using LS.IDAL;
    using LS.Model;

    public class FunctionDao : Repository<Function>, IFunctionDao
    {
        public List<Function> GetAccessibleFunctions(string userId)
        {
            var result = this.SearchFor2(a =>
                a.FunctionRoles.Any(b => (b.Role.UserRoles.Any(c => c.User.UserId == userId)))

                         ).ToList();

            return result;
        }
    }
}
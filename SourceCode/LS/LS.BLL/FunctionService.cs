using System.Collections;
using System.Collections.Generic;

namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class FunctionService : Repository<Function>, IFunctionService
    {
        private IFunctionDao dao { get; set; }

        public FunctionService()
        {
            dao = new FunctionDao();
        }

        public Hashtable GetAccessibleFunctions(string userId)
        {
            Hashtable hashTable = new Hashtable();
            IList<Function> moduleFunctions = dao.GetAccessibleFunctions(userId);
            for (int i = 0; i < moduleFunctions.Count; i++)
            {
                if (!hashTable.ContainsKey(moduleFunctions[i].Id))
                    hashTable.Add(moduleFunctions[i].Id, moduleFunctions[i].Code);
            }
            return hashTable;
        }
    }
}
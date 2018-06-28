using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using LS.Model;

    public interface IObjectService : IRepository<Object>
    {
        List<Object> ManageCustomer(string keyWordSearch, DateTime? ftt, DateTime? ttt);
        //string CreateObjectId(string type);
        void Insert2(Object entity, string objectType);
    }

}
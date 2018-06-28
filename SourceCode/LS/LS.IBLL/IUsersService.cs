using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface IUsersService : IRepository<User>
    {
        List<User> Search(string keyWord, DateTime? ftt, DateTime? ttt);
        User SearchUserFront(string userId, string pwd);

        int GetTotalNewUsers();

        void InsertUser(Object obj, User usr, UserRole usrRole);

        void InsertUserFront(Object obj, User usr, UserRole usrRole);

        void Delete_ListUser(List<string> lsId, string pCurrentUser);

        List<User> ExcelsUser(string keyWord, string type, DateTime? ftt, DateTime? ttt);

        void UpdatetUser(Object obj, User usr, UserRole usrRole);
    }
}
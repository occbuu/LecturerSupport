using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;

    public class UsersService : Repository<User>, IUsersService
    {
        private IUsersDao _usersDao = new UsersDao();
        private IObjectService _objectService = new ObjectService();
        private IUserRoleDao _uRolerDao = new UserRoleDao();

        /// <summary>
        /// Search to get a list of User by keyWord, ftt(from time), ttt(to time)
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <returns></returns>
        public List<User> Search(string keyWord, DateTime? ftt, DateTime? ttt)
        {
            var data = new List<User>();
            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x => (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.UserId.Contains(keyWord) && x.CreatedBy.Contains(keyWord)))
                && (x.CreatedDate.Value.CompareTo(ftt.Value) >= 0 && x.CreatedDate.Value.CompareTo(ttt.Value) <= 0));
            }
            else
            {
                data = this.SearchFor(x => (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.UserId.Contains(keyWord) && x.CreatedBy.Contains(keyWord))));
            }
            return data;
        }

        /// <summary>
        /// Search to get a user by userId, pwd(password)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public User SearchUserFront(string userId, string pwd)
        {
            if (userId == null || pwd == null)
            {
                return null;
            }
            var res = _usersDao.SearchFor2(x => x.UserId == userId && x.Pwd == pwd).FirstOrDefault();
            return res;
        }

        /// <summary>
        /// Get all users with status =1 and ModifiedBy not bull
        /// </summary>
        /// <returns></returns>
        public int GetTotalNewUsers()
        {
            var ls = SearchFor2(x => x.Status == "1" && string.IsNullOrEmpty(x.ModifiedBy));
            return ls.Count();
        }

        /// <summary>
        /// Get to get a list of User by keyWord, ftt(from time), ttt(to time) 
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="type"></param>
        /// <param name="ftt"></param>
        /// <param name="ttt"></param>
        /// <returns></returns>
        public List<User> ExcelsUser(string keyWord, string type, DateTime? ftt, DateTime? ttt)
        {
            var data = new List<User>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.UserId.Contains(keyWord)))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.Status.Contains(type)))
                               && (x.CreatedDate.Value.CompareTo(ftt.Value) >= 0 && x.CreatedDate.Value.CompareTo(ttt.Value) <= 0)
                        );
            }
            else
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.UserId.Contains(keyWord)))
                               && (string.IsNullOrEmpty(type) || (!string.IsNullOrEmpty(type) && x.Status.Contains(type)))

                        );
            }
            return data;
        }

        /// <summary>
        /// Insert a user with TransactionScope by obj, usr, usrRole 
        /// </summary>
        /// <param name="Obj"></param>
        /// <param name="Usr"></param>
        /// <param name="usrRole"></param>
        public void InsertUser(Object obj, User usr, UserRole usrRole)
        {
            using (var tran = new TransactionScope())
            {

                _objectService.Insert2(obj, "33");
                usr.ObjectId = obj.ObjectId;
                _usersDao.Insert(usr);
                usrRole.UserId = usr.UserId;
                _uRolerDao.Insert(usrRole);
                tran.Complete();
            }
        }

        /// <summary>
        /// Insert in font end a user with TransactionScope by obj, usr, usrRole 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="usr"></param>
        /// <param name="usrRole"></param>
        public void InsertUserFront(Object obj, User usr, UserRole usrRole)
        {
            using (var tran = new TransactionScope())
            {
                _objectService.Insert2(obj, "33");
                usr.ObjectId = obj.ObjectId;

                _usersDao.Insert(usr);
                usrRole.UserId = usr.UserId;
                _uRolerDao.Insert(usrRole);
                tran.Complete();
            }
        }

        /// <summary>
        /// Delete a list of user by lsId, pCurrentUser
        /// </summary>
        /// <param name="lsId"></param>
        /// <param name="pCurrentUser"></param>
        public void Delete_ListUser(List<string> lsId, string pCurrentUser)
        {
            using (var tran = new TransactionScope())
            {
                foreach (string item in lsId)
                {
                    if (!string.IsNullOrEmpty(item) && item != "admin")
                    {
                        Delete(item, pCurrentUser);
                    }
                }
                tran.Complete();
            }
        }

        /// <summary>
        /// Update a user by obj, usr, usrRole
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="usr"></param>
        /// <param name="usrRole"></param>
        public void UpdatetUser(Object obj, User usr, UserRole usrRole)
        {
            using (var tran = new TransactionScope())
            {
                _objectService.Update(obj);
                usr.ObjectId = obj.ObjectId;
                UserRole userrl = new UserRole { RoleId = usrRole.RoleId, UserId = usrRole.UserId };
                var userrole1 = _uRolerDao.SearchFor(x => x.UserId == usr.UserId).FirstOrDefault();
                _uRolerDao.Delete(userrole1);
                _uRolerDao.Insert(userrl);
                _usersDao.Update(usr);
                tran.Complete();
            }
        }

        /// <summary>
        /// Delete a user by pId and pCurrentUser
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="pCurrentUser"></param>
        private void Delete(string pID, string pCurrentUser)
        {
            User userObj = _usersDao.SearchFor(x => x.ObjectId == pID).FirstOrDefault();
            if (userObj != null && userObj.UserId != "admin")
            {
                //userObj.Status = Constants.Users_Status.Deleted;
                userObj.ModifiedBy = pCurrentUser;
                userObj.ModifiedDate = DateTime.Now;
                _usersDao.Update(userObj);
            }
        }
    }
}
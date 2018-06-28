namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class UserRoleService : Repository<UserRole>, IUserRoleService
    {
        private IUserRoleDao Dao = new UserRoleDao();
    }
}
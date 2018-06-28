namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class RoleService : Repository<Role>, IRoleService
    {
        private IRoleDao dao = new RoleDao();
    }
}
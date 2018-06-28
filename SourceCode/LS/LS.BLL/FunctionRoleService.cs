namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class FunctionRoleService : Repository<FunctionRole>, IFunctionRoleService
    {
        private IFunctionRoleDao dao = new FunctionRoleDao();
    }
}
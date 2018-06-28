namespace LS.IDAL
{
    using LS.Model;

    public interface ILinksDao : IRepository<Link>
    {
        int ExecuteSqlCmd(string query);
    }
}
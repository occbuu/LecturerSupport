namespace LS.DAL
{
    using LS.IDAL;
    using LS.Model;

    public class LinksDao : Repository<Link>, ILinksDao
    {
        public int ExecuteSqlCmd(string query)
        {
            return ExecuteSqlCommand(query);
        }
    }
}
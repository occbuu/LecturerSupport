using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ITagsService : IRepository<Tag>
    {
        List<Tag> GetListTag(string tagId, string type);
    }
}
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ISiteInfoService : IRepository<SiteInfo>
    {
        /// <summary>
        /// Get Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>List Type</returns>
        List<SiteInfo> ChangeSiteInfo(string type);

        List<SiteInfo> SeachByType(string type);

        List<SiteInfo> SeachByParentId(string parentId);

        List<SiteInfo> SearchByBrief(string brief);
    }
}
using System.Collections.Generic;
using System.Linq;
using System;

namespace LS.BLL
{
    using IBLL;
    using Model;

    public class SiteInfoService : Repository<SiteInfo>, ISiteInfoService
    {
        public List<SiteInfo> SearchByBrief(string brief)
        {
            return SearchFor2(t => t.brief.Contains(brief)).ToList();
        }

        public List<SiteInfo> SeachByParentId(string parentId)
        {
            return SearchFor2(t => t.ParentId == parentId).ToList();
        }

        public List<SiteInfo> SeachByType(string type)
        {
            return SearchFor2(t => t.type == type).ToList();
        }

        /// <summary>
        /// Get Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>List Type</returns>
        public List<SiteInfo> ChangeSiteInfo(string type)
        {
            try
            {
                var lstInfoService = SeachByType(type);
                if (lstInfoService != null)
                {
                    return lstInfoService;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
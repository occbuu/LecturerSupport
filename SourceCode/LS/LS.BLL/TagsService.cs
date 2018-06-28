using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using IBLL;
    using Model;

    public class TagsService : Repository<Tag>, ITagsService
    {
        public List<Tag> GetListTag(string tagId, string type)
        {
            var lstTags = new List<Tag>();
            try
            {
                lstTags = SearchFor2(x => x.Type == type && x.TagId == tagId).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstTags;
        }
    }
}
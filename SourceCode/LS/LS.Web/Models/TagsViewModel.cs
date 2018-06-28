using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class TagsViewModel
    {
        public long Id { get; set; }
        public string TagName { get; set; }
        public string Type { get; set; }
        public string TagId { get; set; }

        public static List<TagsViewModel> Convert(List<Tag> list)
        {
            if (list == null)
            {
                return new List<TagsViewModel>();
            }
            var res = from s in list
                      select new TagsViewModel
                      {
                          Id = s.Id,
                          TagName = s.TagName,
                          Type = s.Type,
                          TagId = s.TagId
                      };

            return res.ToList();
        }
    }
}
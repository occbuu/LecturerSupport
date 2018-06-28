using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class UniversityViewModel
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public static List<UniversityViewModel> Convert(List<University> lst)
        {
            if (lst == null)
            {
                return new List<UniversityViewModel>();
            }
            var res = from s in lst
                      select new UniversityViewModel
                      {
                          Id = s.Id,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }
}
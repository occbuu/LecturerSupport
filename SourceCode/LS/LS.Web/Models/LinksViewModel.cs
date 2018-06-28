using System.Collections.Generic;

namespace LS.Web.Models
{
    using Model;
    using System.Linq;

    public class LinksViewModel
    {
        public long Id { get; set; }
        public string ObjectId { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string FileExtension { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public string CreateBy { get; set; }
        public string CreateOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }

        public static List<LinksViewModel> Convert(List<Link> list)
        {
            if (list == null)
            {
                return new List<LinksViewModel>();
            }
            var res = from s in list
                      select new LinksViewModel
                      {
                          Id = s.Id,
                          ObjectId = s.ObjectId,
                          Url = s.URL,
                          Type = s.Type,
                          FileExtension = s.FileExtension,
                          FileName = s.FileName,
                          Status = s.Status,
                          CreateBy = s.CreatedBy,
                          CreateOn = s.CreatedOn.HasValue ? s.CreatedOn.Value.ToString("dd/MM/yyyy") : string.Empty,
                          ModifiedBy = s.ModifiedBy,
                          ModifiedOn = s.ModifiedOn.HasValue ? s.CreatedOn.Value.ToString("dd/MM/yyyy") : string.Empty
                      };

            return res.ToList();
        }
    }
}
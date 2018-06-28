using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using BLL;
    using IBLL;
    using Model;

    public class LibraryViewModels
    {
        private static ICommonCodeService _commonCodeService = new CommonCodeService();
        private static ILinksService _linksService = new LinksService();

        public long Id { get; set; }
        public long Download { get; set; }
        public string Type { get; set; }
        public string TypeId { get; set; }
        public string Title { get; set; }
        public string Links { get; set; }
        public string Brief { get; set; }
        public string Images { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public List<ListUrlFiles> LstFiles { get; set; }

        public static List<LibraryViewModels> Convert(List<Library> list)
        {
            if (list == null)
            {
                return new List<LibraryViewModels>();
            }

            var res = from tmp in list
                      select new LibraryViewModels
                      {
                          Id = tmp.Id,
                          Type = tmp.Type,
                          Title = tmp.Title,
                          CreatedBy = tmp.CreatedBy,
                          Links = tmp.Links,
                          Brief = tmp.Brief,
                          CreatedDate = tmp.CreatedDate.HasValue ? tmp.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          ModifiedBy = tmp.ModifiedBy,
                          ModifiedDate = tmp.ModifiedDate.HasValue ? tmp.ModifiedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          Status = tmp.Status,
                          Description = tmp.Description,
                          Keyword = tmp.Keyword,
                          Images = tmp.Images,
                          LstFiles = ListUrlFiles.Convert(_linksService.GetUrlImagesOfPost(tmp.Id.ToString()))
                      };
            return res.ToList();
        }

        public static LibraryViewModels Convert(Library tmp)
        {
            if (tmp == null)
            {
                return new LibraryViewModels();
            }

            var res = new LibraryViewModels
            {
                Id = tmp.Id,
                Type = tmp.Type,
                Title = tmp.Title,
                CreatedBy = tmp.CreatedBy,
                Links = tmp.Links,
                Brief = tmp.Brief,
                CreatedDate = tmp.CreatedDate.HasValue ? tmp.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                ModifiedBy = tmp.ModifiedBy,
                ModifiedDate = tmp.ModifiedDate.HasValue ? tmp.ModifiedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                Status = tmp.Status,
                Description = tmp.Description,
                Keyword = tmp.Keyword,
                Images = tmp.Images
            };
            return res;
        }
    }

    public class TypeViewModel
    {
        public CommonCode Type { get; set; }
        public CommonCode Type_Parent { get; set; }
        public List<LibraryViewModels> lstLib { get; set; }
        public int TotalLib { get; set; }
        public List<CommonCodeViewModel> lstType { get; set; }
        public int TotalType { get; set; }

        public LibraryViewModels DetailLib { get; set; }
        public List<LinksViewModel> ListFile { get; set; }
        public List<TagsViewModel> ListTags { get; set; }
    }

    public class ListUrlFiles
    {
        public string Url { get; set; }

        public static List<ListUrlFiles> Convert(List<string> list)
        {
            if (list == null)
            {
                return new List<ListUrlFiles>();
            }
            var res = from s in list
                      select new ListUrlFiles
                      {
                          Url = s
                      };
            return res.ToList();
        }
    }
}
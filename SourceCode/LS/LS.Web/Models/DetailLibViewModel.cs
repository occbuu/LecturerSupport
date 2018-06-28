using System.Collections.Generic;

namespace LS.Web.Models
{
    public class DetailLibViewModel
    {
        public LibraryViewModels DetailLib { get; set; }
        public List<LinksViewModel> ListFile { get; set; }
        public List<CommentsViewModel> listType { get; set; }
    }
}
using System.Collections.Generic;

namespace LS.Web.Models
{
    public class DetailNewViewModel
    {
        public NewsViewModels DetailNew { get; set; }
        public List<CommentsViewModel> ListComment { get; set; }
        public List<NewsViewModels> ListPopularNews { get; set; }
        public List<LinksViewModel> ListImage { get; set; }
        public int TotalComment { get; set; }
    }
}
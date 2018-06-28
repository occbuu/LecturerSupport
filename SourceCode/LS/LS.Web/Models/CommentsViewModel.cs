using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class CommentsViewModel
    {
        public long Id { get; set; }
        public string CommentType { get; set; }
        public long? ParentId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string CreateDate { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDate { get; set; }
        public long? ObjectLinkID { get; set; }
        public string Level { get; set; }
        public string Content { get; set; }
        public string Avatar { get; set; }
        public string FullName { get; set; }
        public NewsViewModels News { get; set; }


        public static List<CommentsViewModel> Convert(List<Comment> list)
        {
            if (list == null)
            {
                return new List<CommentsViewModel>();
            }

            var res = from s in list
                      select new CommentsViewModel
                      {
                          News = new NewsViewModels()
                          {
                              Title = s.News.Title
                          },
                          Id = s.Id,
                          CommentType = s.CommentType,
                          ParentId = s.ParentId,
                          Status = s.Status,
                          CreatedBy = s.CreatedBy,
                          CreateDate = s.CreateDate.HasValue ? s.CreateDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          ApprovedBy = s.ApprovedBy,
                          ApprovedDate = s.ApprovedDate.HasValue ? s.ApprovedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty,
                          ObjectLinkID = s.ObjectLinkID,
                          Level = s.Level,
                          Content = s.Content,
                          Avatar = s.User.Object.Image,
                          FullName = s.User.Object.FullName
                      };

            return res.ToList();
        }

        public static CommentsViewModel Convert(Comment s)
        {
            if (s == null)
            {
                return new CommentsViewModel();
            }

            var res = new CommentsViewModel
            {
                Id = s.Id,
                CommentType = s.CommentType,
                ParentId = s.ParentId,
                Status = s.Status,
                CreatedBy = s.CreatedBy,
                CreateDate = s.CreateDate.HasValue ? s.CreateDate.Value.ToString("dd/MM/yyyy") : string.Empty,
                ApprovedBy = s.ApprovedBy,
                ApprovedDate = s.ApprovedDate.HasValue ? s.ApprovedDate.Value.ToString("dd/MM/yyyy") : string.Empty,
                ObjectLinkID = s.ObjectLinkID,
                Level = s.Level,
                Content = s.Content,
                Avatar = s.User.Object.Image,
                FullName = s.User.FullName
            };

            return res;
        }
    }
}
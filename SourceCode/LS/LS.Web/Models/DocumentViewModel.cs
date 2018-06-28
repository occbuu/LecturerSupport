using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using BLL;
    using IBLL;
    using Model;
    using Utility;

    public class DocumentViewModel
    {
        public long? Id { set; get; }
        public string Status { set; get; }
        public string CreateBy { set; get; }
        public string CreateOn { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public string Type { set; get; }
        public string CommonId { set; get; }
        public string ModifiedOn { set; get; }
        public string ModifiedBy { set; get; }
        public string Link { set; get; }
        public string FileName { set; get; }
        public string FileExtension { set; get; }
        public long? ClassId { set; get; }
        public string ClassCode { set; get; }
        public string ClassName { set; get; }


        private static ICommonCodeService _commonCodeService = new CommonCodeService();

        public static List<DocumentViewModel> Convert(List<Document> lst)
        {
            if (lst == null)
            {
                return new List<DocumentViewModel>();
            }
            var res = from s in lst
                      select new DocumentViewModel
                      {
                          Id = s.Id,
                          Status = s.Status,
                          Title = s.Title,
                          Content = s.Content,
                          CreateBy = s.CreatedBy,
                          CreateOn = s.CreateDate.HasValue ? s.CreateDate.Value.ToString("MM/dd/yyyy hh:mm") : string.Empty,
                          Type = _commonCodeService.getStrValue1(s.Type, Constants.Document.CommonTypeId),
                          ModifiedOn = s.ModidiedOn.HasValue ? s.ModidiedOn.Value.ToString("MM/dd/yyyy") : string.Empty,
                          ModifiedBy = s.ModidiedBy,
                          Link = s.Linkl,
                          ClassId = s.ClassId,
                          ClassCode = s.Class.Code,
                          ClassName = s.Class.Name,
                          CommonId = s.Type,
                          FileExtension = s.FileExtension,
                          FileName = s.FileName,
                      };
            return res.ToList();
        }
    }

    public class DocumentTypeViewModel
    {
        public string CommonId { set; get; }
        public string Value { set; get; }

        private static ICommonCodeService _commonCodeService = new CommonCodeService();

        public static List<DocumentTypeViewModel> Convert(List<CommonCode> lst)
        {
            if (lst == null)
            {
                return new List<DocumentTypeViewModel>();
            }
            var res = from s in lst
                      select new DocumentTypeViewModel
                      {
                          CommonId = s.CommonId,
                          Value = s.StrValue1,
                      };
            return res.ToList();
        }
    }
}
namespace LS.Web.Models
{
    using Model;
    using System;

    public class DetailClassViewModel
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Prerequisition { set; get; }
        public DateTime? StartDate { set; get; }
        public DateTime? EndDate { set; get; }
        public string Images { set; get; }
        public static DetailClassViewModel Convert(Class c)
        {
            if (c == null)
            {
                return new DetailClassViewModel();
            }
            var res = new DetailClassViewModel();
            res.Id = c.Id;
            res.Name = c.Name;
            res.Description = c.Description;
            res.Prerequisition = c.Prerequisition;
            res.StartDate = c.StartDate;
            res.EndDate = c.EndDate;
            res.Images = c.Images;
            return res;
        }
    }
}
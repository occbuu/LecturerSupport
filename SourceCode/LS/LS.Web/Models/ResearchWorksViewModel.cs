using System.Collections.Generic;
using System.Linq;

namespace LS.Web.Models
{
    using Model;

    public class ResearchWorksViewModel
    {
        public List<ResearchWorkVM> ResearchWork { set; get; }
        public List<BookVM> Book { set; get; }
        public List<JournalArticlesVM> JournalArticles { set; get; }
    }

    #region -- Research Work --

    public class ResearchWorkDetailVM
    {
        public string Brief { set; get; }
        public string Value1 { set; get; }
        public string Value2 { set; get; }
        public string Name { set; get; }
        public static List<ResearchWorkDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<ResearchWorkDetailVM>();
            }
            var res = from s in lst
                      select new ResearchWorkDetailVM
                      {
                          Brief = s.brief,
                          Value1 = s.Value,
                          Value2 = s.CreatedBy,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NameResearchWorkVM
    {
        public string Brief { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public string Time { set; get; }
        public List<ResearchWorkDetailVM> ResearchWorkDetail { set; get; }
        public static List<NameResearchWorkVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameResearchWorkVM>();
            }
            var res = from s in lst
                      select new NameResearchWorkVM
                      {
                          Brief = s.brief,
                          Name = s.Name,
                          Value = s.Value,
                          Time = s.CreatedBy
                      };
            return res.ToList();
        }
    }

    public class ResearchWorkVM
    {
        public string Brief { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NameResearchWorkVM> NameResearchWork { set; get; }
    }

    #endregion

    #region -- BOOKS --

    public class BookDetailVM
    {
        public string Brief { set; get; }
        public string Value { set; get; }
        public string Name { set; get; }
        public static List<BookDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<BookDetailVM>();
            }
            var res = from s in lst
                      select new BookDetailVM
                      {
                          Brief = s.brief,
                          Value = s.Value,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NameBookVM
    {
        public string Brief { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public string Time { set; get; }
        public List<BookDetailVM> BookDetail { set; get; }
        public static List<NameBookVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameBookVM>();
            }
            var res = from s in lst
                      select new NameBookVM
                      {
                          Brief = s.brief,
                          Name = s.Name,
                          Value = s.Value,
                          Time = s.URL1
                      };
            return res.ToList();
        }
    }

    public class BookVM
    {
        public string Brief { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NameBookVM> NameBook { set; get; }
    }

    #endregion

    #region -- JOURNAL ARTICLES --

    public class JournalArticlesDetailVM
    {
        public string Brief { set; get; }
        public string Value { set; get; }
        public string Name { set; get; }
        public static List<JournalArticlesDetailVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<JournalArticlesDetailVM>();
            }
            var res = from s in lst
                      select new JournalArticlesDetailVM
                      {
                          Brief = s.brief,
                          Value = s.Value,
                          Name = s.Name
                      };
            return res.ToList();
        }
    }

    public class NameJournalArticlesVM
    {
        public string Brief { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public string Time { set; get; }
        public List<JournalArticlesDetailVM> JournalArticlesDetail { set; get; }
        public static List<NameJournalArticlesVM> Convert(List<SiteInfo> lst)
        {
            if (lst == null)
            {
                return new List<NameJournalArticlesVM>();
            }
            var res = from s in lst
                      select new NameJournalArticlesVM
                      {
                          Brief = s.brief,
                          Name = s.Name,
                          Value = s.Value,
                          Time = s.URL1
                      };
            return res.ToList();
        }
    }

    public class JournalArticlesVM
    {
        public string Brief { set; get; }
        public string Lang { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
        public List<NameJournalArticlesVM> NameJournalArticles { set; get; }
    }

    #endregion
}
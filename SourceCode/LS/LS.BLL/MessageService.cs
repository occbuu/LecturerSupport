using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace LS.BLL
{
    using LS.DAL;
    using LS.IBLL;
    using LS.IDAL;
    using LS.Model;

    public class MessageService : Repository<Message>, IMessageService
    {

        private IMessageDao MessageDao = new MessageDao();

        public List<Message> ExcelMessage(string keyWord, string status, DateTime? ftt, DateTime? ttt)
        {
            var data = new List<Message>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.FullName.Contains(keyWord)))
                            && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status.Equals(status)))
                            && (x.CreatedDate.Value.CompareTo(ftt.Value) >= 0 && x.CreatedDate.Value.CompareTo(ttt.Value) <= 0)
                        ).Where(x => x.MessageType == "LienHe").ToList();
            }
            else
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWord) || (!string.IsNullOrEmpty(keyWord) && x.FullName.Contains(keyWord)))
                        && (string.IsNullOrEmpty(status) || (!string.IsNullOrEmpty(status) && x.Status.Equals(status)))

                        ).Where(x => x.MessageType == "LienHe").ToList(); ;
            }
            return data;
        }

        public int getTotalNewMessages(string type)
        {
            var ls = SearchFor2(x => x.Status == "1" && x.MessageType == type);
            return ls.Count();
        }
        public IList<Message> getAllMessage_Status(string stt1, string stt2, string type, int pageSize, int pageNumber, out int recordCount)
        {
            var ls = SearchFor2(x => (x.Status == stt1 || x.Status == stt2) && x.MessageType == type).OrderByDescending(x => x.CreatedDate)
                .Skip((pageNumber - 1) * pageSize).Take(pageSize)
                .ToList();
            recordCount = SearchFor2(x => (x.Status == stt1 || x.Status == stt2) && x.MessageType == type).OrderByDescending(x => x.CreatedDate).ToList().Count;
            return ls;
        }

        public void DeleteListMessage(string lsId)
        {
            using (var tran = new TransactionScope())
            {
                string[] ls = lsId.Split(';');
                if (ls.Count() > 0)
                {
                    foreach (var item in ls)
                    {
                        //int iid = long.Parse(item);
                        if (!string.IsNullOrEmpty(item))
                        {
                            Message ms = MessageDao.GetById(Int64.Parse(item));
                            MessageDao.Delete(ms);
                        }

                    }

                }
                tran.Complete();
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using LS.Model;

    public interface IMessageService: IRepository<Message>
    {
        List<Message> ExcelMessage(string keyWord, string status, DateTime? ftt, DateTime? ttt);
        IList<Message> getAllMessage_Status(string stt1, string stt2, string type, int pageSize, int pageNumber, out int recordCount);
        void DeleteListMessage(string lsId);
        int getTotalNewMessages(string type);
    }
}
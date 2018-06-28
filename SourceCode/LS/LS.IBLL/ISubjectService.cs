using System;
using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ISubjectService : IRepository<Subject>
    {
        List<Subject> SeachBySubjectName(string subjectName);

        List<Subject> getListPost(string keyWord, DateTime? ftt, DateTime? ttt);

        void DeleteListSubject(List<string> lsId);
    }
}
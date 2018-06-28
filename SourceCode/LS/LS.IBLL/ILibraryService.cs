using System;
using System.Collections.Generic;

namespace LS.IBLL
{

    using Model;


    public interface ILibraryService : IRepository<Library>
    {
        /// <summary>
        /// Get Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>List Type</returns>

        List<Library> SeachByType(string type);

        List<Library> SearchCate(string type, int pageNumber, int pageSize, out int count);

        List<Library> GetType();

        Library GetDetailLib(long libId);

        long GetMaxId();

        List<Library> getListLibrary(string type, string keyWord, DateTime? ftt, DateTime? ttt);

        List<Library> ChangeLib(string type);

        void DeleteListLib(List<string> lsId);

    }
}
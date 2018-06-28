using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface ICommonCodeService : IRepository<CommonCode>
    {
        /// <summary>
        /// Get category by type
        /// </summary>
        /// <param name="type">Common type id</param>
        /// <returns>List category</returns>
        List<CommonCode> GetCategoryId(string type);

        /// <summary>
        /// Get children category by common id
        /// </summary>
        /// <param name="commonId"> Common id</param>
        /// <returns>List children Category </returns>
        List<CommonCode> GetCategoryIdChild(string commonId);

        /// <summary>
        /// Get children category by common id
        /// </summary>
        /// <param name="commonId"> Common id</param>
        /// <returns>List children Category </returns>
        List<CommonCode> GetCommonTypeId();

        List<CommonCode> SearchByStrValue(string value);

        List<CommonCode> SearchByCommonTypeId(string commonTypeId);

        /// <summary>
        /// Get string value 1 by category id
        /// </summary>
        /// <param name="categoryId">Category id</param>
        /// <param name="commonTypeId">Common type id</param>
        /// <returns></returns>
        string getStrValue1(string commonId, string commonTypeId);

        List<CommonCode> SearchByCommonIdAndCommonType(string commonId, string commonTypeId);

        /// <summary>
        /// Get List CategoryId News 
        /// </summary>
        /// <param name="commonId"></param>
        /// <param name="commonTypeId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        List<CommonCode> SearchByCommonIdAndCommonTypeWithPagination(string commonId, string commonTypeId, int pageNumber, int pageSize, out int count);

        /// <summary>
        /// Get List child category news
        /// </summary>
        /// <param name="commonParent">common id parent</param>
        /// <returns></returns>
        List<CommonCode> GetCommonChildByCommonParent(string commonParent);

        /// <summary>
        /// Get a list of common code by commonTypeId and commonId
        /// </summary>
        /// <param name="commonTypeId"></param>
        /// <param name="commonId"></param>
        /// <returns></returns>
        List<CommonCode> GetValue1(string commonTypeId, string commonId);

        List<CommonCode> SearchParentCommonIdByCommonTypeId(string commonTypeId, decimal level);
		
        List<CommonCode> GetListPostType();

    }
}
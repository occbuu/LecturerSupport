namespace LS.IBLL
{
    using Model;
    using System.Collections.Generic;

    public interface ILinksService : IRepository<Link>
    {
        void SetMainImage(long id, string objectId);

        /// <summary>
        /// Limits the maximum number of image in a post
        /// </summary>
        /// <param name="id">Id of post</param>
        /// <returns></returns>
        int LimitMaxImage(string id);

        /// <summary>
        /// Get iamges of post
        /// </summary>
        /// <param name="id">Id of post</param>
        /// <returns>List images</returns>
        List<Link> GetImagesOfPost(string id);

        List<Link> GetFiles(string id);

        List<string> GetUrlImagesOfPost(string id);
    }
}
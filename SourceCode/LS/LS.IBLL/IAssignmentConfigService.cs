using System.Collections.Generic;

namespace LS.IBLL
{
    using Model;

    public interface IAssignmentConfigService : IRepository<AssignmentConfig>
    {
        /// <summary>
        /// Get a list of AssignmentConfig by DocumentId , ClassId
        /// </summary>
        /// <param name="docId">DocumentId</param>
        /// <param name="classId">ClassId</param>
        /// <returns></returns>
        List<AssignmentConfig> GetAssignmentConfig(long? docId, long? classId);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.SqlServer;

namespace LS.BLL
{
    using DAL;
    using IBLL;
    using IDAL;
    using Model;
    using Utility;

    public class AssignmentConfigService : Repository<AssignmentConfig>, IAssignmentConfigService
    {
        /// <summary>
        /// Get a list of AssignmentConfig by DocumentId , ClassId
        /// </summary>
        /// <param name="docId">DocumentId</param>
        /// <param name="classId">ClassId</param>
        /// <returns></returns>
        public List<AssignmentConfig> GetAssignmentConfig(long? docId, long? classId)
        {
            var lstAgC = new List<AssignmentConfig>();
            IQueryable<AssignmentConfig> temp = null;

            if(docId != null && classId!=null)
            {
                temp = SearchFor2(x => x.DocumentId == docId && x.ClassId == classId && x.Status != Constants.AssignmentConfig_Status.DeleteStatus);
                lstAgC = temp.ToList();
            }
            return lstAgC;
        }
    }
}
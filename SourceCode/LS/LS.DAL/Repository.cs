using LS.IDAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace LS.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _context = new Model.LSDBEntities();
        private IDbSet<T> _entities;

        private IDbSet<T> Entities
        {
            get
            {
                return _entities ?? (_entities = _context.Set<T>());
            }
        }
        public List<T> GetAll()
        {
            return Entities.ToList<T>();
        }

        public T GetById(object id)
        {
            return Entities.Find(id);
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                Entities.Add(entity);
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = dbEx.EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors).Aggregate(string.Empty, (current, validationError) => current + (string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine));

                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                Entities.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = dbEx.EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors).Aggregate(string.Empty, (current, validationError) => current + (Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage)));
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                Entities.Remove(entity);
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = dbEx.EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors).Aggregate(string.Empty, (current, validationError) => current + (Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage)));
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }

        public List<T> SearchFor(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            try
            {
                if (predicate == null)
                {
                    throw new ArgumentNullException("entity");
                }

                return Entities.Where(predicate).ToList();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = dbEx.EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors).Aggregate(string.Empty, (current, validationError) => current + (string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine));

                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }

        public IQueryable<T> SearchFor2(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            try
            {
                if (predicate == null)
                {
                    throw new ArgumentNullException("entity");
                }

                return Entities.Where(predicate);
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = dbEx.EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors).Aggregate(string.Empty, (current, validationError) => current + (string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine));

                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }

        public int ExecuteSqlCommand(string query)
        {
            return _context.Database.ExecuteSqlCommand(query);
        }

        public List<T> ExecuteSQLQuery(string query, object[] parameters)
        {
            return _context.Database.SqlQuery<T>(query, parameters).ToList<T>();
        }

        public List<T> ExecuteStoredProcedure(string spName, object[] parameters)
        {
            return _context.Database.SqlQuery<T>(spName, parameters).ToList<T>();
        }

        public string ExecuteScalar(string query, object[] parameters)
        {
            var result = _context.Database.SqlQuery<string>(query, parameters).ToList();

            return result[0];
        }

        public IDbSet<T2> GetDBSet<T2>() where T2 : class
        {
            return _context.Set<T2>();
        }

        private static JsonSerializerSettings GetJsonSerializerSettings
        {
            get
            {
                if (jsonSerializerSettings == null)
                {
                    jsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
                    {
                        ContractResolver = new MCContracResolver(),
                        MaxDepth = 10,
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore,
                    };
                }
                return jsonSerializerSettings;
            }
        }
        private static JsonSerializerSettings jsonSerializerSettings;
    }

    public class MCContracResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
    {
        public MCContracResolver()
        { }

        protected override Newtonsoft.Json.Serialization.JsonContract CreateContract(Type objectType)
        { return base.CreateContract(objectType); }

        protected override Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(Type objectType)
        { return base.CreateObjectContract(objectType); }

        public override Newtonsoft.Json.Serialization.JsonContract ResolveContract(Type type)
        { return base.ResolveContract(type); }

        protected override Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, MemberSerialization memberSerialization)
        {
            Newtonsoft.Json.Serialization.JsonProperty jp = base.CreateProperty(member, memberSerialization);

            #region for PaymentRequest
            if (member.Name == "EntityType")
                jp.Ignored = true;
            if (member.Name == "RecordId")
                jp.Ignored = true;
            if (member.Name == "RecordReference")
                jp.Ignored = true;
            if (member.Name == "InstitutionDisplayName")
                jp.Ignored = true;
            if (member.Name == "InvoiceNoDisplayName")
                jp.Ignored = true;
            if (member.Name == "SubDateFrom")
                jp.Ignored = true;
            if (member.Name == "SubDateTo")
                jp.Ignored = true;
            if (member.Name == "VendorName")
                jp.Ignored = true;
            if (member.Name == "SearchFor")
                jp.Ignored = true;
            if (member.Name == "SearchUser")
                jp.Ignored = true;
            if (member.Name == "InvoiceNo")
                jp.Ignored = true;
            if (member.Name == "Institution")
                jp.Ignored = true;
            if (member.Name == "CostCentre")
                jp.Ignored = true;
            if (member.Name == "VendorMaster")
                jp.Ignored = true;
            if (member.Name == "PaymentTerm")
                jp.Ignored = true;
            if (member.Name == "GeneralLedger")
                jp.Ignored = true;
            if (member.Name == "InternalOrder")
                jp.Ignored = true;
            if (member.Name == "ExchangeRate")
                jp.Ignored = true;
            #endregion

            #region for Institution
            if (member.Name == "CostCentres")
                jp.Ignored = true;
            if (member.Name == "GeneralLedgers")
                jp.Ignored = true;
            if (member.Name == "InternalOrders")
                jp.Ignored = true;
            if (member.Name == "PaymentRequests")
                jp.Ignored = true;
            if (member.Name == "ChangeApprovers")
                jp.Ignored = true;
            if (member.Name == "Role")
                jp.Ignored = true;
            if (member.Name == "RoleChangeApprover")
                jp.Ignored = true;
            if (member.Name == "VendorMasters")
                jp.Ignored = true;
            #endregion

            #region for PaymentTerms
            if (member.ReflectedType.Name.IndexOf("PaymentTerm") >= 0 && member.Name == "RequestPayees")
                jp.Ignored = true;
            #endregion

            #region for CostCentre
            if (member.ReflectedType.Name.IndexOf("CostCentre") >= 0 && member.Name == "PaymentRequests")
                jp.Ignored = true;
            if (member.ReflectedType.Name.IndexOf("CostCentre") >= 0 && member.Name == "RequestAllocations")
                jp.Ignored = true;
            if (member.Name == "Users")
                jp.Ignored = true;
            #endregion

            #region for GeneralLedger
            if (member.ReflectedType.Name.IndexOf("GeneralLedger") >= 0 && member.Name == "RequestAllocations")
                jp.Ignored = true;
            if (member.ReflectedType.Name.IndexOf("GeneralLedger") >= 0 && member.Name == "InstitutionGLs")
                jp.Ignored = true;
            #endregion

            #region for InternalOrder
            if (member.ReflectedType.Name.IndexOf("InternalOrder") >= 0 && member.Name == "RequestAllocations")
                jp.Ignored = true;
            #endregion

            #region for Attachment
            if (member.Name == "MaintainDocuments")
                jp.Ignored = true;
            #endregion

            #region for Role
            if (member.Name == "Institutions")
                jp.Ignored = true;
            if (member.Name == "UserRoles")
                jp.Ignored = true;
            if (member.Name == "InstitutionsChangeApprover")
                jp.Ignored = true;
            #endregion

            return jp;
        }
    }
}
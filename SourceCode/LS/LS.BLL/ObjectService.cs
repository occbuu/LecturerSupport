using System;
using System.Collections.Generic;
using System.Linq;

namespace LS.BLL
{
    using LS.IBLL;
    using LS.Model;
    //using LS.Utility;

    public class ObjectService : Repository<Object>, IObjectService
    {
        public void Insert2(Object entity, string objectType)
        {
            entity.ObjectId = CreateObjectId(objectType);
            Insert(entity);
        }

        public List<Object> ManageCustomer(string keyWordSearch, DateTime? ftt, DateTime? ttt)
        {
            var data = new List<Object>();

            if (ftt != null && ttt != null)
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWordSearch) || (!string.IsNullOrEmpty(keyWordSearch) && x.FullName.Contains(keyWordSearch)))
                            //&& (string.IsNullOrEmpty(KeyWordMTD) || (!string.IsNullOrEmpty(KeyWordMTD) && x.MaTD.Contains(KeyWordMTD)))
                            && (x.CreatedDate.Value.CompareTo(ftt.Value) >= 0 && x.CreatedDate.Value.CompareTo(ttt.Value) <= 0)
                        );
            }
            else
            {
                data = this.SearchFor(x =>
                               (string.IsNullOrEmpty(keyWordSearch) || (!string.IsNullOrEmpty(keyWordSearch) && x.FullName.Contains(keyWordSearch)))
                        //&& (string.IsNullOrEmpty(KeyWordMTD) || (!string.IsNullOrEmpty(KeyWordMTD) && x.MaTD.Contains(KeyWordMTD)))

                        );
            }
            return data;
        }
        //public string GetObjectId()
        //{
        //    return CreateObjectId("44");
        //}

        private string CreateObjectId(string type)
        {
            var day = DateTime.Now.ToString("yyyyMMdd");
            string ObjectId = "";
            var data = new List<Object>();
            data = this.SearchFor2(x => ((x.ObjectId).Contains(type + day))).OrderByDescending(b => b.ObjectId).ToList();
            if (data.Count() == 0)
            {
                ObjectId = type + day + "0001";
            }
            else
            {
                ObjectId = (Int64.Parse(data[0].ObjectId) + 1).ToString();
            }

            return ObjectId;
        }

    }
}
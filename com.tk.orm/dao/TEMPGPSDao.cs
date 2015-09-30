using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class TEMPGPSDao
    {
        public static int Insert(TEMPGPS t)
        {
            return BaseDA.Insert<TEMPGPS>("InsertTEMPGPS",t);
        }

        public static int Update(TEMPGPS t)
        {
            return BaseDA.Update<TEMPGPS>("UpdateTEMPGPS", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteTEMPGPSById", primaryKeyId);
        }

        public static TEMPGPS Get(int primaryKeyId)
        {
            return BaseDA.Get<TEMPGPS>("SelectTEMPGPSById", primaryKeyId);
        }

        public static IList<TEMPGPS> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<TEMPGPS>("SelectAllTEMPGPS", parameterObject);
        }
    }
}


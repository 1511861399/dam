using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class GPSINFODao
    {
        public static int Insert(GPSINFO t)
        {
            return BaseDA.Insert<GPSINFO>("InsertGPSINFO",t);
        }

        public static int Update(GPSINFO t)
        {
            return BaseDA.Update<GPSINFO>("UpdateGPSINFO", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteGPSINFOById", primaryKeyId);
        }

        public static GPSINFO Get(int primaryKeyId)
        {
            return BaseDA.Get<GPSINFO>("SelectGPSINFOById", primaryKeyId);
        }

        public static IList<GPSINFO> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<GPSINFO>("SelectAllGPSINFO", parameterObject);
        }
    }
}


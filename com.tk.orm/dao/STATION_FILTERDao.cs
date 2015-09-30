using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class STATION_FILTERDao
    {
        public static int Insert(STATION_FILTER t)
        {
            return BaseDA.Insert<STATION_FILTER>("InsertSTATION_FILTER",t);
        }

        public static int Update(STATION_FILTER t)
        {
            return BaseDA.Update<STATION_FILTER>("UpdateSTATION_FILTER", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteSTATION_FILTERById", primaryKeyId);
        }

        public static STATION_FILTER Get(int primaryKeyId)
        {
            return BaseDA.Get<STATION_FILTER>("SelectSTATION_FILTERById", primaryKeyId);
        }

        public static IList<STATION_FILTER> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<STATION_FILTER>("SelectAllSTATION_FILTER", parameterObject);
        }
    }
}


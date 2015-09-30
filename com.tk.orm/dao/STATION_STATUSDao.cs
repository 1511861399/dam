using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class STATION_STATUSDao
    {
        public static int Insert(STATION_STATUS t)
        {
            return BaseDA.Insert<STATION_STATUS>("InsertSTATION_STATUS",t);
        }

        public static int Update(STATION_STATUS t)
        {
            return BaseDA.Update<STATION_STATUS>("UpdateSTATION_STATUS", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteSTATION_STATUSById", primaryKeyId);
        }

        public static STATION_STATUS Get(int primaryKeyId)
        {
            return BaseDA.Get<STATION_STATUS>("SelectSTATION_STATUSById", primaryKeyId);
        }

        public static IList<STATION_STATUS> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<STATION_STATUS>("SelectAllSTATION_STATUS", parameterObject);
        }
    }
}


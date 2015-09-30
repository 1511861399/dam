using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class STATION_ORIGINALDao
    {
        public static int Insert(STATION_ORIGINAL t)
        {
            return BaseDA.Insert<STATION_ORIGINAL>("InsertSTATION_ORIGINAL",t);
        }

        public static int Update(STATION_ORIGINAL t)
        {
            return BaseDA.Update<STATION_ORIGINAL>("UpdateSTATION_ORIGINAL", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteSTATION_ORIGINALById", primaryKeyId);
        }

        public static STATION_ORIGINAL Get(int primaryKeyId)
        {
            return BaseDA.Get<STATION_ORIGINAL>("SelectSTATION_ORIGINALById", primaryKeyId);
        }

        public static IList<STATION_ORIGINAL> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<STATION_ORIGINAL>("SelectAllSTATION_ORIGINAL", parameterObject);
        }
    }
}


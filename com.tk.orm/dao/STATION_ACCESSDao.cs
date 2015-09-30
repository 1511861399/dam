using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class STATION_ACCESSDao
    {
        public static int Insert(STATION_ACCESS t)
        {
            return BaseDA.Insert<STATION_ACCESS>("InsertSTATION_ACCESS",t);
        }

        public static int Update(STATION_ACCESS t)
        {
            return BaseDA.Update<STATION_ACCESS>("UpdateSTATION_ACCESS", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteSTATION_ACCESSById", primaryKeyId);
        }

        public static STATION_ACCESS Get(int primaryKeyId)
        {
            return BaseDA.Get<STATION_ACCESS>("SelectSTATION_ACCESSById", primaryKeyId);
        }

        public static IList<STATION_ACCESS> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<STATION_ACCESS>("SelectAllSTATION_ACCESS", parameterObject);
        }
    }
}


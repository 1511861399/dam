using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class T_STATIONDao
    {
        public static object Insert(T_STATION t)
        {
            return BaseDA.Insert<T_STATION>("InsertT_STATION", t);
        }

        public static int Update(T_STATION t)
        {
            return BaseDA.Update<T_STATION>("UpdateT_STATION", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteT_STATIONById", primaryKeyId);
        }

        public static T_STATION Get(int primaryKeyId)
        {
            return BaseDA.Get<T_STATION>("SelectT_STATIONById", primaryKeyId);
        }

        public static IList<T_STATION> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<T_STATION>("SelectAllT_STATION", parameterObject);
        }
    }
}


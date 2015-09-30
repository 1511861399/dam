using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class STATIONDao
    {
        public static int Insert(STATION t)
        {
            return BaseDA.Insert<STATION>("InsertSTATION",t);
        }

        public static int Update(STATION t)
        {
            return BaseDA.Update<STATION>("UpdateSTATION", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteSTATIONById", primaryKeyId);
        }

        public static STATION Get(int primaryKeyId)
        {
            return BaseDA.Get<STATION>("SelectSTATIONById", primaryKeyId);
        }

        public static IList<STATION> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<STATION>("SelectAllSTATION", parameterObject);
        }
    }
}


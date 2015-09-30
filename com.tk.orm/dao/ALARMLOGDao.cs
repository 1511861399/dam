using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class ALARMLOGDao
    {
        public static int Insert(ALARMLOG t)
        {
            return BaseDA.Insert<ALARMLOG>("InsertALARMLOG",t);
        }

        public static int Update(ALARMLOG t)
        {
            return BaseDA.Update<ALARMLOG>("UpdateALARMLOG", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteALARMLOGById", primaryKeyId);
        }

        public static ALARMLOG Get(int primaryKeyId)
        {
            return BaseDA.Get<ALARMLOG>("SelectALARMLOGById", primaryKeyId);
        }

        public static IList<ALARMLOG> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<ALARMLOG>("SelectAllALARMLOG", parameterObject);
        }
    }
}


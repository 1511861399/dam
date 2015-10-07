using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class ALARMAPPENDDao
    {
        public static object Insert(ALARMAPPEND t)
        {
            return BaseDA.Insert<ALARMAPPEND>("InsertALARMAPPEND",t);
        }

        public static int Update(ALARMAPPEND t)
        {
            return BaseDA.Update<ALARMAPPEND>("UpdateALARMAPPEND", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteALARMAPPENDById", primaryKeyId);
        }

        public static ALARMAPPEND Get(int primaryKeyId)
        {
            return BaseDA.Get<ALARMAPPEND>("SelectALARMAPPENDById", primaryKeyId);
        }

        public static IList<ALARMAPPEND> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<ALARMAPPEND>("SelectAllALARMAPPEND", parameterObject);
        }
    }
}


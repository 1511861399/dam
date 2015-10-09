using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class AlAlarmLog
    {
        public static object Insert(AlarmLog t)
        {
            return BaseDA.Insert<AlarmLog>("InsertAlarmLog", t);
        }

        public static int Update(AlarmLog t)
        {
            return BaseDA.Update<AlarmLog>("UpdateAlarmLog", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteAlarmLogById", primaryKeyId);
        }

        public static AlarmLog Get(int primaryKeyId)
        {
            return BaseDA.Get<AlarmLog>("SelectAlarmLogById", primaryKeyId);
        }

        public static IList<AlarmLog> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<AlarmLog>("SelectAllAlarmLog", parameterObject);
        }
    }
}


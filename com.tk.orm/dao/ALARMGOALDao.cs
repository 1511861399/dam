using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class ALARMGOALDao
    {
        public static object Insert(ALARMGOAL t)
        {
            return BaseDA.Insert<ALARMGOAL>("InsertALARMGOAL",t);
        }

        public static int Update(ALARMGOAL t)
        {
            return BaseDA.Update<ALARMGOAL>("UpdateALARMGOAL", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteALARMGOALById", primaryKeyId);
        }

        public static ALARMGOAL Get(int primaryKeyId)
        {
            return BaseDA.Get<ALARMGOAL>("SelectALARMGOALById", primaryKeyId);
        }

        public static IList<ALARMGOAL> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<ALARMGOAL>("SelectAllALARMGOAL", parameterObject);
        }
    }
}


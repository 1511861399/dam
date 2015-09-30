using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class ALARMSETTINGDao
    {
        public static int Insert(ALARMSETTING t)
        {
            return BaseDA.Insert<ALARMSETTING>("InsertALARMSETTING",t);
        }

        public static int Update(ALARMSETTING t)
        {
            return BaseDA.Update<ALARMSETTING>("UpdateALARMSETTING", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteALARMSETTINGById", primaryKeyId);
        }

        public static ALARMSETTING Get(int primaryKeyId)
        {
            return BaseDA.Get<ALARMSETTING>("SelectALARMSETTINGById", primaryKeyId);
        }

        public static IList<ALARMSETTING> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<ALARMSETTING>("SelectAllALARMSETTING", parameterObject);
        }
    }
}


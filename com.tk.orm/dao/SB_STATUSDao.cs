using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class SB_STATUSDao
    {
        public static object Insert(SB_STATUS t)
        {
            return BaseDA.Insert<SB_STATUS>("InsertSB_STATUS",t);
        }

        public static int Update(SB_STATUS t)
        {
            return BaseDA.Update<SB_STATUS>("UpdateSB_STATUS", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteSB_STATUSById", primaryKeyId);
        }

        public static SB_STATUS Get(int primaryKeyId)
        {
            return BaseDA.Get<SB_STATUS>("SelectSB_STATUSById", primaryKeyId);
        }

        public static IList<SB_STATUS> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<SB_STATUS>("SelectAllSB_STATUS", parameterObject);
        }
    }
}


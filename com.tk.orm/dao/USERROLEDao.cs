using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class USERROLEDao
    {
        public static int Insert(USERROLE t)
        {
            return BaseDA.Insert<USERROLE>("InsertUSERROLE",t);
        }

        public static int Update(USERROLE t)
        {
            return BaseDA.Update<USERROLE>("UpdateUSERROLE", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteUSERROLEById", primaryKeyId);
        }

        public static USERROLE Get(int primaryKeyId)
        {
            return BaseDA.Get<USERROLE>("SelectUSERROLEById", primaryKeyId);
        }

        public static IList<USERROLE> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<USERROLE>("SelectAllUSERROLE", parameterObject);
        }
    }
}


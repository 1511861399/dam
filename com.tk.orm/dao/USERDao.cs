using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class USERDao
    {
        public static int Insert(USER t)
        {
            return BaseDA.Insert<USER>("InsertUSER",t);
        }

        public static int Update(USER t)
        {
            return BaseDA.Update<USER>("UpdateUSER", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteUSERById", primaryKeyId);
        }

        public static USER Get(int primaryKeyId)
        {
            return BaseDA.Get<USER>("SelectUSERById", primaryKeyId);
        }

        public static IList<USER> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<USER>("SelectAllUSER", parameterObject);
        }
    }
}


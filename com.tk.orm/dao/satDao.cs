using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class satDao
    {
         public static int Insert(sat t)
        {
            return BaseDA.Insert<sat>("Insertsat", t);
        }

         public static int Update(sat t)
        {
            return BaseDA.Update<sat>("Updatesat", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeletesatById", primaryKeyId);
        }

        public static sat Get(int primaryKeyId)
        {
            return BaseDA.Get<sat>("SelectsatById", primaryKeyId);
        }

        public static IList<sat> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<sat>("SelectAllsat", parameterObject);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class RIGHTDao
    {
        public static object Insert(RIGHT t)
        {
            return BaseDA.Insert<RIGHT>("InsertRIGHT",t);
        }

        public static int Update(RIGHT t)
        {
            return BaseDA.Update<RIGHT>("UpdateRIGHT", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteRIGHTById", primaryKeyId);
        }

        public static RIGHT Get(int primaryKeyId)
        {
            return BaseDA.Get<RIGHT>("SelectRIGHTById", primaryKeyId);
        }

        public static IList<RIGHT> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<RIGHT>("SelectAllRIGHT", parameterObject);
        }
    }
}


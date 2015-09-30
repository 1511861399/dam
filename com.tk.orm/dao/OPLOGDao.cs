using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class OPLOGDao
    {
        public static int Insert(OPLOG t)
        {
            return BaseDA.Insert<OPLOG>("InsertOPLOG",t);
        }

        public static int Update(OPLOG t)
        {
            return BaseDA.Update<OPLOG>("UpdateOPLOG", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteOPLOGById", primaryKeyId);
        }

        public static OPLOG Get(int primaryKeyId)
        {
            return BaseDA.Get<OPLOG>("SelectOPLOGById", primaryKeyId);
        }

        public static IList<OPLOG> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<OPLOG>("SelectAllOPLOG", parameterObject);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class SATDao
    {
        public static int Insert(SAT t)
        {
            return BaseDA.Insert<SAT>("InsertSAT",t);
        }

        public static int Update(SAT t)
        {
            return BaseDA.Update<SAT>("UpdateSAT", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteSATById", primaryKeyId);
        }

        public static SAT Get(int primaryKeyId)
        {
            return BaseDA.Get<SAT>("SelectSATById", primaryKeyId);
        }

        public static IList<SAT> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<SAT>("SelectAllSAT", parameterObject);
        }
    }
}


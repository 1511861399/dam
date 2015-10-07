using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class ROLERIGHTDao
    {
        public static object Insert(ROLERIGHT t)
        {
            return BaseDA.Insert<ROLERIGHT>("InsertROLERIGHT",t);
        }

        public static int Update(ROLERIGHT t)
        {
            return BaseDA.Update<ROLERIGHT>("UpdateROLERIGHT", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteROLERIGHTById", primaryKeyId);
        }

        public static ROLERIGHT Get(int primaryKeyId)
        {
            return BaseDA.Get<ROLERIGHT>("SelectROLERIGHTById", primaryKeyId);
        }

        public static IList<ROLERIGHT> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<ROLERIGHT>("SelectAllROLERIGHT", parameterObject);
        }
    }
}


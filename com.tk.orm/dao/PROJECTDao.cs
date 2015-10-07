using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class PROJECTDao
    {
        public static object Insert(PROJECT t)
        {
            return BaseDA.Insert<PROJECT>("InsertPROJECT",t);
        }

        public static int Update(PROJECT t)
        {
            return BaseDA.Update<PROJECT>("UpdatePROJECT", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeletePROJECTById", primaryKeyId);
        }

        public static PROJECT Get(int primaryKeyId)
        {
            return BaseDA.Get<PROJECT>("SelectPROJECTById", primaryKeyId);
        }

        public static IList<PROJECT> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<PROJECT>("SelectAllPROJECT", parameterObject);
        }
    }
}


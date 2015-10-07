using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class ROLEDao
    {
        public static object Insert(ROLE t)
        {
            return BaseDA.Insert<ROLE>("InsertROLE",t);
        }

        public static int Update(ROLE t)
        {
            return BaseDA.Update<ROLE>("UpdateROLE", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeleteROLEById", primaryKeyId);
        }

        public static ROLE Get(int primaryKeyId)
        {
            return BaseDA.Get<ROLE>("SelectROLEById", primaryKeyId);
        }

        public static IList<ROLE> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<ROLE>("SelectAllROLE", parameterObject);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
namespace com.tk.orm.dao
{
     public class stationDao
    {
        public static object Insert(station t)
        {
            return BaseDA.Insert<station>("Insertstation",t);
        }

        public static int Update(station t)
        {
            return BaseDA.Update<station>("Updatestation", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("DeletestationById", primaryKeyId);
        }

        public static station Get(int primaryKeyId)
        {
            return BaseDA.Get<station>("SelectstationById", primaryKeyId);
        }

        public static IList<station> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<station>("SelectAllstation", parameterObject);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.tk.orm.dao
{
     public class Product
    {
        public static int Insert(Product t)
        {
            return BaseDA.Insert<Product>("",t);
        }

        public static int Update(Product t)
        {
            return BaseDA.Update<Product>("", t);
        }

        public static int Delete(int primaryKeyId)
        {
            return BaseDA.Delete("", primaryKeyId);
        }

        public static Product Get(int primaryKeyId)
        {
            return BaseDA.Get<Product>("", primaryKeyId);
        }

        public static IList<Product> QueryForList(object parameterObject = null)
        {
            return BaseDA.QueryForList<Product>("", parameterObject);
        }
    }
}

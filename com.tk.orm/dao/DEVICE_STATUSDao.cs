using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
using System.Collections;
namespace com.tk.orm.dao
{
     public class DEVICE_STATUSDao
    {
         public static object Insert(DEVICE_STATUS parameterObject, string tableName)
        {
            Hashtable inparam = new Hashtable();
            if (parameterObject != null)
            {
                if (parameterObject.aDatetime != null)
                {
                    inparam.Add("aDatetime", parameterObject.aDatetime);
                }
                if (parameterObject.dltaH != null)
                {
                    inparam.Add("dltaH", parameterObject.dltaH);
                }
                if (parameterObject.dltaX != null)
                {
                    inparam.Add("dltaX", parameterObject.dltaX);
                }
                if (parameterObject.dltaY != null)
                {
                    inparam.Add("dltaY", parameterObject.dltaY);
                }
                if (parameterObject.GPSIndex != null)
                {
                    inparam.Add("GPSIndex", parameterObject.GPSIndex);
                }
                if (parameterObject.Height != null)
                {
                    inparam.Add("Height", parameterObject.Height);
                }
                if (parameterObject.X != null)
                {
                    inparam.Add("X", parameterObject.X);
                }
                if (parameterObject.Y != null)
                {
                    inparam.Add("Y", parameterObject.Y);
                }
            }
            inparam.Add("tableName", tableName);

            return BaseDA.Insert2("InsertDEVICE_STATUS", inparam);
        }

        public static int Update(DEVICE_STATUS parameterObject, string tableName)
        {
            Hashtable inparam = new Hashtable();
            if (parameterObject != null)
            {
                if (parameterObject.aDatetime != null)
                {
                    inparam.Add("aDatetime", parameterObject.aDatetime);
                }
                if (parameterObject.dltaH != null)
                {
                    inparam.Add("dltaH", parameterObject.dltaH);
                }
                if (parameterObject.dltaX != null)
                {
                    inparam.Add("dltaX", parameterObject.dltaX);
                }
                if (parameterObject.dltaY != null)
                {
                    inparam.Add("dltaY", parameterObject.dltaY);
                }
                if (parameterObject.GPSIndex != null)
                {
                    inparam.Add("GPSIndex", parameterObject.GPSIndex);
                }
                if (parameterObject.Height != null)
                {
                    inparam.Add("Height", parameterObject.Height);
                }
                if (parameterObject.X != null)
                {
                    inparam.Add("X", parameterObject.X);
                }
                if (parameterObject.Y != null)
                {
                    inparam.Add("Y", parameterObject.Y);
                }
            }
            inparam.Add("tableName", tableName);
            return BaseDA.Update2("UpdateDEVICE_STATUS", inparam);
        }

        public static int Delete(int primaryKeyId, string tableName)
        {
            Hashtable inparam = new Hashtable();
            inparam.Add("GPSIndex", primaryKeyId);
            inparam.Add("tableName", tableName);
            return BaseDA.Delete2("DeleteDEVICE_STATUSById", inparam);
        }

        public static DEVICE_STATUS Get(int primaryKeyId, string tableName)
        {
            Hashtable inparam = new Hashtable();
            inparam.Add("GPSIndex", primaryKeyId);
            inparam.Add("tableName", tableName);
            return BaseDA.QueryForObject<DEVICE_STATUS>("SelectDEVICE_STATUSById", inparam);
        }

        public static IList<DEVICE_STATUS> QueryForList(string tableName, DEVICE_STATUS parameterObject = null)
        {
            Hashtable inparam = new Hashtable();
            if (parameterObject != null)
            {
                if (parameterObject.aDatetime != null)
                {
                    inparam.Add("aDatetime", parameterObject.aDatetime);
                }
                
            }
            inparam.Add("tableName", tableName);
            return BaseDA.QueryForList<DEVICE_STATUS>("SelectDEVICE_STATUSQuery", inparam);
        }
    }
}


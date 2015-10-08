using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.tk.orm.model;
using System.Collections;
namespace com.tk.orm.dao
{
     public class DEVICE_STATUS_CLEANDao
    {
         public static object Insert(DEVICE_STATUS_CLEAN parameterObject, string tableName)
        {
              Hashtable inparam = new Hashtable();
              if (parameterObject != null)
              {
                  if (parameterObject.aDatetime != null)
                  {
                      inparam.Add("aDatetime", parameterObject.aDatetime);
                  }
                  if (parameterObject.GPSIndex != null)
                  {
                      inparam.Add("GPSIndex", parameterObject.GPSIndex);
                  }
                  if (parameterObject.Height != null)
                  {
                      inparam.Add("Height", parameterObject.Height);
                  }
                  if (parameterObject.Hspeed != null)
                  {
                      inparam.Add("Hspeed", parameterObject.Hspeed);
                  }
                  if (parameterObject.Style != null)
                  {
                      inparam.Add("Style", parameterObject.Style);
                  }
                  if (parameterObject.X != null)
                  {
                      inparam.Add("X", parameterObject.X);
                  }
                  if (parameterObject.XSpeed != null)
                  {
                      inparam.Add("XSpeed", parameterObject.XSpeed);
                  }
                  if (parameterObject.Y != null)
                  {
                      inparam.Add("Y", parameterObject.Y);
                  }
                  if (parameterObject.YSpeed != null)
                  {
                      inparam.Add("YSpeed", parameterObject.YSpeed);
                  }
                  
              }
              inparam.Add("tableName", tableName);

              return BaseDA.Insert2("InsertDEVICE_STATUS_CLEAN", inparam);
        }

         public static int Update(DEVICE_STATUS_CLEAN parameterObject, string tableName)
         {
             Hashtable inparam = new Hashtable();
             if (parameterObject != null)
             {
                 if (parameterObject.aDatetime != null)
                 {
                     inparam.Add("aDatetime", parameterObject.aDatetime);
                 }
                 if (parameterObject.GPSIndex != null)
                 {
                     inparam.Add("GPSIndex", parameterObject.GPSIndex);
                 }
                 if (parameterObject.Height != null)
                 {
                     inparam.Add("Height", parameterObject.Height);
                 }
                 if (parameterObject.Hspeed != null)
                 {
                     inparam.Add("Hspeed", parameterObject.Hspeed);
                 }
                 if (parameterObject.Style != null)
                 {
                     inparam.Add("Style", parameterObject.Style);
                 }
                 if (parameterObject.X != null)
                 {
                     inparam.Add("X", parameterObject.X);
                 }
                 if (parameterObject.XSpeed != null)
                 {
                     inparam.Add("XSpeed", parameterObject.XSpeed);
                 }
                 if (parameterObject.Y != null)
                 {
                     inparam.Add("Y", parameterObject.Y);
                 }
                 if (parameterObject.YSpeed != null)
                 {
                     inparam.Add("YSpeed", parameterObject.YSpeed);
                 }

             }
             inparam.Add("tableName", tableName);

             return BaseDA.Update2("UpdateDEVICE_STATUS_CLEAN", inparam);
        }

        public static int Delete(int primaryKeyId, string tableName)
         {
             Hashtable inparam = new Hashtable();
             inparam.Add("GPSIndex", primaryKeyId);
             inparam.Add("tableName", tableName);
             return BaseDA.Delete2("DeleteDEVICE_STATUS_CLEANById", inparam);
        }

        public static DEVICE_STATUS_CLEAN Get(int primaryKeyId,string tableName)
        {
            Hashtable inparam = new Hashtable();
            inparam.Add("GPSIndex", primaryKeyId);
            inparam.Add("tableName", tableName);
            return BaseDA.QueryForObject<DEVICE_STATUS_CLEAN>("SelectDEVICE_STATUS_CLEANById", inparam);
        }

        public static IList<DEVICE_STATUS_CLEAN> QueryForList(string tableName, DEVICE_STATUS_CLEAN parameterObject = null)
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
            return BaseDA.QueryForList<DEVICE_STATUS_CLEAN>("SelectDEVICE_STATUS_CLEANQuery", inparam);
        }
    }
}


using com.tk.dam.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace com.tk.dam.Util
{
    public class AutoLoginUtil
    {
        private readonly string ConfigName = "UserLoginConfig.dat";
        /// <summary>
        /// 
        /// </summary>
        public AutoLoginUtil()
        {
        }
        /// <summary>
        /// 获取自动登录的信息
        /// </summary>
        /// <returns></returns>
        public AutoLoginUser GetAutoLoginInfo()
        {
            using (Stream fStream = new FileStream(ConfigName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                try
                {
                    BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
                    AutoLoginUser user1 = (AutoLoginUser)binFormat.Deserialize(fStream);//反序列化对象
                    return user1;
                }
                catch (System.Exception ex)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 保存用户自动登录的信息
        /// </summary>
        /// <param name="user"></param>
        public void SaveAutoLoginInfo(AutoLoginUser user)
        {
            using (Stream fStream = new FileStream(ConfigName, FileMode.Create, FileAccess.ReadWrite))
            {
                try
                {
                    BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
                    binFormat.Serialize(fStream, user);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}

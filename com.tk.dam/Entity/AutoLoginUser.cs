using com.tk.orm.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.tk.dam.Entity
{ /// <summary>
  /// 用户自动登录信息
  /// </summary>
    [Serializable]
    public class AutoLoginUser
    {
        public AutoLoginUser()
        {
            RememberPwd = false;
            UserName = string.Empty;
            PassWord = string.Empty;
            rights = new List<RIGHT>();
        }

        /// <summary>
        /// 记住密码
        /// </summary>
        public bool RememberPwd
        {
            get;
            set;
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        public string PassWord
        {
            get;
            set;
        }

        public IList<RIGHT> rights
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.tk.dam.Entity
{
    public class Yh
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int Xh { get; set; }
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string Xm { get; set; }
        /// <summary>
        /// 用户登录名
        /// </summary>
        public string Dlm { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Xb { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string Bm { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Lxdh { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 用户权限
        /// </summary>
        public string Qx { get; set; }
        /// <summary>
        /// 用户登录密码
        /// </summary>
        public string Password { get; set; }
    }

    class YhComparer : IComparer<Yh>
    {
        public int Compare(Yh yh1, Yh yh2)
        {
            return yh1.Xh - yh2.Xh;
        }
    }
}

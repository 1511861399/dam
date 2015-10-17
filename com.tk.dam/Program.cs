using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using com.tk.orm.model;
using com.tk.orm.dao;
using com.tk.dam.Util;
using com.tk.dam.Entity;

namespace com.tk.dam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SkinName = "Sharp Plus";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AutoLoginUtil autoLogin = new AutoLoginUtil();
            AutoLoginUser userInfo = autoLogin.GetAutoLoginInfo();
            Login login = new Login(userInfo);
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                //login.LoginUser.ToString();//登录的用户以及用户权限信息
                Application.Run(new MainForm(login.LoginUser));
            }
        }
    }
}
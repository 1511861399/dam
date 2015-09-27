using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using com.tk.orm.dao;
using com.tk.orm.model;

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

            var insertProductId = 0;
            //查单条记录
            var model = BaseDA.Get<Product>("SelectByProductId", insertProductId);
            Application.Run(new MainForm());
        }
    }
}
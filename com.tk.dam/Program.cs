using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using com.tk.orm.model;
using com.tk.orm.dao;

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

            //ALARMAPPEND model = new ALARMAPPEND();
            //model.ALEVEl = 0;
            //model.GOAL_ID = 0;
            //model.METHOD = 0;
            //ALARMAPPENDDao.Insert(model);
            //model = ALARMAPPENDDao.Get(2);
            //int i = ALARMAPPENDDao.Delete(1);
            //model.METHOD = 1;
            //i = ALARMAPPENDDao.Update(model);
            IList<ALARMAPPEND> list = ALARMAPPENDDao.QueryForList(null);
            Application.Run(new MainForm());
        }
    }
}
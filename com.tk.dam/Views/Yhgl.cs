using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using com.tk.dam.Entity;

namespace com.tk.dam.Views
{
    public partial class Yhgl : XtraUserControlBase
    {
        public Yhgl()
        {
            InitializeComponent();
            BindingGrid();
        }

        private void BindingGrid()
        {
            IList<Yh> mYhList = new List<Yh>();
            for (int i = 1; i <= 12; i++)
            {
                Yh item = new Yh()
                {
                    Xh = "Xh" + i,
                    Xm = "Xm" + i,
                    Dlm = "Dlm" + i,
                    Xb = "Xb" + i,
                    Bm = "Bm" + i,
                    Zw = "Zw" + i,
                    Yhdj = "Yhdj" + i,
                    Qz = "Qz" + i,
                    Bz = "Bz" + i
                };
                mYhList.Add(item);
            }
            gcMain.DataSource = mYhList;
        }
    }
}

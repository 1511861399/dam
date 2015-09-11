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
        IList<Yh> mYhList = new List<Yh>();

        public Yhgl()
        {
            InitializeComponent();
            gridColumn_xh.Caption = "\n序号\n "; //调整ColumnHeader的高度
            BindingGrid();
        }

        /// <summary>
        ///  更新用户
        /// </summary>
        /// <param name="yh">用户对象</param>
        /// <param name="isNew">是否新增</param>
        public void UpdateYHList(Yh yh, bool isNew)
        {
            if (isNew)
            {
                mYhList.Add(yh);
            }
            else
            {
                //update
            }
            gcMain.RefreshDataSource();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="yh">用户</param>
        public void DeleteYH(Yh yh)
        { 
            //TODO:更新列表
        }

        private void BindingGrid()
        {           
            for (int i = 1; i <= 6; i++)
            {
                Yh item = new Yh()
                {
                    Xh = i.ToString(),
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm.ShowYHEditFlyout(null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm.ShowDeleteYHConfirm(new Yh());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainForm.ShowYHEditFlyout(null);
        }
    }
}

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
        List<Yh> mYhList = new List<Yh>();
        private IComparer<Yh> yhComparer = new YhComparer();

        public Yhgl()
        {
            InitializeComponent();
            gridColumn_xh.Caption = "\n序号\n "; //调整ColumnHeader的高度
            BindingGrid();
        }

        private void Yhgl_Load(object sender, EventArgs e)
        {
            this.panelContainer.Width = (int)((this.Width - 900) * 0.5) + 900;
            this.panelContainer.Height = (int)((this.Height - 600) * 0.1) + 560;
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
                yh.Xh = mYhList.Max(temp => temp.Xh) + 1;
                mYhList.Add(yh);
            }
            else
            {
                mYhList.Remove(mYhList.Single(temp => temp.Xh == yh.Xh));
                mYhList.Add(yh);
            }
            mYhList.Sort(yhComparer);
            gcMain.RefreshDataSource();            
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="yh">用户</param>
        public void DeleteYH(Yh yh)
        {
            mYhList.Remove(yh);
            mYhList.Sort(yhComparer);
            gcMain.RefreshDataSource();
        }

        private void BindingGrid()
        {
            mYhList.Add(new Yh { Xh = 1, Xm = "Admin", Dlm = "Admin", Xb = "男", Qx = "超级管理员" });
            mYhList.Add(new Yh { Xh = 2, Xm = "陈文水", Dlm = "cws", Xb = "男", Qx = "普通用户" });
            mYhList.Add(new Yh { Xh = 3, Xm = "李芸", Dlm = "liyun", Xb = "女", Qx = "普通用户" });
            mYhList.Sort(yhComparer);
            gcMain.DataSource = mYhList;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm.ShowYHEditFlyout(null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm.ShowDeleteYHConfirm(mYhList[gridView1.FocusedRowHandle]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainForm.ShowYHEditFlyout(mYhList[gridView1.FocusedRowHandle]);
        }       
    }
}

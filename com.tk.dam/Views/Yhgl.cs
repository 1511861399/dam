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
using com.tk.orm.dao;
using com.tk.orm.model;

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
            BindingGrid();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="yh">用户</param>
        public void DeleteYH(Yh yh)
        {
            var userRoles = USERROLEDao.QueryForListByUserId(yh.Xh);
            if (userRoles != null)
            {
                foreach (var userRole in userRoles)
                {
                    USERROLEDao.Delete(userRole.ID);
                }
            }
            USERDao.Delete(yh.Xh);
            mYhList.Remove(yh);
            mYhList.Sort(yhComparer);
            gcMain.RefreshDataSource();
        }

        private void BindingGrid()
        {
            mYhList.Clear();
            var users = USERDao.QueryForList();
            if (users != null)
            {
                foreach (var user in users)
                {
                    Yh yh = new Yh
                    {
                        Xh = user.ID,
                        Xm = user.REAL_NAME,
                        Dlm = user.NAME,
                        Xb = user.GENDER,
                        Bm = user.DEPT,
                        Lxdh = user.TEL,
                        Email = user.EMAIL,
                        Password = user.PASSWORD
                    };
                    var userRoles = USERROLEDao.QueryForListByUserId(user.ID);
                    if (userRoles != null && userRoles.Count > 0)
                    {
                        ROLE role = ROLEDao.Get(userRoles[0].ROLE_ID);
                        if (role != null)
                        {
                            yh.Qx = role.DESCRIPTION;
                        }
                    }
                    mYhList.Add(yh);
                }
            }
            mYhList.Sort(yhComparer);
            gcMain.DataSource = mYhList;
            gcMain.RefreshDataSource();
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

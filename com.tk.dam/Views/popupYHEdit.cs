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
using System.Diagnostics;

namespace com.tk.dam.Views
{
    public partial class popupYHEdit : PopupUserControlBase
    {

        public popupYHEdit()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            IList<string> bmList = new List<string>();
            bmList.Add("办公室");
            bmList.Add("综合部");
            bmList.Add("研发部");
            bmList.Add("市场部");
            cmbBm.DataSource = bmList;

            cmbQx.DataSource = ROLEDao.QueryForList();
            cmbQx.ValueMember = "ID";
            cmbQx.DisplayMember = "DESCRIPTION";
        }

        /// <summary>
        /// 设置当前用户
        /// </summary>
        /// <param name="yh">如果对象为空则表示新增用户</param>
        public void SetCurrentYH(Yh yh)
        {
            if (yh == null)
            {
                lblTitle.Text = "新增用户";
                lblXh.Text = USERDao.GetNewId().ToString();
                txtXm.Text = "";
                txtDlm.Text = "";

                rdbMale.Checked = true;
                rdbFemale.Checked = false;

                cmbBm.SelectedIndex = 0;
                txtLxdh.Text = "";
                txtEmail.Text = "";
                cmbQx.SelectedIndex = 0;
            }
            else
            {
                lblTitle.Text = "编辑用户";
                lblXh.Text = yh.Xh.ToString();
                txtXm.Text = yh.Xm;
                txtDlm.Text = yh.Dlm;
                if (yh.Xb == "男")
                {
                    rdbMale.Checked = true;
                    rdbFemale.Checked = false;
                }
                else if (yh.Xb == "女")
                {
                    rdbMale.Checked = false;
                    rdbFemale.Checked = true;
                }
                cmbBm.Text = yh.Bm;
                txtLxdh.Text = yh.Lxdh;
                txtEmail.Text = yh.Email;
                cmbQx.Text = yh.Qx;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            user.ID = int.Parse(lblXh.Text);
            user.NAME = txtDlm.Text;
            user.REAL_NAME = txtXm.Text;
            if (rdbMale.Checked == true)
            {
                user.GENDER = "男";
            }
            else
            {
                user.GENDER = "女";
            }
            user.DEPT = cmbBm.Text;
            user.TEL = txtLxdh.Text;
            user.EMAIL = txtEmail.Text;
            user.STATE = 0;
            user.PASSWORD = "123456";
            if (USERDao.Get(user.ID) != null)
            {
                USERDao.Update(user);
            }
            else
            {
                USERDao.Insert(user);
            }

            var userRoles = USERROLEDao.QueryForListByUserId(user.ID);
            if (userRoles != null && userRoles.Count > 0)
            {
                USERROLE userRole = new USERROLE { ID = userRoles[0].ID, USER_ID = user.ID, ROLE_ID = (int)cmbQx.SelectedValue, PROJ_ID = 1 };
                USERROLEDao.Update(userRole);
            }
            else
            {
                USERROLE userRole = new USERROLE { ID = USERROLEDao.GetNewId(), USER_ID = user.ID, ROLE_ID = (int)cmbQx.SelectedValue, PROJ_ID = 1 };
                USERROLEDao.Insert(userRole);
            }

            Yh yh = new Yh();
            yh.Xh = int.Parse(lblXh.Text);
            //yh.Zw = cmbZw.Text;
            //yh.Yhdj = cmbYhdj.Text;
            yh.Qx = cmbQx.Text;//txtQx.Text;
            //yh.Bz = rtxBz.Text;

            if (lblTitle.Text == "新增用户")
            {
                MainForm.UpdateYHList(yh, true);
            }
            else
            {
                MainForm.UpdateYHList(yh, false);
            }

            MainForm.HidenFlyout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.HidenFlyout();
        }

    }
}

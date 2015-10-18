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

            string bmfileName = @"bm.xml";
            using (System.IO.Stream fStream = new System.IO.FileStream(bmfileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite))
            {
                try
                {
                    System.Xml.Serialization.XmlSerializer xmlFormat = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
                    bmList = (List<string>)xmlFormat.Deserialize(fStream);
                }
                catch (System.Exception ex)
                {
                }
            }
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
                txtPwd.Text = yh.Password;
                txtPwd2.Text = yh.Password;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text != txtPwd2.Text)
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                txtPwd.Focus();
                return;
            }

            if (lblTitle.Text == "新增用户")
            {
                IList<USER> users = USERDao.QueryForList(null).Where(p => p.NAME == txtDlm.Text.Trim()).ToList();
                if (users != null && users.Count > 0)
                {
                    MessageBox.Show("该登录名已使用，请重新输入登录名！");
                    txtDlm.Focus();
                    return;
                }
            }

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
            user.PASSWORD = txtPwd.Text;
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

            if (lblTitle.Text == "新增用户")
            {
                MainForm.UpdateYHList(null, true);
            }
            else
            {
                MainForm.UpdateYHList(null, false);
            }

            MainForm.HidenFlyout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.HidenFlyout();
        }
    }
}

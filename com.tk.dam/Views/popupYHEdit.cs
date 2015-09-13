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
    public partial class popupYHEdit : PopupUserControlBase
    {

        public popupYHEdit()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
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
                lblXh.Text = "0";
                txtXm.Text = "";
                txtDlm.Text = "";

                rdbMale.Checked = true;
                rdbFemale.Checked = false;

                cmbBm.SelectedIndex = 0;
                cmbZw.SelectedIndex = 0;
                cmbYhdj.SelectedIndex = 0;
                cmbQx.SelectedIndex = 0;
                rtxBz.Text = "";
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
                cmbZw.Text = yh.Zw;
                cmbYhdj.Text = yh.Yhdj;
                cmbQx.Text = yh.Qx;
                cmbQx.Text = yh.Qx;
                rtxBz.Text = yh.Bz;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Yh yh = new Yh();
            yh.Xh = int.Parse(lblXh.Text);
            yh.Xm = txtXm.Text;
            yh.Dlm = txtDlm.Text;
            if (rdbMale.Checked == true)
            {
                yh.Xb = "男";
            }
            else
            {
                yh.Xb = "女";
            }

            yh.Bm = cmbBm.Text;
            yh.Zw = cmbZw.Text;
            yh.Yhdj = cmbYhdj.Text;
            yh.Qx = cmbQx.Text;//txtQx.Text;
            yh.Bz = rtxBz.Text;

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

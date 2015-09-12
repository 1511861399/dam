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

                txtBm.Text = "";
                txtZw.Text = "";
                txtYhdj.Text = "";
                txtQx.Text = "员工";
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
                txtBm.Text = yh.Bm;
                txtZw.Text = yh.Zw;
                txtYhdj.Text = yh.Yhdj;
                txtQx.Text = yh.Qx;
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

            yh.Bm = txtBm.Text;
            yh.Zw = txtZw.Text;
            yh.Yhdj = txtYhdj.Text;
            yh.Qx = txtQx.Text;
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

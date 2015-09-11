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
            }
            else
            {
                lblTitle.Text = "编辑用户";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MainForm.UpdateYHList(new Yh() { Xh = "NEW", Xm = "Demo" }, true);
            MainForm.HidenFlyout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.HidenFlyout();
        }

    }
}

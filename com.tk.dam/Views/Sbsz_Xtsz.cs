using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace com.tk.dam.Views
{
    public partial class Sbsz_Xtsz : DevExpress.XtraEditors.XtraUserControl
    {
        private Color mSelectedColor = Color.FromArgb(235, 163, 17);
        private Color mUnSelectedColor = Color.FromArgb(182, 182, 182);
        public Sbsz_Xtsz()
        {
            InitializeComponent();
            mPanelEditSjjl.Visible = false;
            mPanelEditXtbj.Visible = false;
        }


        private void btnBj_Sjjl_Click(object sender, EventArgs e)
        {
            btnGb_Xtbj_Click(null, null);
            mPanelEditSjjl.Visible = true;
            btnBj_Sjjl.BackColor = mSelectedColor;
        }

        private void btnGb_Sjjl_Click(object sender, EventArgs e)
        {
            mPanelEditSjjl.Visible = false;
            btnBj_Sjjl.BackColor = mUnSelectedColor;
        }

        private void btnGb_Xtbj_Click(object sender, EventArgs e)
        {
            btnBj_Xtbj.BackColor = mUnSelectedColor;
            mPanelEditXtbj.Visible = false;
        }

        private void btnBj_Xtbj_Click(object sender, EventArgs e)
        {
            btnGb_Sjjl_Click(null, null);
            mPanelEditXtbj.Visible = true;
            btnBj_Xtbj.BackColor = mSelectedColor;
        }

        internal void setValue(Entity.Sbzt mCurrentEntity)
        {
            //throw new NotImplementedException();
        }
    }
}

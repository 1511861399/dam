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
    public partial class Sbsz_Bjsz : DevExpress.XtraEditors.XtraUserControl
    {
        private Color mSelectedColor = Color.FromArgb(235, 163, 17);
        private Color mUnSelectedColor = Color.FromArgb(182, 182, 182);
        public Sbsz_Bjsz()
        {
            InitializeComponent();
            mPanelEditWlsz.Visible = false;
            mPanelEditWlcs.Visible=false;
        }
  

    
        private void btnBj_Wl_Click(object sender, EventArgs e)
        {
            btnGb_CS_Click(null, null);
            mPanelEditWlsz.Visible = true;
            btnBj_Wl.BackColor = mSelectedColor;
        }

        private void btnWl_Gb_Click(object sender, EventArgs e)
        {
            mPanelEditWlsz.Visible = false;
            btnBj_Wl.BackColor = mUnSelectedColor;
        }

        private void btnGb_CS_Click(object sender, EventArgs e)
        {
            btnBj_Cs.BackColor = mUnSelectedColor;
            mPanelEditWlcs.Visible = false ;
        }

        private void btnBj_Cs_Click(object sender, EventArgs e)
        { 
            btnWl_Gb_Click(null, null);
            mPanelEditWlcs.Visible = true;
            btnBj_Cs.BackColor = mSelectedColor;
        }
    }
}

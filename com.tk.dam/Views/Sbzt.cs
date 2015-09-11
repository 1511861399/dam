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
    public partial class Sbzt : XtraUserControlBase
    {
        private Color mSelectedColor = Color.FromArgb(235,163,17);
        private Color mUnSelectedColor = Color.FromArgb(182, 182, 182);
        private Panel mCurrentMenu;
        public Sbzt()
        {
            InitializeComponent();
            mPanelEditWlsz.Visible = false;
        }

        private void Sbzt_Load(object sender, EventArgs e)
        {
            
            int mDeltaH = (int)((this.Height - 670) * 0.67);
            int mDelatW = (int)((this.Width - 1024) * 0.67);
            if (mDeltaH > 0 && mDelatW > 0)
            {
                if (mDelatW / mDeltaH > 1024 / 670)
                {
                    mDelatW = (int)(mDeltaH * 1024 / 670);
                }
                else
                {
                    mDeltaH = (int)(mDelatW * 670 / 1024);
                }

                this.mPanel.Height = 450 + mDeltaH;
                this.mPanel.Width = 1012 + mDelatW;
                int mNewX = this.mPanel.Location.X - (int)(mDelatW * 0.5);
                int mNewY = this.mPanel.Location.Y - (int)(mDeltaH * 0.6);
                this.mPanel.Location = new Point(mNewX, mNewY);
            }
            mCurrentMenu = mMenuBjsz;
            menu_panel_click(mCurrentMenu, null);
        }

        private void menu_panel_click(object sender, EventArgs e)
        {
            mCurrentMenu.BackColor = Color.White;
            Label label = (Label)mCurrentMenu.Controls[0];
            label.ForeColor = Color.Black;

            Panel panel = (Panel)sender;
            panel.BackColor = mSelectedColor;
            label = (Label)panel.Controls[0];
            label.ForeColor = Color.White;
            mCurrentMenu = panel;
        }

        private void menulabel_click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            object parent =null;
            if (label.Name == "mLblBjsz")
            {
                parent = mMenuBjsz;
            }
            if (label.Name == "mLblXtsz")
            {
                parent = mMenuXtsz;
            }
            if (label.Name == "mLblXtcq")
            {
                parent = mMenuXtcq;
            }
            if (label.Name == "mLblHfccsz")
            {
                parent = mMenuHfccsz;
            }
            menu_panel_click(parent, null);
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

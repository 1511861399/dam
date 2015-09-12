using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;

namespace com.tk.dam.Views
{
    public partial class Sbzt : XtraUserControlBase
    {
        private Color mSelectedColor = Color.FromArgb(235,163,17);
        private Color mUnSelectedColor = Color.FromArgb(182, 182, 182);
        private Panel mCurrentMenu;
        protected WindowsUIView View { get; set; }
        public Sbzt()
        {
            InitializeComponent();
            Sbsz_Bjsz bjsz = new Sbsz_Bjsz();
            Sbsz_Xtsz xtsz = new Sbsz_Xtsz();
            Sbsz_Xtcq xtcs = new Sbsz_Xtcq();
            Sbsz_Hfccsz hfccsz = new Sbsz_Hfccsz();
            windowsUIView1.AddDocument(bjsz);
            windowsUIView1.AddDocument(xtsz);
            windowsUIView1.AddDocument(xtcs);
            windowsUIView1.AddDocument(hfccsz);
            pageGroup1.Properties.ShowPageHeaders = DevExpress.Utils.DefaultBoolean.False;
            windowsUIView1.NavigationBarsShowing += new NavigationBarsCancelEventHandler(onShowingNavigationBars);
            windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.VerticalSlide;
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
            if (View != null)
                View.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.RandomSegmentedFade;
            if (panel.Tag.ToString() == "bjsz") 
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.RandomSegmentedFade;
                windowsUIView1.Controller.Activate(document1);
            }
            if (panel.Tag.ToString() == "xtsz")
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.RandomSegmentedFade;
                windowsUIView1.Controller.Activate(document2);
            }
            if (panel.Tag.ToString() == "xtcq")
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.RandomSegmentedFade;
                windowsUIView1.Controller.Activate(document3);
            }
            if (panel.Tag.ToString() == "hfccsz")
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.RandomSegmentedFade;
                windowsUIView1.Controller.Activate(document4);
            }
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
        void onShowingNavigationBars(object sender, NavigationBarsCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

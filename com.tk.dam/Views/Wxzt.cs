using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace com.tk.dam.Views
{
    public partial class Wxzt : XtraUserControlBase
    {
        public Wxzt()
        {
            InitializeComponent();
            //var mCurrentSkin = MetroUISkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            //SkinElement skin = mCurrentSkin[MetroUISkins.SkinPageGroupItemHeaderButton];
            ////skin.Color.BackColor = Color.Green;           
            //skin.SetActualImage(Properties.Resources.btn_bg, true);
            //LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            
            mainWindowsUIView.AddDocument(new Wxzt_xkt());
            mainWindowsUIView.AddDocument(new Wxzt_xzb());
        }

        private void Wxzt_Load(object sender, EventArgs e)
        {
            this.xtraUserControl1.Width = (int)((this.Width - 880) * 0.5) + 880;
            this.xtraUserControl1.Height = (int)((this.Height - 600) * 0.1) + 560;
        }

        private void btnXKT_Click(object sender, EventArgs e)
        {
            mainWindowsUIView.ActivateDocument(this.document_xkt);
        }

        private void btnXZB_Click(object sender, EventArgs e)
        {
            mainWindowsUIView.ActivateDocument(this.document_xzb);
        }

    }
}

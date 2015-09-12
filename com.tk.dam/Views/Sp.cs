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
    public partial class Sp : XtraUserControlBase
    {
        public Sp()
        {
            InitializeComponent();
        }

        private void panelMenu_MouseEnter(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.Cursor = Cursors.Hand;
            panel.BackColor = Color.FromArgb(227,166,41);
        }

        private void panelMenu_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.BackColor = Color.FromArgb(0, 89, 145);
        }

        private void panelViedo_MouseEnter(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.Cursor = Cursors.Hand;
            panel.BorderStyle = BorderStyle.Fixed3D;
            //panel.
        }

        private void panelVideo_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.BorderStyle = BorderStyle.None;
            //panel.BackColor = Color.FromArgb(0, 89, 145);
        }
    }
}

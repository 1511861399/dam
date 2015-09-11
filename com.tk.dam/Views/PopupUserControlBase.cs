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
    public partial class PopupUserControlBase : DevExpress.XtraEditors.XtraUserControl
    {
        public MainForm MainForm;

        public PopupUserControlBase()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void PopupUserControlBase_Load(object sender, EventArgs e)
        {
            MainForm = this.ParentForm as MainForm;
        }
    }
}

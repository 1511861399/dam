using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;

namespace com.tk.dam.Views
{
    public partial class XtraUserControlBase : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlBase()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DocumentContainer parent = Parent as DocumentContainer;
            if (parent != null)
            {
                int y = 0;
                if (parent.Bounds.Y > 0)
                {
                    y = parent.Bounds.Y;
                }
                Rectangle rect = new Rectangle(this.Bounds.X, this.Bounds.Y - y, this.Bounds.Width, this.Bounds.Height + y);
                e.Graphics.DrawImage(Properties.Resources.bg02, rect);
            }
        }
    }
}

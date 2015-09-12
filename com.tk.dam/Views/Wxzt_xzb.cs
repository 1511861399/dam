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
    public partial class Wxzt_xzb : DevExpress.XtraEditors.XtraUserControl
    {
        private Random mRandom;

        public Wxzt_xzb()
        {
            InitializeComponent();
        }

        private void Wxzt_xzb_Load(object sender, EventArgs e)
        {
            mRandom = new Random(360);
            for (int i = 0; i < 60; i++)
            {
                var mValue = mRandom.Next(50);
                this.chartControl2.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint(i, mValue + mRandom.Next(10)));
                this.chartControl2.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint(i, mValue + mRandom.Next(10)));
            }
        }
    }
}

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
    public partial class Wxzt_xkt : DevExpress.XtraEditors.XtraUserControl
    {
        private Random mRandom;
        public Wxzt_xkt()
        {
            InitializeComponent();
        }

        private void Wxzt_xkt_Load(object sender, EventArgs e)
        {
            mRandom = new Random(360);
            for (int i = 0; i < 16; i++)
            {
                this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint(mRandom.Next(360), mRandom.Next(30)));
                this.chartControl1.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint(mRandom.Next(360), mRandom.Next(30)));
                this.chartControl1.Series[2].Points.Add(new DevExpress.XtraCharts.SeriesPoint(mRandom.Next(360), mRandom.Next(30)));
            }

            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DevExpress.XtraCharts.SeriesPoint mPoint;
            for (int i = 0; i < 16; i++)
            {
                mPoint = this.chartControl1.Series[0].Points[i];
                this.chartControl1.Series[0].Points[i].NumericalArgument = mPoint.NumericalArgument + mRandom.Next(5);
                this.chartControl1.Series[0].Points[i].Values[0] = mPoint.Values[0] + mRandom.Next(3);

                mPoint = this.chartControl1.Series[1].Points[i];
                this.chartControl1.Series[1].Points[i].NumericalArgument = mPoint.NumericalArgument + mRandom.Next(5);
                this.chartControl1.Series[1].Points[i].Values[0] = mPoint.Values[0] + mRandom.Next(3);

                mPoint = this.chartControl1.Series[2].Points[i];
                this.chartControl1.Series[2].Points[i].NumericalArgument = mPoint.NumericalArgument + mRandom.Next(3);
                this.chartControl1.Series[2].Points[i].Values[0] = mPoint.Values[0] + mRandom.Next(3);
            }
        }
    }
}

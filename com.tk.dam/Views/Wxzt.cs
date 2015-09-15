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
using DevExpress.XtraCharts;

namespace com.tk.dam.Views
{
    public partial class Wxzt : XtraUserControlBase
    {
        Wxzt_xkt mXkt;
        Wxzt_xzb mXzb;
        private Random mRandom = new Random(360);
        private Color mDefaultColor = Color.FromArgb(20, 107, 161);
        private Color mActiveColor = Color.FromArgb(235, 163, 17);
        private Label mCurrentMonitorLb;
        private Dictionary<string, List<SeriesPoint>> mSeriesPointGPS = new Dictionary<string, List<SeriesPoint>>();
        private Dictionary<string, List<SeriesPoint>> mSeriesPointBD = new Dictionary<string, List<SeriesPoint>>();
        private Dictionary<string, List<SeriesPoint>> mSeriesPointGLO = new Dictionary<string, List<SeriesPoint>>();

        private Dictionary<string, List<SeriesPoint>> mSeriesPointGPS_xzb = new Dictionary<string, List<SeriesPoint>>();
        private Dictionary<string, List<SeriesPoint>> mSeriesPointBD_xzb = new Dictionary<string, List<SeriesPoint>>();
        private Dictionary<string, List<SeriesPoint>> mSeriesPointGLO_xzb = new Dictionary<string, List<SeriesPoint>>();

        public Wxzt()
        {
            InitializeComponent();
            //var mCurrentSkin = MetroUISkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            //SkinElement skin = mCurrentSkin[MetroUISkins.SkinPageGroupItemHeaderButton];
            ////skin.Color.BackColor = Color.Green;           
            //skin.SetActualImage(Properties.Resources.btn_bg, true);
            //LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            mXkt = new Wxzt_xkt();
            mXzb = new Wxzt_xzb();          
            mainWindowsUIView.AddDocument(mXkt);
            mainWindowsUIView.AddDocument(mXzb);
            mCurrentMonitorLb = this.lblMonitor1;
        }

        public void SetCurrentMonitor(string monitor)
        {
            if (mCurrentMonitorLb.Text != monitor)
            {
                foreach (Label label in panelMonitorContainer.Controls)
                {
                    if (label != null && label.Text == monitor)
                    {
                        lblMonitor_Click(label, new EventArgs());
                    }
                }
            }
        }

        private void Wxzt_Load(object sender, EventArgs e)
        {
            this.panelContainer.Width = (int)((this.Width - 900) * 0.4) + 860;
            this.panelContainer.Height = (int)((this.Height - 640) * 0.1) + 500;
            bindData();
        }

        private void btnXKT_Click(object sender, EventArgs e)
        {
            mainWindowsUIView.ActivateDocument(this.document_xkt);
        }

        private void btnXZB_Click(object sender, EventArgs e)
        {
            mainWindowsUIView.ActivateDocument(this.document_xzb);
        }

        private void mainWindowsUIView_NavigationBarsShowing(object sender, DevExpress.XtraBars.Docking2010.Views.WindowsUI.NavigationBarsCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void lblMonitor_Click(object sender, EventArgs e)
        {
            if (!mCurrentMonitorLb.Equals(sender))
            {
                mCurrentMonitorLb.BackColor = mDefaultColor;
                mCurrentMonitorLb = sender as Label;
                mCurrentMonitorLb.BackColor = mActiveColor;
            }
            bindData();
        }

        private void bindData()
        {
            string mKey = mCurrentMonitorLb.Text;
            List<int> mPointsNumList = MainForm.WxztDic[mKey];
            if (!mSeriesPointGPS.ContainsKey(mKey))
            {
                List<SeriesPoint> mPoints = new List<SeriesPoint>();
                List<SeriesPoint> mPointsXZB = new List<SeriesPoint>();
                for (int i = 1; i <= mPointsNumList[0]; i++)
                {
                    SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint(mRandom.Next(360), mRandom.Next(90));
                    point.Tag = "G"+i;
                    mPoints.Add(point);
                    SeriesPoint pointXZB = new DevExpress.XtraCharts.SeriesPoint(i, mRandom.Next(30)+20);
                    pointXZB.Tag = "G" + i;
                    mPointsXZB.Add(pointXZB); 
                }
                mSeriesPointGPS.Add(mKey, mPoints);
                mSeriesPointGPS_xzb.Add(mKey, mPointsXZB);
            }
            if (!mSeriesPointGLO.ContainsKey(mKey))
            {
                List<SeriesPoint> mPoints = new List<SeriesPoint>();
                List<SeriesPoint> mPointsXZB = new List<SeriesPoint>();
                for (int i = 1; i <= mPointsNumList[1]; i++)
                {
                    SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint(mRandom.Next(360), mRandom.Next(90));
                    point.Tag = "C" + i;
                    mPoints.Add(point);
                    SeriesPoint pointXZB = new DevExpress.XtraCharts.SeriesPoint(i, mRandom.Next(30)+20);
                    pointXZB.Tag = "C" + i;
                    mPointsXZB.Add(pointXZB); 
                }
                mSeriesPointGLO.Add(mKey, mPoints);
                mSeriesPointGLO_xzb.Add(mKey, mPointsXZB);
            }
            if (!mSeriesPointBD.ContainsKey(mKey))
            {
                List<SeriesPoint> mPoints = new List<SeriesPoint>();
                List<SeriesPoint> mPointsXZB = new List<SeriesPoint>();
                for (int i = 1; i <= mPointsNumList[2]; i++)
                {
                    SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint(mRandom.Next(360), mRandom.Next(90));
                    point.Tag = "B" + i;
                    mPoints.Add(point);
                    SeriesPoint pointXZB = new DevExpress.XtraCharts.SeriesPoint(i, mRandom.Next(30)+20);
                    pointXZB.Tag = "B" + i;
                    mPointsXZB.Add(pointXZB); 
                }
                mSeriesPointBD.Add(mKey, mPoints);
                mSeriesPointBD_xzb.Add(mKey, mPointsXZB);
            }
            mXkt.SetPoints(mSeriesPointGPS[mKey], mSeriesPointGLO[mKey], mSeriesPointBD[mKey]);
            mXzb.SetPoints(mSeriesPointGPS_xzb[mKey], mSeriesPointGLO_xzb[mKey], mSeriesPointBD_xzb[mKey]);
        }
    }
}

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
using com.tk.orm.model;

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

            if (MainForm.StationList.Count > 0)
            {
                this.lblMonitor1.Text = MainForm.StationList[0].sComment;
                this.lblMonitor1.Tag = MainForm.StationList[0];
                this.lblMonitor1.Visible = true;
            }
            if (MainForm.StationList.Count > 1)
            {
                this.lblMonitor2.Text = MainForm.StationList[1].sComment;
                this.lblMonitor2.Tag = MainForm.StationList[1];
                this.lblMonitor2.Visible = true;
            }
            if (MainForm.StationList.Count > 2)
            {
                this.lblMonitor3.Text = MainForm.StationList[2].sComment;
                this.lblMonitor3.Tag = MainForm.StationList[2];
                this.lblMonitor3.Visible = true;
            }

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

        public void bindData()
        {
            station mStation = mCurrentMonitorLb.Tag as station;
            List<sat> mSatGPS = MainForm.SatList.Where(p => p.sId == mStation.sId && p.sPrn < 30).ToList();
            List<sat> mSatGLO = MainForm.SatList.Where(p => p.sId == mStation.sId && p.sPrn > 30 && p.sPrn < 60).ToList();
            List<sat> mSatBD = MainForm.SatList.Where(p => p.sId == mStation.sId && p.sPrn > 60).ToList();
            List<SeriesPoint> mPointsGPS = new List<SeriesPoint>();
            List<SeriesPoint> mPointsGLO = new List<SeriesPoint>();
            List<SeriesPoint> mPointsBD = new List<SeriesPoint>();
            foreach (var sat in mSatGPS) {
                SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint(sat.sAzm, sat.sElev);
                point.Tag = sat.sPrn;
                mPointsGPS.Add(point);
            }
            foreach (var sat in mSatGLO)
            {
                SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint(sat.sAzm, sat.sElev);
                point.Tag = sat.sPrn;
                mPointsGLO.Add(point);
            }
            foreach (var sat in mSatBD)
            {
                SeriesPoint point = new DevExpress.XtraCharts.SeriesPoint(sat.sAzm, sat.sElev);
                point.Tag = sat.sPrn;
                mPointsBD.Add(point);
            }
            mXkt.SetPoints(mPointsGPS, mPointsGLO, mPointsBD);

            List<sat> mSatXZB = MainForm.SatList.Where(p => p.sId == mStation.sId).ToList();
            List<SeriesPoint> mPointsXZB1 = new List<SeriesPoint>();
            List<SeriesPoint> mPointsXZB2 = new List<SeriesPoint>();
            foreach (var sat in mSatXZB)
            {
                SeriesPoint point1 = new DevExpress.XtraCharts.SeriesPoint(sat.sPrn, sat.sL1);
                SeriesPoint point2 = new DevExpress.XtraCharts.SeriesPoint(sat.sPrn, sat.sL2);
                point1.Tag = sat.sPrn;
                point2.Tag = sat.sPrn;
                mPointsXZB1.Add(point1);
                mPointsXZB2.Add(point2);
            }
            mXzb.SetPoints(mPointsXZB1, mPointsXZB2);            
        }
    }
}

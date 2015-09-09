using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using com.tk.dam.Entity;
using DevExpress.XtraCharts;

namespace com.tk.dam.Views
{
    public partial class Dbyxzk : XtraUserControlBase
    {
        private List<Device> mDeviceList1 = new List<Device>();
        private List<Device> mDeviceList2 = new List<Device>();
        private Random mRandom = new Random(300);
        private Dictionary<string, List<SeriesPoint>> mSeriesPointXbDic = new Dictionary<string, List<SeriesPoint>>();
        private DateTime mNow = DateTime.Now;
        private int mOriginW = 662;
        private int mOriginH = 516;
        public Dbyxzk()
        {
            InitializeComponent();
            mPbCross.Parent = mDamPic;
            mPbCross.Visible = false;
            mPanelPopChart.Visible = false;
        }

        private void Dbyxzk_Load(object sender, EventArgs e)
        {
            int mDeltaH = (int)((this.Height - 670) * 0.6);
            int mDelatW = (int)((this.Width - 1024) * 0.6);
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

                this.mPanelMain.Height = 400 + mDeltaH;
                this.mPanelMain.Width = 1012 + mDelatW;
                int mNewX = this.mPanelMain.Location.X - (int)(mDelatW * 0.5);
                int mNewY = this.mPanelMain.Location.Y - (int)(mDeltaH * 0.6);
                this.mPanelMain.Location = new Point(mNewX, mNewY);

                this.mPanelChart.Width = (int)(this.mPanelChart.Height * 0.67);
            }
            LoadDevice();
            initDataChart(mDeviceList1);
            initDataChart(mDeviceList2);
            this.mainChart.Series[0].Points.Clear();
            SeriesPoint[] point1 = new SeriesPoint[] { new SeriesPoint("当前偏移", 4)};
            this.mainChart.Series[0].Points.AddRange(point1);
            this.mainChart.Series[1].Points.Clear();
            SeriesPoint[] point2 = new SeriesPoint[] { new SeriesPoint("累积偏移", 15.1) };
            this.mainChart.Series[1].Points.AddRange(point2);
        }

        private void initDataChart(List<Device> deviceList1)
        {
            foreach (Device d in deviceList1)
            {
                List<SeriesPoint> mPointsWy = new List<SeriesPoint>();
                List<SeriesPoint> mPointsCj = new List<SeriesPoint>();
                int mMaxWy = 0, mMinWy = 0, mMaxCj = 0, mMinCj = 0;
                for (int i = -8; i <= 0; i++)
                {
                    int mWy = mRandom.Next(50) - 10;
                    int mCj = mRandom.Next(50) - 10;
                    mMaxWy = mMaxWy > mWy ? mMaxWy : mWy;
                    mMinWy = mMinWy < mWy ? mMinWy : mWy;
                    mMaxCj = mMaxCj > mCj ? mMaxCj : mCj;
                    mMinCj = mMinCj < mCj ? mMinCj : mCj;
                    mPointsWy.Add(new SeriesPoint(mNow.AddDays(i), mWy));
                    mPointsCj.Add(new SeriesPoint(mNow.AddDays(i), mCj));

                }
                mSeriesPointXbDic.Add(d.Id.ToString(), mPointsWy);
            }
        }

        private void bindChart(string deviceid)
        {
            this.mPopChart.Series[0].Points.Clear();
            this.mPopChart.Series[0].Points.AddRange(mSeriesPointXbDic[deviceid].ToArray());
        }

        private void LoadDevice()
        {
            mDeviceList1 = new List<Device>();
            Device device = new Device();
            device.Id = 1;
            device.X = 139;
            device.Y = 250;
            mDeviceList1.Add(device);
            device = new Device();
            device.Id = 2;
            device.X = 217;
            device.Y = 247;
            mDeviceList1.Add(device);
            device = new Device();
            device.Id = 3;
            device.X = 323;
            device.Y = 240;
            mDeviceList1.Add(device);
            device = new Device();
            device.Id = 4;
            device.X = 423;
            device.Y = 232;
            mDeviceList1.Add(device);
            Point point = mDamPic.Location;
            Size size = mDamPic.Size;
            foreach (Device d in mDeviceList1)
            {
                PictureBox panel = new PictureBox();
                panel.Click += panel_Click;
                panel.Tag = d.Id;
                panel.Size = new Size(24, 19);
                panel.BackColor = Color.Red;
                int x = (int)(d.X * ((double)size.Width/(double)mOriginW));
                int y = (int)(d.Y * ((double)size.Height/(double)mOriginH  ));
                x = x + point.X;
                y = y + point.Y;
                panel.Location = new Point(x,y);
                this.mPanelPic.Controls.Add(panel);
                panel.BringToFront();
            }

            mDeviceList2 = new List<Device>();
            device = new Device();
            device.Id = 5;
            device.X = 222;
            device.Y = 378;
            mDeviceList2.Add(device);
            device = new Device();
            device.Id = 6;
            device.X = 432;
            device.Y = 356;
            mDeviceList2.Add(device);
            foreach (Device d in mDeviceList2)
            {
                int x = (int)(d.X * ((double)size.Width / (double)mOriginW));
                int y = (int)(d.Y * ((double)size.Height / (double)mOriginH));
                x = x + point.X;
                y = y + point.Y;
                PictureBox pb = new PictureBox();
                pb.Click += panel_Click;
                pb.Tag = d.Id;
                pb.BackColor = Color.Transparent;
                pb.Image = global::com.tk.dam.Properties.Resources.GNSSXB;
                pb.Parent = mDamPic;
                pb.Size = new Size(24, 19);
                pb.Location = new Point(x, y);
                this.mDamPic.Controls.Add(pb);
                pb.BringToFront();
            }
        }

        void panel_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            getCurrentDevice(pb,mDeviceList1);
            getCurrentDevice(pb, mDeviceList2);
        }

        private void getCurrentDevice(PictureBox pb, List<Device> deviceList)
        {
            int deviceId = (int)pb.Tag;
            foreach (Device d in deviceList)
            {
                if (d.Id == deviceId)
                {
                    showChart(d, pb.Location);
                }
            }
        }

        private void showChart(Device d,Point locatioin)
        {
            mPbCross.Visible = true;
            mPbCross.Location = new Point(locatioin.X - 4, locatioin.Y - mPbCross.Height-3);
            int mainX =mPanelMain.Location.X;
            int mainY = mPanelMain.Location.Y;
            int x = mainX+mPbCross.Location.X + mPbCross.Width / 2 - 30;
            int y = mainY+ mPbCross.Location.Y  - mPanelPopChart.Height+3;
            mPanelPopChart.Location = new Point(x, y);
            mPanelPopChart.Visible = true;
            bindChart(d.Id.ToString());
        }

        private void hindeChart()
        {
            mPbCross.Visible = false;
            mPanelPopChart.Visible = false;
        }
        private void mDamPic_Click(object sender, EventArgs e)
        {
            hindeChart();
        }

        private void Dbyxzk_Click(object sender, EventArgs e)
        {
            hindeChart();
        }
    }
}

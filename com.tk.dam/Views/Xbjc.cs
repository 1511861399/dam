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
    public partial class Xbjc : XtraUserControlBase
    {
        private Label mCurrentTimeLb;
        private Label mCurrentTypeLb;
        private Label mCurrentMonitorLb;
        private Color mDefaultColor = Color.FromArgb(20, 107, 161);
        private Color mActiveColor = Color.FromArgb(235, 163, 17);
        private Dictionary<string, List<SeriesPoint>> mSeriesPointWyDic = new Dictionary<string, List<SeriesPoint>>();
        private Dictionary<string, List<SeriesPoint>> mSeriesPointCjDic = new Dictionary<string, List<SeriesPoint>>();
        private Dictionary<string, string> mTjcjDic = new Dictionary<string, string>();
        private Dictionary<string, string> mTjwyDic = new Dictionary<string, string>();
        private Dictionary<string, string> mSscjDic = new Dictionary<string, string>();
        private Dictionary<string, string> mSswyDic = new Dictionary<string, string>();
        private Random mRandom = new Random(300);
        private DateTime mNow = DateTime.Now;

        public Xbjc()
        {
            InitializeComponent();
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

        private void Xbjc_Load(object sender, EventArgs e)
        {

            int mDeltaH = (int)((this.Height - 670) * 0.6);
            int mDelatW = (int)((this.Width - 1200) * 0.6);
            if (mDeltaH > 0 && mDelatW > 0)
            {
                if (mDelatW / mDeltaH > 1200 / 670)
                {
                    mDelatW = (int)(mDeltaH * 1200 / 670);
                }
                else
                {
                    mDeltaH = (int)(mDelatW * 670 / 1200);
                }

                this.panel5.Height = 460 + mDeltaH;
                this.panel5.Width = 1120 + mDelatW;
                int mNewX = this.panel5.Location.X - (int)(mDelatW * 0.5);
                int mNewY = this.panel5.Location.Y - (int)(mDeltaH * 0.65);
                this.panel5.Location = new Point(mNewX, mNewY);

                this.panel2.Width = (int)(this.panel2.Height * 1.2);
                this.panel1.Width = this.panel6.Width - this.panel2.Width - 10;
                this.panel2.Location = new Point(this.panel1.Width + 10, this.panel2.Location.Y);
            }

            bindGrid();
            bindChart();

        }

        #region Grid效果控制

        private int hotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
        private int HotTrackRow
        {
            get
            {
                return hotTrackRow;
            }
            set
            {
                if (hotTrackRow != value)
                {
                    int prevHotTrackRow = hotTrackRow;
                    hotTrackRow = value;
                    gvMain.RefreshRow(prevHotTrackRow);
                    gvMain.RefreshRow(hotTrackRow);

                    //if (hotTrackRow >= 0)
                    //    gcMain.Cursor = Cursors.Hand;
                    //else
                    //    gcMain.Cursor = Cursors.Default;
                }
            }
        }

        private void gridView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //var info = gvMain.CalcHitInfo(new Point(e.X, e.Y));
            //if (info.InRowCell)
            //    HotTrackRow = info.RowHandle;
            //else
            //    HotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
        }

        private void gvMain_MouseLeave(object sender, EventArgs e)
        {
            //HotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == HotTrackRow)
            {
                e.Appearance.BackColor = mActiveColor;
                e.Appearance.BackColor2 = mActiveColor;
            }
        }

        private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            e.Appearance.DrawBackground(e.Cache, e.Bounds);
            foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.Info.InnerElements)
            {
                if (!info.Visible) continue;
                DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter,
                    info.ElementInfo);
            }
            e.Painter.DrawCaption(e.Info, e.Info.Caption, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), e.Bounds, e.Appearance.GetStringFormat());
            e.Handled = true;
        }

        #endregion

        #region 数据绑定与数据切换

        private void lblTime_Click(object sender, EventArgs e)
        {
            if (!mCurrentTimeLb.Equals(sender))
            {
                mCurrentTimeLb.BackColor = mDefaultColor;
                mCurrentTimeLb = sender as Label;
                mCurrentTimeLb.BackColor = mActiveColor;
            }
            switch (mCurrentTimeLb.Text)
            {
                case "月":
                    this.lblTjTip.Text = "统计数据(本年)：";
                    break;
                case "小时":
                    this.lblTjTip.Text = "统计数据(本天)：";
                    break;
                default:
                    this.lblTjTip.Text = "统计数据(本月)：";
                    break;
            }
            bindChart();
        }

        private void lblType_Click(object sender, EventArgs e)
        {
            if (!mCurrentTypeLb.Equals(sender))
            {
                mCurrentTypeLb.BackColor = mDefaultColor;
                mCurrentTypeLb = sender as Label;
                mCurrentTypeLb.BackColor = mActiveColor;
            }
            bindChart();
        }

        private void lblMonitor_Click(object sender, EventArgs e)
        {
            if (!mCurrentMonitorLb.Equals(sender))
            {
                mCurrentMonitorLb.BackColor = mDefaultColor;
                mCurrentMonitorLb = sender as Label;
                mCurrentMonitorLb.BackColor = mActiveColor;
            }
            bindChart();
            HotTrackRow = int.Parse(mCurrentMonitorLb.Text) - 1;
        }

        private void bindChart()
        {
            string mKey = string.Format("{0}_{1}_{2}", mCurrentMonitorLb.Text, mCurrentTypeLb.Text, mCurrentTimeLb.Text);
            string mMonitor = mCurrentMonitorLb.Text;
            List<double> mCurrentXbList = MainForm.XbjcDic[mMonitor];
            if (!mSeriesPointWyDic.ContainsKey(mKey))
            {
                List<SeriesPoint> mPointsWy = new List<SeriesPoint>();
                List<SeriesPoint> mPointsCj = new List<SeriesPoint>();
                double mTotalWy = 0, mLjWy = 0, mTotalCj = 0, mLjCj = 0;              
                for (int i = -8; i <= 0; i++)
                {
                    double mWy = mRandom.Next(20) / 10.0 - 1;
                    double mCj = mRandom.Next(40) / 10.0 - 2;
                    if (i == 0)
                    {
                        mWy = mCurrentXbList[0];
                        mCj = mCurrentXbList[1];
                    }
                    mTotalWy = mTotalWy + Math.Abs(mWy);
                    mTotalCj = mTotalCj + Math.Abs(mCj);
                    mLjWy = mLjWy + mWy;
                    mLjCj = mLjCj + mCj;
                    switch (mCurrentTimeLb.Text)
                    {
                        case "月":
                            mPointsWy.Add(new SeriesPoint(mNow.AddMonths(i), mWy));
                            mPointsCj.Add(new SeriesPoint(mNow.AddMonths(i), mCj));
                            break;
                        case "小时":
                            mPointsWy.Add(new SeriesPoint(mNow.AddHours(i), mWy));
                            mPointsCj.Add(new SeriesPoint(mNow.AddHours(i), mCj));
                            break;
                        default:
                            mPointsWy.Add(new SeriesPoint(mNow.AddDays(i), mWy));
                            mPointsCj.Add(new SeriesPoint(mNow.AddDays(i), mCj));
                            break;
                    }
                }
                mSeriesPointWyDic.Add(mKey, mPointsWy);
                mSeriesPointCjDic.Add(mKey, mPointsCj);
                mTjwyDic.Add(mKey, string.Format("平均位移：{0}mm    累计位移：{1}mm", (mTotalWy / 8).ToString("F2").PadLeft(3, ' '), mLjWy.ToString().PadLeft(3, ' ')));
                mTjcjDic.Add(mKey, string.Format("平均沉降：{0}mm    累计沉降：{1}mm", (mTotalCj / 8).ToString("F2").PadLeft(3, ' '), mLjCj.ToString().PadLeft(3, ' ')));
            }

            if (!mSswyDic.ContainsKey(mMonitor))
            {
                mSswyDic.Add(mMonitor, "位移：" + mCurrentXbList[0].ToString("F2").PadLeft(2, ' ') + "mm");
                mSscjDic.Add(mMonitor, "沉降：" + mCurrentXbList[1].ToString("F2").PadLeft(2, ' ') + "mm");
            }
            this.lblSswy.Text = mSswyDic[mMonitor];
            this.lblSscj.Text = mSscjDic[mMonitor];
            this.lblTjwy.Text = mTjwyDic[mKey];
            this.lblTjcj.Text = mTjcjDic[mKey];
            this.mainChart.Series[0].Points.Clear();
            this.mainChart.Series[1].Points.Clear();
            this.mainChart.Series[0].Points.AddRange(mSeriesPointWyDic[mKey].ToArray());
            this.mainChart.Series[1].Points.AddRange(mSeriesPointCjDic[mKey].ToArray());
        }

        private void bindGrid()
        {
            gbBD.Caption = "\n标点\n ";
            //gbandKs.Caption = String.Format("{0}\n监测数据(/mm)", mNow.AddYears(-1).ToString("yyyy.MM.dd"));
            //gbandJs.Caption = String.Format("{0}\n监测数据(/mm)", mNow.ToString("yyyy.MM.dd"));
            gcmBW.Caption = "部位";
            gcmBH.Caption = "编号";
                                  
            gcmScgc.Caption = "始测高程\n(m)";     
            gcmBcgc1.Caption = "本次观测\n(m)";
            gcmLjcx.Caption = "累计沉陷\n(mm)";
            gcmScds.Caption = "始测读数\n(mm)";       
            gcmBcgc2.Caption = "本次观测\n(mm)" ;
            gcmLjwy.Caption = "累计位移\n(mm)";

            mCurrentMonitorLb = this.lblMonitor1;
            mCurrentTimeLb = this.lblDay;
            mCurrentTypeLb = this.lblXbqs;


            IList<Jcd> mJcdList = new List<Jcd>();
            for (int i = 1; i <= 12; i++)
            {
                List<double> mCurrentXbList = MainForm.XbjcDic[i.ToString()];
                Jcd item = new Jcd();
                item.BH = i.ToString();
                item.Scds = mRandom.Next(30) / 10.0;
                item.Bcgc2 = mCurrentXbList[0];
                item.Ljwy = item.Bcgc2 - item.Scds;
                if (i <= 6)
                {
                    item.BW = "坝顶\n108\n高程";
                    double m1 = mRandom.Next(4);
                    double m2 = mRandom.Next(4);
                    item.Scgc = 105.4 + m1 / 100;
                    item.Bcgc1 = 105.4 + m2 / 100;
                    item.Ljcx = Math.Abs(m2 - m1);
                }
                else if (i <= 9)
                {
                    item.BW = "背水\n坡90\n平台";
                    double m1 = mRandom.Next(4);
                    double m2 = mRandom.Next(4);
                    item.Scgc = 88.4 + m1 / 100;
                    item.Bcgc1 = 88.4 + m2 / 100;
                    item.Ljcx = Math.Abs(m2 - m1);
                }
                else
                {
                    item.BW = "背水\n坡75\n平台";
                    double m1 = mRandom.Next(4);
                    double m2 = mRandom.Next(4);
                    item.Scgc = 73.2 + m1 / 100;
                    item.Bcgc1 = 73.2 + m2 / 100;
                    item.Ljcx = Math.Abs(m2 - m1);
                }
                mJcdList.Add(item);
            }
            gcMain.DataSource = mJcdList;
        }

        #endregion
    }
}

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

        private void Xbjc_Load(object sender, EventArgs e)
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

                this.panel5.Height = 400 + mDeltaH;
                this.panel5.Width = 1012 + mDelatW;
                int mNewX = this.panel5.Location.X - (int)(mDelatW * 0.5);
                int mNewY = this.panel5.Location.Y - (int)(mDeltaH * 0.6);
                this.panel5.Location = new Point(mNewX, mNewY);

                //this.panel2.Width = (int)(this.panel2.Height * 1.08);
                //this.panel1.Width = this.panel6.Width - this.panel2.Width - 10;
                //this.panel2.Location = new Point(this.panel1.Width + 10, this.panel2.Location.Y);
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

                    if (hotTrackRow >= 0)
                        gcMain.Cursor = Cursors.Hand;
                    else
                        gcMain.Cursor = Cursors.Default;
                }
            }
        }

        private void gridView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var info = gvMain.CalcHitInfo(new Point(e.X, e.Y));
            if (info.InRowCell)
                HotTrackRow = info.RowHandle;
            else
                HotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
        }

        private void gvMain_MouseLeave(object sender, EventArgs e)
        {
            HotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
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
        }

        private void bindChart()
        {
            string mKey = string.Format("{0}_{1}_{2}", mCurrentMonitorLb.Text, mCurrentTypeLb.Text, mCurrentTimeLb.Text);
            string mMonitor = mCurrentMonitorLb.Text;
            if (!mSswyDic.ContainsKey(mMonitor))
            {
                mSswyDic.Add(mMonitor, "位移：" + (mRandom.Next(20) - 10).ToString().PadLeft(2, ' ') + "mm");
                mSscjDic.Add(mMonitor, "沉降：" + (mRandom.Next(20) - 10).ToString().PadLeft(2, ' ') + "mm");
            }
            if (!mSeriesPointWyDic.ContainsKey(mKey))
            {
                List<SeriesPoint> mPointsWy = new List<SeriesPoint>();
                List<SeriesPoint> mPointsCj = new List<SeriesPoint>();
                int mMaxWy=0, mMinWy=0, mMaxCj=0, mMinCj=0;
                for (int i = -8; i <= 0; i++)
                {
                    int mWy = mRandom.Next(30) - 15;
                    int mCj = mRandom.Next(30) - 15;
                    mMaxWy = mMaxWy > mWy ? mMaxWy : mWy;
                    mMinWy = mMinWy < mWy ? mMinWy : mWy;
                    mMaxCj = mMaxCj > mCj ? mMaxCj : mCj;
                    mMinCj = mMinCj < mCj ? mMinCj : mCj;
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
                mTjwyDic.Add(mKey, string.Format("最大位移：{0}mm    最小位移：{1}mm", mMaxWy.ToString().PadLeft(3, ' '), mMinWy.ToString().PadLeft(3, ' ')));
                mTjcjDic.Add(mKey, string.Format("最大沉降：{0}mm    最小沉降：{1}mm", mMaxCj.ToString().PadLeft(3, ' '), mMinCj.ToString().PadLeft(3, ' ')));
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
            gbandKs.Caption = String.Format("{0}\n监测数据(/mm)", mNow.AddYears(-1).ToString("yyyy.MM.dd"));
            gbandJs.Caption = String.Format("{0}\n监测数据(/mm)", mNow.ToString("yyyy.MM.dd"));
            gcmYqbh.Caption = "仪器\n编号";
            gcmXh.Caption = "仪器\n编号";
            gcmJzdgd.Caption = "基准点\n高程\n(/m)";
            gcmBjgd.Caption = "坝基\n高程\n(/m)";
            gcmJccj1.Caption = "基础\n沉降";
            gcmZdcj1.Caption = "最大\n沉降";
            gcmJccj2.Caption = "基础\n沉降";
            gcmZdcj2.Caption = "最大\n沉降"; ;

            mCurrentMonitorLb = this.lblMonitor1;
            mCurrentTimeLb = this.lblDay;
            mCurrentTypeLb = this.lblXbqs;


            IList<Jcd> mJcdList = new List<Jcd>();
            for (int i = 1; i <= 12; i++)
            {
                Jcd item = new Jcd()
                {
                    Yqbh = "ES-" + i,
                    Xh = string.Format("平行0+0{0}，垂直0+2{1}", 7.5f - mRandom.Next(20) * 0.1f, 50.0f - mRandom.Next(60) * 0.1f),
                    Jzdgc = 738.0f + mRandom.Next(40)*0.01f,
                    Bjgc = 738.0f + mRandom.Next(40) * 0.01f,
                    Jccj1 = mRandom.Next(50) + 100,
                    Jccj2 = mRandom.Next(50) + 100,
                    Zdcj1 = mRandom.Next(50) + 200,
                    Zdcj2 = mRandom.Next(50) + 200
                };
                mJcdList.Add(item);
            }
            gcMain.DataSource = mJcdList;
        }
        #endregion
    }
}

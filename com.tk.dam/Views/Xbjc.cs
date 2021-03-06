﻿using System;
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
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using com.tk.orm.model;
using com.tk.orm.dao;
using System.Threading;
using DevExpress.Utils;

namespace com.tk.dam.Views
{
    public partial class Xbjc : XtraUserControlBase
    {
        private Label mCurrentTimeLb;
        private Label mCurrentTypeLb;
        private Label mCurrentMonitorLb;
        private Color mDefaultColor = Color.FromArgb(20, 107, 161);
        private Color mActiveColor = Color.FromArgb(235, 163, 17);
        private int mCurrentQueryStyle;
        IList<Jcd> mJcdList;

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

            //自定义滚动栏的样式
            //var mCommonSkins =ChartSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            //SkinElement skinScrollButton = mCommonSkins[ChartSkins.SkinScrollBar];
            //skinScrollButton.Color.BackColor = Color.FromArgb(0, 126, 206);
            ////skinScrollButton.Image.ImageCount = 0;
            ////skinScrollButton.Glyph.ImageCount = 0;
            //////skinScrollButton.Image.SetImage(Properties.Resources.scrollbutton_glyph, Color.Transparent);
            //////skinScrollButton.Glyph.SetImage(Properties.Resources.scrollbutton_glyph, Color.Transparent);
            ////SkinElement skinScrollButtonThumb = mCommonSkins[CommonSkins.SkinScrollButtonThumb];
            ////skinScrollButtonThumb.Color.BackColor = Color.Transparent;
            ////skinScrollButtonThumb.Image.ImageCount = 0;
            ////skinScrollButtonThumb.Glyph.ImageCount = 0;
            //////skinScrollButtonThumb.Image.SetImage(Properties.Resources.scrollthumbbutton, Color.Transparent);
            //////skinScrollButtonThumb.Glyph.SetImage(Properties.Resources.scrollthumbbutton, Color.Transparent);            
            ////SkinElement skinSkinScrollShaft = mCommonSkins[CommonSkins.SkinScrollShaft];
            ////skinSkinScrollShaft.Color.BackColor = Color.Transparent;
            ////skinSkinScrollShaft.Image.ImageCount = 0;
            //LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

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

            gbBD.Caption = "\n标点\n ";
            gcmBW.Caption = "部位";
            gcmBH.Caption = "编号";
            gcmScgc.Caption = "始测高程\n(m)";
            gcmScgc.DisplayFormat.FormatType = FormatType.Numeric;
            gcmScgc.DisplayFormat.FormatString = "{0:N2}";
            gcmBcgc1.Caption = "本次观测\n(m)";
            gcmBcgc1.DisplayFormat.FormatType = FormatType.Numeric;
            gcmBcgc1.DisplayFormat.FormatString = "{0:N2}";
            gcmLjcx.Caption = "累计沉陷\n(mm)";
            gcmLjcx.DisplayFormat.FormatType = FormatType.Numeric;
            gcmLjcx.DisplayFormat.FormatString = "{0:N2}";
            gcmScds.Caption = "始测读数\n(mm)";
            gcmScds.DisplayFormat.FormatType = FormatType.Numeric;
            gcmScds.DisplayFormat.FormatString = "{0:N2}";
            gcmBcgc2.Caption = "本次观测\n(mm)";
            gcmBcgc2.DisplayFormat.FormatType = FormatType.Numeric;
            gcmBcgc2.DisplayFormat.FormatString = "{0:N2}";
            gcmLjwy.Caption = "累计位移\n(mm)";
            gcmLjwy.DisplayFormat.FormatType = FormatType.Numeric;
            gcmLjwy.DisplayFormat.FormatString = "{0:N2}";
            mJcdList = new List<Jcd>();

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

            this.mCurrentMonitorLb = this.lblMonitor1;
            this.mCurrentTimeLb = this.lblDay;
            this.mCurrentTypeLb = this.lblXbqs;

            bindData();

        }

        XYDiagram Diagram { get { return mainChart.Diagram as XYDiagram; } }

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
            bindData();
        }

        private void lblType_Click(object sender, EventArgs e)
        {
            if (!mCurrentTypeLb.Equals(sender))
            {
                mCurrentTypeLb.BackColor = mDefaultColor;
                mCurrentTypeLb = sender as Label;
                mCurrentTypeLb.BackColor = mActiveColor;
            }
            bindData();
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
            //HotTrackRow = int.Parse(mCurrentMonitorLb.Text) - 1;
        }

        private void bindData()
        {
            Thread mLoadThread = new Thread(new ThreadStart(delegate
            {
                this.Invoke((EventHandler)delegate
                {
                    MainForm.ShowLoading();
                    resetDiagramScroll(DateTime.Now, DateTime.Now.AddDays(-1));
                });
   
                string mMonitor = mCurrentMonitorLb.Text;
                station mStation = mCurrentMonitorLb.Tag as station;

                int mTopN = 24;
                int mStyle = 2;

                switch (mCurrentTimeLb.Text)
                {
                    case "月":
                        mTopN = mCurrentTypeLb.Text == "历史曲线" ? 36 : 12;
                        mStyle = 4;
                        break;
                    case "小时":
                        mTopN = mCurrentTypeLb.Text == "历史曲线" ? 720 : 24;
                        mStyle = 2;
                        break;
                    default:
                        mTopN = mCurrentTypeLb.Text == "历史曲线" ? 365 : 31;
                        mStyle = 3;
                        break;
                }

                
                IList<DEVICE_STATUS_CLEAN> mStatusList = DEVICE_STATUS_CLEANDao.QueryTopForList(mStation.sCoorName, mTopN, new DEVICE_STATUS_CLEAN() { Style = mStyle });
                List<SeriesPoint> mSeriesPointList0 = new List<SeriesPoint>();
                List<SeriesPoint> mSeriesPointList1 = new List<SeriesPoint>();
                double mTotalWy = 0, mLjWy = 0, mTotalCj = 0, mLjCj = 0;
                foreach (var status in mStatusList)
                {
                    status.Dx = mCurrentTypeLb.Text == "速度趋势" ? status.XSpeed * 1000 : status.X * 1000;
                    status.Dh = mCurrentTypeLb.Text == "速度趋势" ? status.Hspeed * 1000 : status.Height * 1000;
                    if (Math.Abs(status.Dx) > 4 || Math.Abs(status.Dx) < 0.1)
                    {
                        status.Dx = 0;
                    }
                    if (Math.Abs(status.Dh) > 4 || Math.Abs(status.Dh) < 0.1)
                    {
                        status.Dh = 0;
                    }
                    mTotalWy = mTotalWy + Math.Abs(status.Dx);
                    mTotalCj = mTotalCj + Math.Abs(status.Dh);
                    mLjWy = mLjWy + status.Dx;
                    mLjCj = mLjCj + status.Dh;
                    mSeriesPointList0.Add(new SeriesPoint(status.aDatetime.Value, status.Dx));
                    mSeriesPointList1.Add(new SeriesPoint(status.aDatetime.Value, status.Dh));
                }

                //当选择的时间改变时，更新Grid列表
                if (mCurrentQueryStyle != mStyle)
                {
                    mCurrentQueryStyle = mStyle;
                    mJcdList.Clear();
                    if (mCurrentTypeLb.Text == "历史曲线")
                    {
                        switch (mStyle)
                        {
                            case 2:
                                mTopN = 24;
                                break;
                            case 3:
                                mTopN = 12;
                                break;
                            case 4:
                                mTopN = 31;
                                break;
                            default:
                                break;
                        }
                    }
                    foreach (var station in MainForm.StationList)
                    {
                        mStatusList = DEVICE_STATUS_CLEANDao.QueryTopForList(station.sCoorName, mTopN, new DEVICE_STATUS_CLEAN() { Style = mStyle });                       
                        mTotalWy = 0;
                        mLjWy = 0;
                        mTotalCj = 0;
                        mLjCj = 0;
                        foreach (var status in mStatusList)
                        {
                            status.Dx = status.X * 1000;
                            status.Dh = status.Height * 1000;
                            if (Math.Abs(status.Dx) > 4 || Math.Abs(status.Dx) < 0.1)
                            {
                                status.Dx = 0;
                            }
                            if (Math.Abs(status.Dh) > 4 || Math.Abs(status.Dh) < 0.1)
                            {
                                status.Dh = 0;
                            }
                            mTotalWy = mTotalWy + Math.Abs(status.Dx);
                            mTotalCj = mTotalCj + Math.Abs(status.Dh);
                            mLjWy = mLjWy + status.Dx;
                            mLjCj = mLjCj + status.Dh;
                        }
                        if (mStatusList.Count > 0) 
                        {
                            var first = mStatusList.First();
                            var last = mStatusList.Last();
                            Jcd jcd = new Jcd();
                            jcd.BH = station.sName;
                            jcd.BW = "坝顶\n108\n高程";
                            jcd.Scgc = station.Sh + first.Dh;
                            jcd.Bcgc1 = station.Sh + last.Dh;
                            jcd.Ljcx = mLjCj;
                            jcd.Scds = first.Dx;
                            jcd.Bcgc2 = last.Dx;
                            jcd.Ljwy = mLjWy;
                            mJcdList.Add(jcd);
                        }
                    } 
                }

                this.Invoke((EventHandler)delegate
                {
                    MainForm.HideLoading();
                    this.mainChart.Series[0].Points.Clear();
                    this.mainChart.Series[1].Points.Clear();
                    if (mStatusList.Count > 0)
                    {
                        this.mainChart.Series[0].Points.AddRange(mSeriesPointList0.ToArray());
                        this.mainChart.Series[1].Points.AddRange(mSeriesPointList1.ToArray());
                        this.lblSswy.Text = "位移：" + mStatusList[0].Dx.ToString("F2").PadLeft(2, ' ') + "mm";
                        this.lblSscj.Text = "沉降：" + mStatusList[0].Dh.ToString("F2").PadLeft(2, ' ') + "mm";
                        this.lblTjwy.Text = string.Format("平均位移：{0}mm    累计位移：{1}mm", (mTotalWy / mStatusList.Count).ToString("F2").PadLeft(3, ' '), mLjWy.ToString("F2").PadLeft(3, ' '));
                        this.lblTjcj.Text = string.Format("平均沉降：{0}mm    累计沉降：{1}mm", (mTotalCj / mStatusList.Count).ToString("F2").PadLeft(3, ' '), mLjCj.ToString("F2").PadLeft(3, ' '));
                        resetDiagramScroll(mStatusList[0].aDatetime.Value, mStatusList[mStatusList.Count - 1].aDatetime.Value);
                    }
                    gcMain.DataSource = mJcdList;
                    gvMain.RefreshData();
                });
            }));

            mLoadThread.Start();
        }

        private void resetDiagramScroll(DateTime mMaxTime, DateTime mMinTime)
        {
            if (mCurrentTypeLb.Text == "历史曲线")
            {
                Diagram.EnableAxisXScrolling = true;
                Diagram.EnableAxisXZooming = true;
                Diagram.AxisX.WholeRange.SetMinMaxValues(mMinTime, mMaxTime);
                switch (mCurrentTimeLb.Text)
                {
                    case "月":
                        Diagram.AxisX.VisualRange.SetMinMaxValues(mMaxTime.AddYears(-1), mMaxTime);
                        break;
                    case "小时":
                        Diagram.AxisX.VisualRange.SetMinMaxValues(mMaxTime.AddDays(-1), mMaxTime);
                        break;
                    default:
                        Diagram.AxisX.VisualRange.SetMinMaxValues(mMaxTime.AddMonths(-1), mMaxTime);
                        break;
                }
                Diagram.AxisX.WholeRange.Auto = false;
                Diagram.AxisX.VisualRange.Auto = false;
            }
            else
            {
                Diagram.AxisX.WholeRange.SetMinMaxValues(mMinTime, mMaxTime);
                Diagram.AxisX.VisualRange.SetMinMaxValues(mMinTime, mMaxTime);
                Diagram.AxisX.WholeRange.Auto = true;
                Diagram.AxisX.VisualRange.Auto = true;
                Diagram.EnableAxisXScrolling = false;
                Diagram.EnableAxisXZooming = false;
            }
        }

        #endregion
    }
}

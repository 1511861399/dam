namespace com.tk.dam.Views
{
    partial class PoupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            this.mPanelPopChart = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mChartTitle = new System.Windows.Forms.Label();
            this.mPanelPopChart.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPanelPopChart
            // 
            this.mPanelPopChart.BackColor = System.Drawing.Color.Transparent;
            this.mPanelPopChart.Controls.Add(this.panel4);
            this.mPanelPopChart.Controls.Add(this.panel3);
            this.mPanelPopChart.Controls.Add(this.panel2);
            this.mPanelPopChart.Location = new System.Drawing.Point(0, 0);
            this.mPanelPopChart.Name = "mPanelPopChart";
            this.mPanelPopChart.Size = new System.Drawing.Size(353, 220);
            this.mPanelPopChart.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.chartControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 163);
            this.panel4.TabIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.BorderOptions.Color = System.Drawing.Color.Transparent;
            xyDiagram2.AxisX.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram2.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
            xyDiagram2.AxisX.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram2.AxisX.GridLines.Visible = true;
            xyDiagram2.AxisX.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram2.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram2.AxisX.Tickmarks.Visible = false;
            xyDiagram2.AxisX.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram2.AxisX.Title.Antialiasing = false;
            xyDiagram2.AxisX.Title.Text = "时间";
            xyDiagram2.AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            xyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram2.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram2.AxisY.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram2.AxisY.Label.TextPattern = "{V}mm";
            xyDiagram2.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram2.AxisY.Tickmarks.Visible = false;
            xyDiagram2.AxisY.Title.Antialiasing = false;
            xyDiagram2.AxisY.Title.Text = "位移/沉降";
            xyDiagram2.AxisY.Title.TextColor = System.Drawing.Color.Black;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisualRange.Auto = false;
            xyDiagram2.AxisY.VisualRange.AutoSideMargins = false;
            xyDiagram2.AxisY.VisualRange.MaxValueSerializable = "40";
            xyDiagram2.AxisY.VisualRange.MinValueSerializable = "-40";
            xyDiagram2.AxisY.VisualRange.SideMarginsValue = 0.88000000000000012D;
            xyDiagram2.AxisY.WholeRange.Auto = false;
            xyDiagram2.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram2.AxisY.WholeRange.MaxValueSerializable = "40";
            xyDiagram2.AxisY.WholeRange.MinValueSerializable = "-40";
            xyDiagram2.AxisY.WholeRange.SideMarginsValue = 0.88000000000000012D;
            xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl1.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.EquallySpacedItems = false;
            this.chartControl1.Legend.Margins.Bottom = 0;
            this.chartControl1.Legend.Margins.Left = 0;
            this.chartControl1.Legend.Margins.Right = 0;
            this.chartControl1.Legend.Margins.Top = 0;
            this.chartControl1.Legend.TextVisible = false;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Padding.Bottom = 3;
            this.chartControl1.Padding.Left = 3;
            this.chartControl1.Padding.Right = 3;
            this.chartControl1.Padding.Top = 3;
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series2.Name = "位移";
            lineSeriesView3.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.View = lineSeriesView3;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.SeriesTemplate.View = lineSeriesView4;
            this.chartControl1.Size = new System.Drawing.Size(353, 163);
            this.chartControl1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 21);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(55, 21);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::com.tk.dam.Properties.Resources.tip;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.mChartTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 36);
            this.panel2.TabIndex = 0;
            // 
            // mChartTitle
            // 
            this.mChartTitle.AutoSize = true;
            this.mChartTitle.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mChartTitle.ForeColor = System.Drawing.Color.White;
            this.mChartTitle.Location = new System.Drawing.Point(17, 8);
            this.mChartTitle.Name = "mChartTitle";
            this.mChartTitle.Size = new System.Drawing.Size(131, 22);
            this.mChartTitle.TabIndex = 0;
            this.mChartTitle.Text = "位移监控点2";
            // 
            // PoupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(353, 220);
            this.Controls.Add(this.mPanelPopChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PoupForm";
            this.Text = "PoupForm";
            this.mPanelPopChart.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mPanelPopChart;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mChartTitle;

    }
}
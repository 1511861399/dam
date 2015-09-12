namespace com.tk.dam.Views
{
    partial class Wxzt_xkt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.PolarDiagram polarDiagram1 = new DevExpress.XtraCharts.PolarDiagram();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wxzt_xkt));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PolarPointSeriesView polarPointSeriesView1 = new DevExpress.XtraCharts.PolarPointSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PolarPointSeriesView polarPointSeriesView2 = new DevExpress.XtraCharts.PolarPointSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PolarPointSeriesView polarPointSeriesView3 = new DevExpress.XtraCharts.PolarPointSeriesView();
            DevExpress.XtraCharts.PolarPointSeriesView polarPointSeriesView4 = new DevExpress.XtraCharts.PolarPointSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Dark";
            this.chartControl1.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.BorderOptions.Color = System.Drawing.Color.Transparent;
            polarDiagram1.AxisY.Visible = false;
            polarDiagram1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            polarDiagram1.BackImage.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.chartControl1.Diagram = polarDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.chartControl1.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Border.Color = System.Drawing.Color.Transparent;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Padding.Bottom = 15;
            this.chartControl1.Padding.Left = 15;
            this.chartControl1.Padding.Right = 15;
            this.chartControl1.Padding.Top = 15;
            this.chartControl1.PaletteName = "Nature Colors";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series1.Name = "GPS";
            polarPointSeriesView1.PointMarkerOptions.Size = 20;
            series1.View = polarPointSeriesView1;
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series2.Name = "Glonass";
            polarPointSeriesView2.PointMarkerOptions.Size = 20;
            series2.View = polarPointSeriesView2;
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series3.Name = "BD";
            polarPointSeriesView3.PointMarkerOptions.Size = 20;
            series3.View = polarPointSeriesView3;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            this.chartControl1.SeriesTemplate.View = polarPointSeriesView4;
            this.chartControl1.Size = new System.Drawing.Size(900, 600);
            this.chartControl1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Wxzt_xkt
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Name = "Wxzt_xkt";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.Wxzt_xkt_Load);
            ((System.ComponentModel.ISupportInitialize)(polarDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Timer timer1;

    }
}

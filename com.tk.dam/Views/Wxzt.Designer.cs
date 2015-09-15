namespace com.tk.dam.Views
{
    partial class Wxzt
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
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.mainDocumentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.mainWindowsUIView = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.mainPageGroup = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.document_xkt = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document_xzb = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXZB = new DevExpress.XtraEditors.SimpleButton();
            this.btnXKT = new DevExpress.XtraEditors.SimpleButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMonitorContainer = new System.Windows.Forms.Panel();
            this.lblMonitor12 = new System.Windows.Forms.Label();
            this.lblMonitor10 = new System.Windows.Forms.Label();
            this.lblMonitor8 = new System.Windows.Forms.Label();
            this.lblMonitor6 = new System.Windows.Forms.Label();
            this.lblMonitor4 = new System.Windows.Forms.Label();
            this.lblMonitor2 = new System.Windows.Forms.Label();
            this.lblMonitor11 = new System.Windows.Forms.Label();
            this.lblMonitor9 = new System.Windows.Forms.Label();
            this.lblMonitor7 = new System.Windows.Forms.Label();
            this.lblMonitor5 = new System.Windows.Forms.Label();
            this.lblMonitor3 = new System.Windows.Forms.Label();
            this.lblMonitor1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDocumentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowsUIView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_xkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_xzb)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelMonitorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraUserControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraUserControl1.Appearance.Options.UseBackColor = true;
            this.xtraUserControl1.Location = new System.Drawing.Point(5, -49);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(715, 505);
            this.xtraUserControl1.TabIndex = 0;
            // 
            // mainDocumentManager
            // 
            this.mainDocumentManager.ContainerControl = this.xtraUserControl1;
            this.mainDocumentManager.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.mainDocumentManager.View = this.mainWindowsUIView;
            this.mainDocumentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.mainWindowsUIView});
            // 
            // mainWindowsUIView
            // 
            this.mainWindowsUIView.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.mainPageGroup});
            this.mainWindowsUIView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document_xkt,
            this.document_xzb});
            this.mainWindowsUIView.PageGroupProperties.ShowPageHeaders = false;
            this.mainWindowsUIView.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False;
            this.mainWindowsUIView.NavigationBarsShowing += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.NavigationBarsCancelEventHandler(this.mainWindowsUIView_NavigationBarsShowing);
            // 
            // mainPageGroup
            // 
            this.mainPageGroup.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.document_xkt,
            this.document_xzb});
            this.mainPageGroup.Name = "mainPageGroup";
            this.mainPageGroup.Properties.SwitchDocumentAnimationMode = DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.SegmentedFade;
            // 
            // document_xkt
            // 
            this.document_xkt.Caption = "星空图";
            this.document_xkt.ControlName = "Wxzt_xkt";
            this.document_xkt.ControlTypeName = "com.tk.dam.Views.Wxzt_xkt";
            // 
            // document_xzb
            // 
            this.document_xzb.Caption = "信噪比";
            this.document_xzb.ControlName = "Wxzt_xzb";
            this.document_xzb.ControlTypeName = "com.tk.dam.Views.Wxzt_xzb";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnXZB);
            this.panel1.Controls.Add(this.btnXKT);
            this.panel1.Location = new System.Drawing.Point(68, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnXZB
            // 
            this.btnXZB.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnXZB.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnXZB.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnXZB.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnXZB.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXZB.Appearance.Options.UseBackColor = true;
            this.btnXZB.Appearance.Options.UseBorderColor = true;
            this.btnXZB.Appearance.Options.UseFont = true;
            this.btnXZB.Appearance.Options.UseForeColor = true;
            this.btnXZB.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXZB.Location = new System.Drawing.Point(135, 14);
            this.btnXZB.Name = "btnXZB";
            this.btnXZB.Size = new System.Drawing.Size(120, 44);
            this.btnXZB.TabIndex = 0;
            this.btnXZB.Text = "信噪比";
            this.btnXZB.Click += new System.EventHandler(this.btnXZB_Click);
            // 
            // btnXKT
            // 
            this.btnXKT.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnXKT.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnXKT.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnXKT.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnXKT.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXKT.Appearance.Options.UseBackColor = true;
            this.btnXKT.Appearance.Options.UseBorderColor = true;
            this.btnXKT.Appearance.Options.UseFont = true;
            this.btnXKT.Appearance.Options.UseForeColor = true;
            this.btnXKT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXKT.Location = new System.Drawing.Point(7, 14);
            this.btnXKT.Name = "btnXKT";
            this.btnXKT.Size = new System.Drawing.Size(120, 44);
            this.btnXKT.TabIndex = 0;
            this.btnXKT.Text = "星空图";
            this.btnXKT.Click += new System.EventHandler(this.btnXKT_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Controls.Add(this.xtraUserControl1);
            this.panelContainer.Controls.Add(this.panel4);
            this.panelContainer.Location = new System.Drawing.Point(68, 94);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(886, 456);
            this.panelContainer.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelMonitorContainer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(726, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 456);
            this.panel4.TabIndex = 4;
            // 
            // panelMonitorContainer
            // 
            this.panelMonitorContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelMonitorContainer.AutoSize = true;
            this.panelMonitorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(161)))), ((int)(((byte)(246)))));
            this.panelMonitorContainer.Controls.Add(this.lblMonitor12);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor10);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor8);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor6);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor4);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor2);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor11);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor9);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor7);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor5);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor3);
            this.panelMonitorContainer.Controls.Add(this.lblMonitor1);
            this.panelMonitorContainer.Controls.Add(this.label4);
            this.panelMonitorContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMonitorContainer.Name = "panelMonitorContainer";
            this.panelMonitorContainer.Size = new System.Drawing.Size(159, 456);
            this.panelMonitorContainer.TabIndex = 3;
            // 
            // lblMonitor12
            // 
            this.lblMonitor12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor12.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor12.ForeColor = System.Drawing.Color.White;
            this.lblMonitor12.Location = new System.Drawing.Point(86, 341);
            this.lblMonitor12.Name = "lblMonitor12";
            this.lblMonitor12.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor12.TabIndex = 1;
            this.lblMonitor12.Text = "12";
            this.lblMonitor12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor12.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor10
            // 
            this.lblMonitor10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor10.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor10.ForeColor = System.Drawing.Color.White;
            this.lblMonitor10.Location = new System.Drawing.Point(86, 285);
            this.lblMonitor10.Name = "lblMonitor10";
            this.lblMonitor10.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor10.TabIndex = 1;
            this.lblMonitor10.Text = "10";
            this.lblMonitor10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor10.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor8
            // 
            this.lblMonitor8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor8.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor8.ForeColor = System.Drawing.Color.White;
            this.lblMonitor8.Location = new System.Drawing.Point(86, 228);
            this.lblMonitor8.Name = "lblMonitor8";
            this.lblMonitor8.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor8.TabIndex = 1;
            this.lblMonitor8.Text = "8";
            this.lblMonitor8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor8.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor6
            // 
            this.lblMonitor6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor6.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor6.ForeColor = System.Drawing.Color.White;
            this.lblMonitor6.Location = new System.Drawing.Point(86, 172);
            this.lblMonitor6.Name = "lblMonitor6";
            this.lblMonitor6.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor6.TabIndex = 1;
            this.lblMonitor6.Text = "6";
            this.lblMonitor6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor6.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor4
            // 
            this.lblMonitor4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor4.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor4.ForeColor = System.Drawing.Color.White;
            this.lblMonitor4.Location = new System.Drawing.Point(86, 115);
            this.lblMonitor4.Name = "lblMonitor4";
            this.lblMonitor4.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor4.TabIndex = 1;
            this.lblMonitor4.Text = "4";
            this.lblMonitor4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor4.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor2
            // 
            this.lblMonitor2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor2.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor2.ForeColor = System.Drawing.Color.White;
            this.lblMonitor2.Location = new System.Drawing.Point(86, 59);
            this.lblMonitor2.Name = "lblMonitor2";
            this.lblMonitor2.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor2.TabIndex = 1;
            this.lblMonitor2.Text = "2";
            this.lblMonitor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor2.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor11
            // 
            this.lblMonitor11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor11.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor11.ForeColor = System.Drawing.Color.White;
            this.lblMonitor11.Location = new System.Drawing.Point(14, 341);
            this.lblMonitor11.Name = "lblMonitor11";
            this.lblMonitor11.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor11.TabIndex = 1;
            this.lblMonitor11.Text = "11";
            this.lblMonitor11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor11.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor9
            // 
            this.lblMonitor9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor9.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor9.ForeColor = System.Drawing.Color.White;
            this.lblMonitor9.Location = new System.Drawing.Point(14, 285);
            this.lblMonitor9.Name = "lblMonitor9";
            this.lblMonitor9.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor9.TabIndex = 1;
            this.lblMonitor9.Text = "9";
            this.lblMonitor9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor9.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor7
            // 
            this.lblMonitor7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor7.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor7.ForeColor = System.Drawing.Color.White;
            this.lblMonitor7.Location = new System.Drawing.Point(14, 228);
            this.lblMonitor7.Name = "lblMonitor7";
            this.lblMonitor7.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor7.TabIndex = 1;
            this.lblMonitor7.Text = "7";
            this.lblMonitor7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor7.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor5
            // 
            this.lblMonitor5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor5.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor5.ForeColor = System.Drawing.Color.White;
            this.lblMonitor5.Location = new System.Drawing.Point(14, 172);
            this.lblMonitor5.Name = "lblMonitor5";
            this.lblMonitor5.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor5.TabIndex = 1;
            this.lblMonitor5.Text = "5";
            this.lblMonitor5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor5.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor3
            // 
            this.lblMonitor3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.lblMonitor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor3.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor3.ForeColor = System.Drawing.Color.White;
            this.lblMonitor3.Location = new System.Drawing.Point(14, 115);
            this.lblMonitor3.Name = "lblMonitor3";
            this.lblMonitor3.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor3.TabIndex = 1;
            this.lblMonitor3.Text = "3";
            this.lblMonitor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor3.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // lblMonitor1
            // 
            this.lblMonitor1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonitor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.lblMonitor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonitor1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblMonitor1.ForeColor = System.Drawing.Color.White;
            this.lblMonitor1.Location = new System.Drawing.Point(14, 59);
            this.lblMonitor1.Name = "lblMonitor1";
            this.lblMonitor1.Size = new System.Drawing.Size(60, 48);
            this.lblMonitor1.TabIndex = 1;
            this.lblMonitor1.Text = "1";
            this.lblMonitor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor1.Click += new System.EventHandler(this.lblMonitor_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "监测点";
            // 
            // Wxzt
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(206)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(206)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Wxzt";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1000, 720);
            this.Load += new System.EventHandler(this.Wxzt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDocumentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowsUIView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_xkt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_xzb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelMonitorContainer.ResumeLayout(false);
            this.panelMonitorContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private DevExpress.XtraBars.Docking2010.DocumentManager mainDocumentManager;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXZB;
        private DevExpress.XtraEditors.SimpleButton btnXKT;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView mainWindowsUIView;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup mainPageGroup;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document_xkt;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document_xzb;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMonitorContainer;
        private System.Windows.Forms.Label lblMonitor12;
        private System.Windows.Forms.Label lblMonitor10;
        private System.Windows.Forms.Label lblMonitor8;
        private System.Windows.Forms.Label lblMonitor6;
        private System.Windows.Forms.Label lblMonitor4;
        private System.Windows.Forms.Label lblMonitor2;
        private System.Windows.Forms.Label lblMonitor11;
        private System.Windows.Forms.Label lblMonitor9;
        private System.Windows.Forms.Label lblMonitor7;
        private System.Windows.Forms.Label lblMonitor5;
        private System.Windows.Forms.Label lblMonitor3;
        private System.Windows.Forms.Label lblMonitor1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;

    }
}

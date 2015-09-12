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
            ((System.ComponentModel.ISupportInitialize)(this.mainDocumentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowsUIView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_xkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_xzb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xtraUserControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraUserControl1.Appearance.Options.UseBackColor = true;
            this.xtraUserControl1.Location = new System.Drawing.Point(74, 36);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(880, 600);
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
            // Wxzt
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(206)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(206)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xtraUserControl1);
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

    }
}

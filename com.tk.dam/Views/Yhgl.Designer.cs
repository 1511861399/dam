namespace com.tk.dam.Views
{
    partial class Yhgl
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_xh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_xm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_dlm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_xb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_bm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_zw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_yhdj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_qx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_bz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户管理";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(58, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 525);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::com.tk.dam.Properties.Resources.bianji;
            this.pictureBox3.Location = new System.Drawing.Point(305, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::com.tk.dam.Properties.Resources.shanchu;
            this.pictureBox2.Location = new System.Drawing.Point(150, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::com.tk.dam.Properties.Resources.xinjian;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(884, 383);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_xh,
            this.gridColumn_xm,
            this.gridColumn_dlm,
            this.gridColumn_xb,
            this.gridColumn_bm,
            this.gridColumn_zw,
            this.gridColumn_yhdj,
            this.gridColumn_qx,
            this.gridColumn_bz});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn_xh
            // 
            this.gridColumn_xh.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_xh.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_xh.Caption = "序号";
            this.gridColumn_xh.Name = "gridColumn_xh";
            this.gridColumn_xh.Visible = true;
            this.gridColumn_xh.VisibleIndex = 0;
            this.gridColumn_xh.Width = 49;
            // 
            // gridColumn_xm
            // 
            this.gridColumn_xm.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_xm.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_xm.Caption = "姓名";
            this.gridColumn_xm.Name = "gridColumn_xm";
            this.gridColumn_xm.Visible = true;
            this.gridColumn_xm.VisibleIndex = 1;
            this.gridColumn_xm.Width = 99;
            // 
            // gridColumn_dlm
            // 
            this.gridColumn_dlm.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_dlm.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_dlm.Caption = "登录名";
            this.gridColumn_dlm.Name = "gridColumn_dlm";
            this.gridColumn_dlm.Visible = true;
            this.gridColumn_dlm.VisibleIndex = 2;
            this.gridColumn_dlm.Width = 99;
            // 
            // gridColumn_xb
            // 
            this.gridColumn_xb.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_xb.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_xb.Caption = "性别";
            this.gridColumn_xb.Name = "gridColumn_xb";
            this.gridColumn_xb.Visible = true;
            this.gridColumn_xb.VisibleIndex = 3;
            this.gridColumn_xb.Width = 99;
            // 
            // gridColumn_bm
            // 
            this.gridColumn_bm.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_bm.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_bm.Caption = "部门";
            this.gridColumn_bm.Name = "gridColumn_bm";
            this.gridColumn_bm.Visible = true;
            this.gridColumn_bm.VisibleIndex = 4;
            this.gridColumn_bm.Width = 99;
            // 
            // gridColumn_zw
            // 
            this.gridColumn_zw.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_zw.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_zw.Caption = "职位";
            this.gridColumn_zw.Name = "gridColumn_zw";
            this.gridColumn_zw.Visible = true;
            this.gridColumn_zw.VisibleIndex = 5;
            this.gridColumn_zw.Width = 99;
            // 
            // gridColumn_yhdj
            // 
            this.gridColumn_yhdj.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_yhdj.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_yhdj.Caption = "用户等级";
            this.gridColumn_yhdj.Name = "gridColumn_yhdj";
            this.gridColumn_yhdj.Visible = true;
            this.gridColumn_yhdj.VisibleIndex = 6;
            this.gridColumn_yhdj.Width = 99;
            // 
            // gridColumn_qx
            // 
            this.gridColumn_qx.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_qx.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_qx.Caption = "权限";
            this.gridColumn_qx.Name = "gridColumn_qx";
            this.gridColumn_qx.Visible = true;
            this.gridColumn_qx.VisibleIndex = 7;
            this.gridColumn_qx.Width = 99;
            // 
            // gridColumn_bz
            // 
            this.gridColumn_bz.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.gridColumn_bz.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn_bz.Caption = "备注";
            this.gridColumn_bz.Name = "gridColumn_bz";
            this.gridColumn_bz.Visible = true;
            this.gridColumn_bz.VisibleIndex = 8;
            this.gridColumn_bz.Width = 120;
            // 
            // Yhgl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Yhgl";
            this.Size = new System.Drawing.Size(1306, 670);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_xh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_xm;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_dlm;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_xb;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_bm;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_zw;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_yhdj;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_qx;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_bz;
    }
}

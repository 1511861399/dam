namespace com.tk.dam
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.pnlTitle = new DevExpress.XtraEditors.PanelControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ckRemeberPwd = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlCaption = new DevExpress.XtraEditors.PanelControl();
            this.lblSysName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckRemeberPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCaption)).BeginInit();
            this.pnlCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.lblError.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(300, 262);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(96, 12);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "用户名或密码错误";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.pnlTitle.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlTitle.Appearance.Options.UseBorderColor = true;
            this.pnlTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlTitle.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pnlTitle.Controls.Add(this.txtPassword);
            this.pnlTitle.Controls.Add(this.txtUserName);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.btnLogin);
            this.pnlTitle.Controls.Add(this.ckRemeberPwd);
            this.pnlTitle.Controls.Add(this.lblError);
            this.pnlTitle.Controls.Add(this.labelControl2);
            this.pnlTitle.Controls.Add(this.labelControl1);
            this.pnlTitle.Controls.Add(this.pnlCaption);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlTitle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(521, 347);
            this.pnlTitle.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(229, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(167, 170);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(229, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(321, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(167, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.UserLogin);
            // 
            // ckRemeberPwd
            // 
            this.ckRemeberPwd.Location = new System.Drawing.Point(167, 255);
            this.ckRemeberPwd.Name = "ckRemeberPwd";
            this.ckRemeberPwd.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.ckRemeberPwd.Properties.Appearance.Options.UseForeColor = true;
            this.ckRemeberPwd.Properties.Caption = "记住密码";
            this.ckRemeberPwd.Size = new System.Drawing.Size(77, 19);
            this.ckRemeberPwd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.labelControl2.Location = new System.Drawing.Point(93, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 21);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "密　码：";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.labelControl1.Location = new System.Drawing.Point(93, 168);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 21);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "用户名：";
            // 
            // pnlCaption
            // 
            this.pnlCaption.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.pnlCaption.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.pnlCaption.Appearance.Options.UseBackColor = true;
            this.pnlCaption.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlCaption.ContentImage = global::com.tk.dam.Properties.Resources.MainHeaderIcon_Backgroud;
            this.pnlCaption.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pnlCaption.Controls.Add(this.lblSysName);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaption.Location = new System.Drawing.Point(2, 2);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(517, 141);
            this.pnlCaption.TabIndex = 20;
            // 
            // lblSysName
            // 
            this.lblSysName.Appearance.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold);
            this.lblSysName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSysName.Location = new System.Drawing.Point(104, 48);
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(300, 40);
            this.lblSysName.TabIndex = 14;
            this.lblSysName.Text = "北斗大坝安全监测系统";
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 347);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "北斗大坝安全监测系统--登录界面";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckRemeberPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCaption)).EndInit();
            this.pnlCaption.ResumeLayout(false);
            this.pnlCaption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.PanelControl pnlTitle;
        private DevExpress.XtraEditors.LabelControl lblSysName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnlCaption;
        private DevExpress.XtraEditors.CheckEdit ckRemeberPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
    }
}
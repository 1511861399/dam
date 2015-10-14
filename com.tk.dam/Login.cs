#region 程序集引用
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using com.tk.dam.Entity;
using com.tk.dam.Util;
using com.tk.orm.dao;
using com.tk.orm.model;
#endregion

namespace com.tk.dam
{
    public partial class Login : XtraForm
    {
        AutoLoginUser _loginUser = null;
        public Login(AutoLoginUser loginUser)
        {
            InitializeComponent();
            InitUIProperty();
            LoginUser = loginUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.txtUserName.Focus();
        }

        /// <summary>
        /// 初始化界面事件
        /// </summary>
        private void InitUIProperty()
        {
            this.AcceptButton = btnLogin;
            pnlTitle.MouseDown += new MouseEventHandler(WinForm_MouseDown);
            pnlTitle.MouseUp += new MouseEventHandler(WinForm_MouseUp);
            pnlTitle.MouseMove += new MouseEventHandler(WinForm_MouseMove);
            pnlCaption.MouseDown += new MouseEventHandler(WinForm_MouseDown);
            pnlCaption.MouseUp += new MouseEventHandler(WinForm_MouseUp);
            pnlCaption.MouseMove += new MouseEventHandler(WinForm_MouseMove);
            this.Load += new EventHandler(Login_Load);
            lblError.Text = string.Empty;
        }

        /// <summary>
        /// 窗体加载完成后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Login_Load(object sender, EventArgs e)
        {
            if (LoginUser != null && LoginUser.RememberPwd)
            {
                ckRemeberPwd.Checked = true;
                txtUserName.Text = LoginUser.UserName;
                txtPassword.Text = LoginUser.PassWord;
            }
        }

        /// <summary>
        /// 重载关闭
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            this.lblError.Text = string.Empty;
            btnLogin.Text = "登录";
        }


        #region    ----  鼠标移动窗体 开始-------

        private Point mouseOffset;
        private bool isMouseDown = false;

        //鼠标松开时的处理事件
        public void WinForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        //鼠标在窗体任意位置按下时的处理事件
        public void WinForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        //移动鼠标时，窗体随之移动
        public void WinForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }
        #endregion    ----  鼠标移动窗体 结束-------

        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserLogin(object sender, EventArgs e)
        {
            Action Login = () =>
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    Error("用户名不能为空");
                    return;
                }
                else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    Error("密码不能为空");
                    return;
                }
                btnLogin.Text = "正在登录...";
                btnLogin.Enabled = false;

                IList<USER> users = USERDao.QueryForList(null).Where(
                    p => p.NAME == txtUserName.Text.Trim() && p.PASSWORD == txtPassword.Text.Trim()).ToList();

                if (users != null && users.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    IList<USERROLE> userRoles = USERROLEDao.QueryForListByUserId(users[0].ID);
                    IList<ROLERIGHT> roleRights = ROLERIGHTDao.QueryForList(null).Where(p => p.ROLE_ID == userRoles[0].ROLE_ID).ToList();
                    IList<RIGHT> rights = new List<RIGHT>();
                    foreach (var roleRight in roleRights)
                    {
                        foreach (var right in RIGHTDao.QueryForList(null).Where(p => p.ID == roleRight.RIGHT_ID))
                        {
                            rights.Add(right);
                        }
                    }

                    AutoLoginUtil autoLogin = new AutoLoginUtil();
                    AutoLoginUser loginUser = new AutoLoginUser();
                    loginUser.UserName = UserName;
                    loginUser.PassWord = PassWord;
                    loginUser.rights = rights;
                    if (ckRemeberPwd.Checked)
                    {
                        loginUser.RememberPwd = true;
                        autoLogin.SaveAutoLoginInfo(loginUser);
                    }
                    else
                    {
                        autoLogin.SaveAutoLoginInfo(new AutoLoginUser());
                    }
                    LoginUser = loginUser;
                }
                else
                {
                    btnLogin.Text = "登录";
                    btnLogin.Enabled = true;
                    string errorMessage = "用户名或密码错误";
                    Error(errorMessage);
                }
            };
            this.BeginInvoke(Login);
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get
            {
                return txtUserName.Text.Trim();
            }
            set
            {
                txtUserName.Text = value;

            }
        }

        public string PassWord
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }

        public AutoLoginUser LoginUser
        {
            get
            {
                return _loginUser;
            }

            set
            {
                _loginUser = value;
            }
        }


        /// <summary>
        /// 判断用户名密码是否完整
        /// </summary>
        /// <returns></returns>
        private bool IsPropertyComplete()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(PassWord))
            {
                return false;
            }
            else
            {
                lblError.Text = string.Empty;
                return true;
            }
        }

        public void Error(string msg)
        {
            lblError.Text = msg;
        }
    }
}
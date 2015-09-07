using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using com.tk.dam.Views;

namespace com.tk.dam
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        bool mIsMianFormShow = true;

        public MainForm()
        {
            InitializeComponent();

            int mSrceenWidth = Screen.PrimaryScreen.Bounds.Width;
            mainWindowsUIView.TileContainerProperties.ItemSize = 180 + (int)((mSrceenWidth - 1420) * 0.05);

            mainWindowsUIView.AppearanceActionsBar.BackColor = Color.FromArgb(0,169,254);

            DelegateAction mExitAction = new DelegateAction(canExecuteExitFunction, exitActionFunction);
            mExitAction.Caption = "Exit";
            mExitAction.Type = ActionType.Navigation;
            mExitAction.Edge = ActionEdge.Right;
            mExitAction.Behavior = ActionBehavior.HideBarOnClick;
            mExitAction.Image = Properties.Resources.icon_close32;
            mainWindowsUIView.ContentContainerActions.Add(mExitAction);

            DelegateAction mAboutAction = new DelegateAction(canExecuteAboutFunction, aboutActionFunction);
            mAboutAction.Caption = "About";
            mAboutAction.Type = ActionType.Navigation;
            mAboutAction.Edge = ActionEdge.Right;
            mAboutAction.Behavior = ActionBehavior.HideBarOnClick;
            mAboutAction.Image = Properties.Resources.icon_about32;
            mainWindowsUIView.ContentContainerActions.Add(mAboutAction);
        }


        private void mainWindowsUIView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document.Equals(documentDBYXZT))
            {
                e.Control = new Dbyxzk();
            }
            else if (e.Document.Equals(documentYHGL))
            {
                e.Control = new Yhgl();
            }
            else if (e.Document.Equals(documentXBJC))
            {
                e.Control = new Xbjc();
            }
            else if (e.Document.Equals(documentQX))
            {
                e.Control = new Qx();
            }
            else if (e.Document.Equals(documentSBZT))
            {
                e.Control = new Sbzt();
            }
            else if (e.Document.Equals(documentWXZT))
            {
                e.Control = new Wxzt();
            }
            else if (e.Document.Equals(documentSP))
            {
                e.Control = new Sp();
            }
            else
            {
                e.Control = new XtraUserControlBase();
            }
        }

        private void mainWindowsUIView_ContentContainerActionCustomization(object sender, ContentContainerActionCustomizationEventArgs e)
        {
            e.Remove(ContentContainerAction.Exit);
        }

        private void mainWindowsUIView_NavigatedTo(object sender, NavigationEventArgs e)
        {
            if (e.Document == null)
            {
                mIsMianFormShow = true;
                mainWindowsUIView.BackgroundImage = Properties.Resources.bg01;
            }
            else
            {
                mIsMianFormShow = false;
                mainWindowsUIView.BackgroundImage = Properties.Resources.bg02;
            }
        }

        private void mainWindowsUIView_NavigationBarsShowing(object sender, NavigationBarsCancelEventArgs e)
        {
            e.Cancel = mIsMianFormShow;
        }

        private void mainTileContainer_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Exit")
            {
                exitActionFunction();
            }
            else if (e.Button.Properties.Caption == "About")
            {
                aboutActionFunction();
            }
        }

        private bool canExecuteExitFunction()
        {
            return true;
        }
        private void exitActionFunction()
        {
            if (XtraMessageBox.Show("确定要退出系统吗?", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private bool canExecuteAboutFunction()
        {
            return true;
        }
        private void aboutActionFunction()
        {
            XtraMessageBox.Show("大坝安全检查系统V1.0版本", "关于");
        }
    }
}
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
using DevExpress.Utils;
using com.tk.dam.Entity;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;

namespace com.tk.dam
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        bool mIsCanShowNavBar = true;
        int mSrceenWidth;
        DelegateAction mThemeAction;
        Document mCurrentDocument;
        public bool IsPicTheme = false;
        popupTj mPopupTjControl = new popupTj();
        popupYHEdit mPopupYHEditControl = new popupYHEdit();
        private Random mRandom = new Random(360);
        Dictionary<string, List<double>> mXbjcDic = new Dictionary<string, List<double>>();
        Dictionary<string, List<int>> mWxztDic = new Dictionary<string, List<int>>();
        Dictionary<string, double> mQxDic = new Dictionary<string, double>();

        //Xbjc mXbjc;
        //Wxzt mWxzt;

        public MainForm()
        {

            InitializeComponent();

            //自定义滚动栏的样式
            var mCommonSkins = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            SkinElement skinScrollButton = mCommonSkins[CommonSkins.SkinScrollButton];
            skinScrollButton.Color.BackColor = Color.FromArgb(0, 126, 206);
            skinScrollButton.Image.ImageCount = 0;
            skinScrollButton.Glyph.ImageCount = 0;
            //skinScrollButton.Image.SetImage(Properties.Resources.scrollbutton_glyph, Color.Transparent);
            //skinScrollButton.Glyph.SetImage(Properties.Resources.scrollbutton_glyph, Color.Transparent);
            SkinElement skinScrollButtonThumb = mCommonSkins[CommonSkins.SkinScrollButtonThumb];
            skinScrollButtonThumb.Color.BackColor = Color.Transparent;
            skinScrollButtonThumb.Image.ImageCount = 0;
            skinScrollButtonThumb.Glyph.ImageCount = 0;
            //skinScrollButtonThumb.Image.SetImage(Properties.Resources.scrollthumbbutton, Color.Transparent);
            //skinScrollButtonThumb.Glyph.SetImage(Properties.Resources.scrollthumbbutton, Color.Transparent);            
            SkinElement skinSkinScrollShaft = mCommonSkins[CommonSkins.SkinScrollShaft];
            skinSkinScrollShaft.Color.BackColor = Color.Transparent;
            skinSkinScrollShaft.Image.ImageCount = 0;
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();


            mainWindowsUIView.Appearance.BackColor = Color.FromArgb(0, 126, 206);
            //mainWindowsUIView.AppearanceActionsBar.BackColor = Color.FromArgb(0, 169, 254);
            mainWindowsUIView.AppearanceActionsBar.BackColor = Color.FromArgb(0, 90, 144);

            mSrceenWidth = Screen.PrimaryScreen.Bounds.Width;
            mainWindowsUIView.TileContainerProperties.ItemSize = 180 + (int)((mSrceenWidth - 1500) * 0.05);

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

            mThemeAction = new DelegateAction(canExecuteThemeFunction, themeActionFunction);
            mThemeAction.Caption = "Picture Theme";
            mThemeAction.Type = ActionType.Context;
            mThemeAction.Edge = ActionEdge.Left;
            mThemeAction.Behavior = ActionBehavior.HideBarOnClick;
            mThemeAction.Image = Properties.Resources.icon_pic32;
            mainWindowsUIView.ContentContainerActions.Add(mThemeAction);

            mainWindowsUIView.AddDocument(mPopupTjControl);
            mainWindowsUIView.AddDocument(mPopupYHEditControl);

            
            for (int i = 1; i <= 12; i++)
            {              
                //形变监测
                List<double> xbjcList = new List<double>() { mRandom.Next(13) / 10.0f, mRandom.Next(24) / 10.0f };
                var frame = new TileItemFrame();
                frame.Tag = i;
                foreach (TileItemElement element in tileXBJC.Elements)
                {
                    frame.Elements.Add(element.Clone() as TileItemElement);
                }
                frame.Interval = 5000;
                if (xbjcList[0] < 1.0 && xbjcList[1] < 1.5)
                {
                    frame.Elements[1].Text = string.Format("站点{0}：未变化", i);
                }
                else
                {
                    frame.Elements[1].Text = string.Format("站点{0}：水平偏移:{1}mm  沉降:{2}mm", i, xbjcList[0], xbjcList[1]);
                    var font = frame.Elements[1].Appearance.Normal.Font;
                    frame.Elements[1].Appearance.Normal.Font = new Font(font.FontFamily, font.Size - 4);
                }
                tileXBJC.Frames.Add(frame);
                mXbjcDic.Add(i.ToString(), xbjcList);

                //卫星状态 
                List<int> wxztList = new List<int>() { mRandom.Next(2) + 8, mRandom.Next(2) + 5, mRandom.Next(2) + 5 };
                frame = new TileItemFrame();
                frame.Tag = i;
                foreach (TileItemElement element in tileWXZT.Elements)
                {
                    frame.Elements.Add(element.Clone() as TileItemElement);
                }
                frame.Interval = 13000;
                frame.Elements[1].Text = string.Format("站点{0}：BDS:{1}  GPS:{2}  GLO:{3}", i,wxztList[0],wxztList[1],wxztList[2]);
                tileWXZT.Frames.Add(frame);
                mWxztDic.Add(i.ToString(),wxztList);
            }
            mQxDic.Add("SW", 95);
            mQxDic.Add("WD", 30);
            tileQX.Elements[1].Text = string.Format("水位:{0}m  温度:{1}°C",mQxDic["SW"],mQxDic["WD"]);

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
            else if (e.Document.Equals(documentSWQX))
            {
                e.Control = new Qx();
            }
            else if (e.Document.Equals(documentSBZT))
            {
                e.Control = new com.tk.dam.Views.Sbzt();
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
            if (e.Document != popupTjDocument && e.Document != popupYHEditDocument)
            {
                mCurrentDocument = e.Document;
            }
            if (e.Document == null)
            {
                mIsCanShowNavBar = true;
                if (IsPicTheme)
                {
                    mainWindowsUIView.BackgroundImage = Properties.Resources.bg01;
                }
            }
            else
            {
                mIsCanShowNavBar = true;
                if (IsPicTheme && e.Document != popupTjDocument && e.Document != popupYHEditDocument)
                {
                    mainWindowsUIView.BackgroundImage = Properties.Resources.bg02;
                }
                if (e.Document == popupTjDocument || e.Document == popupYHEditDocument)
                {
                    mIsCanShowNavBar = false;
                    if (e.Document.Control.GetType() == typeof(popupTj))
                    {
                        mPopupTjControl.Reload();
                    }
                }
                else if (e.Document == documentWXZT)
                {
                    ((Wxzt)e.Document.Control).SetCurrentMonitor(tileWXZT.CurrentFrame.Tag.ToString());
                }
                else if (e.Document == documentXBJC)
                {
                    ((Xbjc)e.Document.Control).SetCurrentMonitor(tileXBJC.CurrentFrame.Tag.ToString());
                }
            }
        }

        private void mainWindowsUIView_NavigationBarsShowing(object sender, NavigationBarsCancelEventArgs e)
        {
            e.Cancel = !mIsCanShowNavBar;
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

        private void tileZJ_Click(object sender, TileClickEventArgs e)
        {
            mainWindowsUIView.ActivateContainer(popupTjFlyout);
            e.Handled = true;
        }

        private void tileNotImplement_Click(object sender, TileClickEventArgs e)
        {
            var notImplmentAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
            {
                Caption = "提示",
                Description = "该功能正在研发中，敬请期待....."
            };
            notImplmentAction.Commands.Add(FlyoutCommand.OK);
            closeAppFlyout.Action = notImplmentAction;
            mainWindowsUIView.ShowFlyoutDialog(closeAppFlyout);
            e.Handled = true;
        }

        private bool canExecuteExitFunction()
        {
            return true;
        }
        private void exitActionFunction()
        {
            var closeAppAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
            {
                Caption = "退出",
                Description = "确定要退出系统吗?"
            };
            closeAppAction.Commands.Add(FlyoutCommand.Yes);
            closeAppAction.Commands.Add(FlyoutCommand.No);
            closeAppFlyout.Action = closeAppAction;
            if (mainWindowsUIView.ShowFlyoutDialog(closeAppFlyout) == System.Windows.Forms.DialogResult.Yes)
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
            var aboutAppAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
            {
                Caption = "关于",
                Description = "北斗大坝安全监测系统 V1.0\nCopyright@2012 福建泉州泰克通信设备有限公司"
            };
            aboutAppAction.Commands.Add(FlyoutCommand.OK);
            closeAppFlyout.Action = aboutAppAction;
            mainWindowsUIView.ShowFlyoutDialog(closeAppFlyout);
        }
        private bool canExecuteThemeFunction()
        {
            return true;
        }
        private void themeActionFunction()
        {
            IsPicTheme = !IsPicTheme;
            if (IsPicTheme)
            {
                mThemeAction.Caption = "Color Theme";
                mThemeAction.Image = Properties.Resources.icon_color32;
                if (mCurrentDocument == null)
                {
                    mainWindowsUIView.BackgroundImage = Properties.Resources.bg01;
                }
                else
                {
                    mainWindowsUIView.BackgroundImage = Properties.Resources.bg02;
                }
            }
            else
            {
                mThemeAction.Caption = "Picture Theme";
                mThemeAction.Image = Properties.Resources.icon_pic32;
                mainWindowsUIView.BackgroundImage = null;
            }
            if (mCurrentDocument != null)
            {
                mCurrentDocument.Control.Refresh();
            }

        }

        #region 外部调用接口

        public IList<TjItemEnum> SelectedTjItems
        {
            get
            {
                var mItems = new List<TjItemEnum>();
                if (tileSJDY.Visible.Value)
                {
                    mItems.Add(TjItemEnum.数据打印);
                }
                if (tileNBJC.Visible.Value)
                {
                    mItems.Add(TjItemEnum.内部监测);
                }
                if (tileKQYS.Visible.Value)
                {
                    mItems.Add(TjItemEnum.库区雨水);
                }
                if (tileGCJS.Visible.Value)
                {
                    mItems.Add(TjItemEnum.工程介绍);
                }
                if (tileZHJS.Visible.Value)
                {
                    mItems.Add(TjItemEnum.知识介绍);
                }
                return mItems;
            }
            set
            {
                tileSJDY.Visible = value.Contains(TjItemEnum.数据打印);
                tileNBJC.Visible = value.Contains(TjItemEnum.内部监测);
                tileKQYS.Visible = value.Contains(TjItemEnum.库区雨水);
                tileGCJS.Visible = value.Contains(TjItemEnum.工程介绍);
                tileZHJS.Visible = value.Contains(TjItemEnum.知识介绍);
            }
        }

        public void HidenFlyout()
        {
            mainWindowsUIView.HideFlyout();
        }

        /// <summary>
        /// 显示用户编辑界面
        /// </summary>
        /// <param name="yh">用户为空时表示新增用户</param>
        public void ShowYHEditFlyout(Yh yh)
        {
            mPopupYHEditControl.SetCurrentYH(yh);
            mainWindowsUIView.ActivateContainer(popupYHEditFlyout);
        }

        /// <summary>
        /// 显示删除用户确认界面
        /// </summary>
        /// <param name="yh">待删除的用户</param>
        public void ShowDeleteYHConfirm(Yh yh)
        {
            var deleteYHAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
            {
                Caption = "删除确认",
                Description = string.Format("确定要删除【{0}】用户吗?", yh.Xm)
            };
            deleteYHAction.Commands.Add(FlyoutCommand.Yes);
            deleteYHAction.Commands.Add(FlyoutCommand.No);
            closeAppFlyout.Action = deleteYHAction;
            if (mainWindowsUIView.ShowFlyoutDialog(closeAppFlyout) == DialogResult.Yes)
            {
                ((Yhgl)mCurrentDocument.Control).DeleteYH(yh);
            }
        }

        /// <summary>
        ///  更新用户
        /// </summary>
        /// <param name="yh">用户对象</param>
        /// <param name="isNew">是否新增</param>
        public void UpdateYHList(Yh yh, bool isNew)
        {
            if (mCurrentDocument != null)
            {
                if (mCurrentDocument.Control.GetType() == typeof(Yhgl))
                {
                    ((Yhgl)mCurrentDocument.Control).UpdateYHList(yh, isNew);
                }
            }
        }

        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="caption">消息标题</param>
        /// <param name="message">消息内容</param>
        public void ShowMessage(string caption, string message)
        {
            var messageAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
            {
                Caption = caption,
                Description = message
            };
            messageAction.Commands.Add(FlyoutCommand.OK);
            closeAppFlyout.Action = messageAction;
            mainWindowsUIView.ShowFlyoutDialog(closeAppFlyout);
        }

        public Dictionary<string, List<double>> XbjcDic
        {
            get { return mXbjcDic; }
        }

        public Dictionary<string, List<int>> WxztDic
        {
            get { return mWxztDic; }
        }

        public Dictionary<string,double> QxDic
        {
            get { return mQxDic; }
            set 
            {
                mQxDic = value;
                tileQX.Elements[1].Text = string.Format("水位:{0}m  温度:{1}°C", mQxDic["SW"], mQxDic["WD"]);
            }
        }

        #endregion


    }

    public enum TjItemEnum
    {
        数据打印,
        内部监测,
        库区雨水,
        工程介绍,
        知识介绍
    }

}
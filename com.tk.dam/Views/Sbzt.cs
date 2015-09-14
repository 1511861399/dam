using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;
using System.IO;
using System.Collections;

namespace com.tk.dam.Views
{
    public partial class Sbzt : XtraUserControlBase
    {
        List<com.tk.dam.Entity.Sbzt> mDeviceList;
        private Color mSelectedColor = Color.FromArgb(235, 163, 17);
        private Color mUnSelectedColor = Color.FromArgb(182, 182, 182);
        private Panel mCurrentMenu;
        protected WindowsUIView View { get; set; }
        private Sbsz_Bjsz mBjsz;
        private Sbsz_Xtsz mXtsz;
        private Sbsz_Xtcq mXtcs;
        private Sbsz_Hfccsz mHfccsz;
        private Label mCurrentDeviceLabel;

        public Sbzt()
        {
            InitializeComponent();
            mBjsz = new Sbsz_Bjsz();
            mBjsz.SaveEvent += mBjsz_SaveEvent;
            mXtsz = new Sbsz_Xtsz();
            mXtcs = new Sbsz_Xtcq();
            mHfccsz = new Sbsz_Hfccsz();
            windowsUIView1.AddDocument(mBjsz);
            windowsUIView1.AddDocument(mXtsz);
            windowsUIView1.AddDocument(mXtcs);
            windowsUIView1.AddDocument(mHfccsz);
            pageGroup1.Properties.ShowPageHeaders = DevExpress.Utils.DefaultBoolean.False;
            windowsUIView1.NavigationBarsShowing += new NavigationBarsCancelEventHandler(onShowingNavigationBars);
            windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.VerticalSlide;
        }

        void mBjsz_SaveEvent(object sender, Sbsz_Bjsz.SaveEventArgs e)
        {
            for (int i = 0; i < mDeviceList.Count; i++)
            {
                if (mDeviceList[i].mId == e.mSbztEntity.mId)
                {
                    mDeviceList[i] = e.mSbztEntity;
                    save(mDeviceList);
                }
            }
        }
        private void Sbzt_Load(object sender, EventArgs e)
        {

            int mDeltaH = (int)((this.Height - 670) * 0.67);
            int mDelatW = (int)((this.Width - 1024) * 0.67);
            if (mDeltaH > 0 && mDelatW > 0)
            {
                if (mDelatW / mDeltaH > 1024 / 670)
                {
                    mDelatW = (int)(mDeltaH * 1024 / 670);
                }
                else
                {
                    mDeltaH = (int)(mDelatW * 670 / 1024);
                }

                this.mPanel.Height = 450 + mDeltaH;
                this.mPanel.Width = 1012 + mDelatW;
                int mNewX = this.mPanel.Location.X - (int)(mDelatW * 0.5);
                int mNewY = this.mPanel.Location.Y - (int)(mDeltaH * 0.6);
                this.mPanel.Location = new Point(mNewX, mNewY);
            }
            mCurrentMenu = mMenuBjsz;
            menu_panel_click(mCurrentMenu, null);
            getDeviceList();

            setView("1");
            mCurrentDeviceLabel = lblMonitor1;
        }
        private void menu_panel_click(object sender, EventArgs e)
        {
            mCurrentMenu.BackColor = Color.White;
            Label label = (Label)mCurrentMenu.Controls[0];
            label.ForeColor = Color.Black;

            Panel panel = (Panel)sender;
            panel.BackColor = mSelectedColor;
            label = (Label)panel.Controls[0];
            label.ForeColor = Color.White;
            mCurrentMenu = panel;
            if (View != null)
                View.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.RandomSegmentedFade;
            if (panel.Tag.ToString() == "bjsz")
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.HorizontalSlide;
                windowsUIView1.Controller.Activate(document1);
            }
            if (panel.Tag.ToString() == "xtsz")
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.HorizontalSlide;
                windowsUIView1.Controller.Activate(document2);
            }
            if (panel.Tag.ToString() == "xtcq")
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.HorizontalSlide;
                windowsUIView1.Controller.Activate(document3);
            }
            if (panel.Tag.ToString() == "hfccsz")
            {
                windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = TransitionAnimation.HorizontalSlide;
                windowsUIView1.Controller.Activate(document4);
            }
        }

        private void menulabel_click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            object parent = null;
            if (label.Name == "mLblBjsz")
            {
                parent = mMenuBjsz;
            }
            if (label.Name == "mLblXtsz")
            {
                parent = mMenuXtsz;
            }
            if (label.Name == "mLblXtcq")
            {
                parent = mMenuXtcq;
            }
            if (label.Name == "mLblHfccsz")
            {
                parent = mMenuHfccsz;
            }
            menu_panel_click(parent, null);
        }
        void onShowingNavigationBars(object sender, NavigationBarsCancelEventArgs e)
        {
            e.Cancel = true;
        }



        private static string read(string path)
        {
            StreamReader objReader = new StreamReader(path);
            string sLine = "";
            string result = "";
            ArrayList LineList = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null && !sLine.Equals(""))
                {
                    result += sLine + "\n";
                }
            }
            objReader.Close();
            return result;
        }

        private void save(string path, string text)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(text);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }


        private  void init(string id)
        {
            if (mDeviceList == null)
            {
                mDeviceList = new List<Entity.Sbzt>();
            }
            com.tk.dam.Entity.Sbzt sbzt = new com.tk.dam.Entity.Sbzt();
            sbzt.mId = "1";
            sbzt.mBjsz = new com.tk.dam.Entity.Sb_Bjsz();
            sbzt.mCssz = new com.tk.dam.Entity.Sb_Cssz();
            sbzt.mXtbj = new com.tk.dam.Entity.Sb_Xtbj();
            sbzt.mXtsz = new com.tk.dam.Entity.Sb_Xtsz();
            sbzt.mZtzy = new Entity.Sb_Ztzy();

            sbzt.mBjsz.mQy = 1;
            sbzt.mBjsz.mCsjg = 10;
            sbzt.mBjsz.mJm = 1;
            sbzt.mBjsz.mIP = "192.168.3.33";
            sbzt.mBjsz.mWlxz = "有线";
            sbzt.mBjsz.mDk = "5000";
            sbzt.mBjsz.mCsxy = "TCP/IP";
            sbzt.mBjsz.mSjgs = "原始数据";
            sbzt.mBjsz.mBddkh = "0";

            sbzt.mCssz.mIP = "192.168.3.10";
            sbzt.mCssz.mZdmc = "站点1";
            sbzt.mCssz.mWgdz = "192.168.3.1";
            sbzt.mCssz.mUTC = "UTC+8";

            sbzt.mXtsz.mJlzt = "1";
            sbzt.mXtsz.mJlfs = "每天";
            sbzt.mXtsz.mJlgs = "原始数据";
            sbzt.mXtsz.mFgwj = "连续记录不分割";
            sbzt.mXtsz.mJljg = "1";
            sbzt.mXtsz.mBsm = "GPS0";

            sbzt.mXtbj.mBjfs = "电话";
            sbzt.mXtbj.mSpjx = "30";
            sbzt.mXtbj.mBjmb = "13588888888";
            sbzt.mXtbj.mCzjx = "50";

            sbzt.mZtzy.mZdmc = "SMSK";
            sbzt.mZtzy.mSbbh = "11350025";
            sbzt.mZtzy.mGPS = "7";
            sbzt.mZtzy.mBDS = "12";
            sbzt.mZtzy.mGLO = "7";
            sbzt.mZtzy.mWl = "on";
            sbzt.mZtzy.mLj = "1";
            sbzt.mZtzy.mCk = "off";
            sbzt.mZtzy.mTd = "0";
            sbzt.mZtzy.mJl = "0";
            sbzt.mZtzy.mSm = "1";
            sbzt.mZtzy.mDy = "8.6";
            sbzt.mZtzy.mUpzt = "未插入";
            mDeviceList.Add(sbzt);


            sbzt = new com.tk.dam.Entity.Sbzt();
            sbzt.mId = "2";
            sbzt.mBjsz = new com.tk.dam.Entity.Sb_Bjsz();
            sbzt.mCssz = new com.tk.dam.Entity.Sb_Cssz();
            sbzt.mXtbj = new com.tk.dam.Entity.Sb_Xtbj();
            sbzt.mXtsz = new com.tk.dam.Entity.Sb_Xtsz();
            sbzt.mZtzy = new Entity.Sb_Ztzy();

            sbzt.mBjsz.mQy = 1;
            sbzt.mBjsz.mCsjg = 10;
            sbzt.mBjsz.mJm = 1;
            sbzt.mBjsz.mIP = "192.168.3.34";
            sbzt.mBjsz.mWlxz = "WIFI";
            sbzt.mBjsz.mDk = "5001";
            sbzt.mBjsz.mCsxy = "TCP/IP";
            sbzt.mBjsz.mSjgs = "原始数据";
            sbzt.mBjsz.mBddkh = "0";

            sbzt.mCssz.mIP = "192.168.3.12";
            sbzt.mCssz.mZdmc = "站点1";
            sbzt.mCssz.mWgdz = "192.168.3.1";
            sbzt.mCssz.mUTC = "UTC+8";

            sbzt.mXtsz.mJlzt = "1";
            sbzt.mXtsz.mJlfs = "每天";
            sbzt.mXtsz.mJlgs = "标准数据";
            sbzt.mXtsz.mFgwj = "连续记录不分割";
            sbzt.mXtsz.mJljg = "1";
            sbzt.mXtsz.mBsm = "GPS1";

            sbzt.mXtbj.mBjfs = "电话";
            sbzt.mXtbj.mSpjx = "20";
            sbzt.mXtbj.mBjmb = "13588888888";
            sbzt.mXtbj.mCzjx = "30";

            sbzt.mZtzy.mZdmc = "SMSK1";
            sbzt.mZtzy.mSbbh = "113500001";
            sbzt.mZtzy.mGPS = "5";
            sbzt.mZtzy.mBDS = "8";
            sbzt.mZtzy.mGLO = "6";
            sbzt.mZtzy.mWl = "off";
            sbzt.mZtzy.mLj = "1";
            sbzt.mZtzy.mCk = "on";
            sbzt.mZtzy.mTd = "0";
            sbzt.mZtzy.mJl = "0";
            sbzt.mZtzy.mSm = "1";
            sbzt.mZtzy.mDy = "8.2";
            sbzt.mZtzy.mUpzt = "未插入";
            mDeviceList.Add(sbzt);


            sbzt = initDefault();
            sbzt.mId = "3";

            sbzt = initDefault();
            sbzt.mId = "4";

            sbzt = initDefault();
            sbzt.mId = "5";

            sbzt = initDefault();
            sbzt.mId = "6";

            sbzt = initDefault();
            sbzt.mId = "7"; 

            sbzt = initDefault();
            sbzt.mId = "8";
             
            sbzt = initDefault();
            sbzt.mId = "9";

            sbzt = initDefault();
            sbzt.mId = "10";

            sbzt = initDefault();
            sbzt.mId = "11";

            sbzt = initDefault();
            sbzt.mId = "12";
            save(mDeviceList);
        }

        private Entity.Sbzt initDefault()
        {
            com.tk.dam.Entity.Sbzt sbzt = new com.tk.dam.Entity.Sbzt();
            sbzt.mId = "12";
            sbzt.mBjsz = new com.tk.dam.Entity.Sb_Bjsz();
            sbzt.mCssz = new com.tk.dam.Entity.Sb_Cssz();
            sbzt.mXtbj = new com.tk.dam.Entity.Sb_Xtbj();
            sbzt.mXtsz = new com.tk.dam.Entity.Sb_Xtsz();
            sbzt.mZtzy = new Entity.Sb_Ztzy();

            sbzt.mBjsz.mQy = 1;
            sbzt.mBjsz.mCsjg = 10;
            sbzt.mBjsz.mJm = 1;
            sbzt.mBjsz.mIP = "192.168.3.10";
            sbzt.mBjsz.mWlxz = "WIFI";
            sbzt.mBjsz.mDk = "5001";
            sbzt.mBjsz.mCsxy = "TCP/IP";
            sbzt.mBjsz.mSjgs = "原始数据";
            sbzt.mBjsz.mBddkh = "0";

            sbzt.mCssz.mIP = "192.168.3.10";
            sbzt.mCssz.mZdmc = "站点1";
            sbzt.mCssz.mWgdz = "192.168.3.1";
            sbzt.mCssz.mUTC = "UTC+8";

            sbzt.mXtsz.mJlzt = "1";
            sbzt.mXtsz.mJlfs = "每天";
            sbzt.mXtsz.mJlgs = "标准数据";
            sbzt.mXtsz.mFgwj = "连续记录不分割";
            sbzt.mXtsz.mJljg = "1";
            sbzt.mXtsz.mBsm = "GPS1";

            sbzt.mXtbj.mBjfs = "电话";
            sbzt.mXtbj.mSpjx = "20";
            sbzt.mXtbj.mBjmb = "13588888888";
            sbzt.mXtbj.mCzjx = "30";

            sbzt.mZtzy.mZdmc = "SMSK1";
            sbzt.mZtzy.mSbbh = "113500001";
            sbzt.mZtzy.mGPS = "5";
            sbzt.mZtzy.mBDS = "8";
            sbzt.mZtzy.mGLO = "6";
            sbzt.mZtzy.mWl = "off";
            sbzt.mZtzy.mLj = "1";
            sbzt.mZtzy.mCk = "on";
            sbzt.mZtzy.mTd = "0";
            sbzt.mZtzy.mJl = "0";
            sbzt.mZtzy.mSm = "1";
            sbzt.mZtzy.mDy = "8.2";
            sbzt.mZtzy.mUpzt = "未插入";
            mDeviceList.Add(sbzt);
            return sbzt;
        }


        private  void getDeviceList()
        {
            if (mDeviceList != null)
            {
                return;
            }
            string strs = read("devices\\devices.xml");
            if (string.IsNullOrEmpty(strs))
            {
                mDeviceList = (List<com.tk.dam.Entity.Sbzt>)XmlUtil.Deserialize(typeof(List<com.tk.dam.Entity.Sbzt>), strs);
            }
            if (mDeviceList == null)
            {
                init("");
            }
        }
        private void getDeviceList(string deviceid)
        {
        }
        private  void save(List<com.tk.dam.Entity.Sbzt> list)
        {
            string text = XmlUtil.Serializer(typeof(List<com.tk.dam.Entity.Sbzt>), list);
            text = text + "";
            if (Directory.Exists("devices") == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory("devices");
            }
            save("devices\\devices.xml", text);
        }

        private void device_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string id = label.Text;
            label.BackColor = mSelectedColor;
            if (mCurrentDeviceLabel != null)
            {
                mCurrentDeviceLabel.BackColor = mUnSelectedColor;
            }
            mCurrentDeviceLabel = label;
            setView(id);
        }

        private void setView( string id)
        {
            com.tk.dam.Entity.Sbzt mCurrentEntity = null;
            foreach (com.tk.dam.Entity.Sbzt entity in mDeviceList)
            {
                if (entity.mId == id)
                {
                    mCurrentEntity = entity;
                }
            }
            if (mCurrentEntity == null)
            {
                mCurrentEntity = initDefault();
                mCurrentEntity.mId = id;
            }
            mBjsz.setValue(mCurrentEntity);
            mXtsz.setValue(mCurrentEntity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace com.tk.dam.Views
{
    public partial class Sbsz_Bjsz : DevExpress.XtraEditors.XtraUserControl
    {
        private Color mSelectedColor = Color.FromArgb(235, 163, 17);
        private Color mUnSelectedColor = Color.FromArgb(182, 182, 182);
        private Entity.Sbzt mSbztObj;
        public Sbsz_Bjsz()
        {
            InitializeComponent();
            mPanelEditWlsz.Visible = false;
            mPanelEditWlcs.Visible=false;
            //mCmbCsjg.SelectedIndex = 0;
            mCmbCsjg.SelectedIndex = 0;
            mCmbCsxy.SelectedIndex = 0;
            mCmbSjgs.SelectedIndex = 0;
            mCmbWlxz.SelectedIndex = 0;
        }
        public void setValue( Entity.Sbzt sbzt)
        {
            mSbztObj = sbzt;
            lblWl_Qy.Text = mSbztObj.mBjsz.mQy==1?"是":"否";
            mLblZt.Text = mSbztObj.mBjsz.mZt == -11 ? "未连接" : "连接";
            mPbZt.Image = getImage(mSbztObj.mBjsz.mZt);
            lblWl_Fs.Text = mSbztObj.mBjsz.mWlxz;
            lblWl_Xy.Text = mSbztObj.mBjsz.mCsxy;
            lblWl_Sjgs.Text = mSbztObj.mBjsz.mSjgs;
            lblWl_IP.Text = mSbztObj.mBjsz.mIP;
            //编辑界面
            mCkCszt.Checked = mSbztObj.mBjsz.mQy == 1;
            mCkJm.Checked = mSbztObj.mBjsz.mJm == 1;
            mCmbCsjg.Text = mSbztObj.mBjsz.mCsjg.ToString();
            mTxtIP.Text = mSbztObj.mBjsz.mIP;
            mCmbWlxz.Text = mSbztObj.mBjsz.mWlxz;
            mCmbCsxy.Text = mSbztObj.mBjsz.mCsxy;
            mTxtPort.Text = mSbztObj.mBjsz.mDk;
            mCmbSjgs.Text = mSbztObj.mBjsz.mSjgs;
            mTxtLocalPort.Text = mSbztObj.mBjsz.mBddkh;

            lblCs_Zd.Text = mSbztObj.mCssz.mZdmc;
            lblCs_Mc.Text = mSbztObj.mCssz.mIP;
            lblCs_Wg.Text = mSbztObj.mCssz.mWgdz;
            lblCs_Sq.Text = mSbztObj.mCssz.mUTC;

            mTxtIPCS.Text = mSbztObj.mCssz.mIP;
            mTxtZdmc.Text = mSbztObj.mCssz.mZdmc;
            mTxtWgdz.Text = mSbztObj.mCssz.mWgdz;
            mCmbUTC.Text = mSbztObj.mCssz.mUTC;
        }

        private Image getImage(int zt)
        {
            if (zt == 0)
            {
                return global::com.tk.dam.Properties.Resources.wl0;
            }
            if (zt == 1)
            {
                return global::com.tk.dam.Properties.Resources.wl1;
            }
            if (zt == 2)
            {
                return global::com.tk.dam.Properties.Resources.wl2;
            }
            if (zt == 3)
            {
                return global::com.tk.dam.Properties.Resources.wl3;
            }
            return global::com.tk.dam.Properties.Resources.wl3;
        }

    
        private void btnBj_Wl_Click(object sender, EventArgs e)
        {
            btnGb_CS_Click(null, null);
            mPanelEditWlsz.Visible = true;
            btnBj_Wl.BackColor = mSelectedColor;
        }

        private void btnWl_Gb_Click(object sender, EventArgs e)
        {
            mPanelEditWlsz.Visible = false;
            btnBj_Wl.BackColor = mUnSelectedColor;
        }

        private void btnGb_CS_Click(object sender, EventArgs e)
        {
            btnBj_Cs.BackColor = mUnSelectedColor;
            mPanelEditWlcs.Visible = false ;
        }

        private void btnBj_Cs_Click(object sender, EventArgs e)
        { 
            btnWl_Gb_Click(null, null);
            mPanelEditWlcs.Visible = true;
            btnBj_Cs.BackColor = mSelectedColor;
        }

        //定义事件参数类
        public class SaveEventArgs : EventArgs
        {
            public readonly Entity.Sbzt mSbztEntity;
            public SaveEventArgs(Entity.Sbzt sbztEntity)
            {
                mSbztEntity = sbztEntity;
            }
        }

        //定义delegate
        public delegate void SaveEventHandler(object sender, SaveEventArgs e);
        //用event 关键字声明事件对象
        public event SaveEventHandler SaveEvent;

        //事件触发方法
        protected virtual void OnSaveEvent(SaveEventArgs e)
        {
            if (SaveEvent != null)
                SaveEvent(this, e);
        }

        //引发事件
        public void RaiseEvent(Entity.Sbzt sbztEntity)
        {
            SaveEventArgs e = new SaveEventArgs(sbztEntity);
            OnSaveEvent(e);
        }

        private void mLblSaveWlsz_Click(object sender, EventArgs e)
        {
            RaiseEvent(getViewValue());
        }

        private Entity.Sbzt getViewValue()
        {
            //throw new NotImplementedException();
        }

        private void mLblResetWlsz_Click(object sender, EventArgs e)
        {

        }

        private void mLblBcCs_Click(object sender, EventArgs e)
        {
            RaiseEvent(getViewValue());
        }

        private void mLblCzcs_Click(object sender, EventArgs e)
        {

        }
    }
}

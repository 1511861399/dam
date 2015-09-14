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
    public partial class Sbsz_Xtsz : DevExpress.XtraEditors.XtraUserControl
    {
        private Color mSelectedColor = Color.FromArgb(235, 163, 17);
        private Color mUnSelectedColor = Color.FromArgb(182, 182, 182);
        private Entity.Sbzt mSbztObj; 
        public Sbsz_Xtsz()
        {
            InitializeComponent();
            mPanelEditSjjl.Visible = false;
            mPanelEditXtbj.Visible = false;
        }


        private void btnBj_Sjjl_Click(object sender, EventArgs e)
        {
            btnGb_Xtbj_Click(null, null);
            mPanelEditSjjl.Visible = true;
            btnBj_Sjjl.BackColor = mSelectedColor;
        }

        private void btnGb_Sjjl_Click(object sender, EventArgs e)
        {
            mPanelEditSjjl.Visible = false;
            btnBj_Sjjl.BackColor = mUnSelectedColor;
        }

        private void btnGb_Xtbj_Click(object sender, EventArgs e)
        {
            btnBj_Xtbj.BackColor = mUnSelectedColor;
            mPanelEditXtbj.Visible = false;
        }

        private void btnBj_Xtbj_Click(object sender, EventArgs e)
        {
            btnGb_Sjjl_Click(null, null);
            mPanelEditXtbj.Visible = true;
            btnBj_Xtbj.BackColor = mSelectedColor;
        }

        internal void setValue(Entity.Sbzt entity)
        {
            mSbztObj = entity;
            lblSjjl_Qy.Text = mSbztObj.mXtsz.mJlzt;
            lblSjjl_Jlgs.Text = mSbztObj.mXtsz.mJlgs;
            lblSjjl_Jg.Text = mSbztObj.mXtsz.mJljg;
            lblSjjl_Bsm.Text = mSbztObj.mXtsz.mBsm;
            lblSjjl_Wjdx.Text = mSbztObj.mXtsz.mWjdx;
            lblSjjl_Jlms.Text = mSbztObj.mXtsz.mJlfs;

            mCKJlzt.Checked = mSbztObj.mXtsz.mJlzt == "1";
            mCmbJlfs.Text = mSbztObj.mXtsz.mJlfs;
            mCmbJlgs.Text = mSbztObj.mXtsz.mJlgs;
            mCmbFgwj.Text = mSbztObj.mXtsz.mFgwj;
            mCmbJljg.Text = mSbztObj.mXtsz.mJljg;
            mTxtBsm.Text = mSbztObj.mXtsz.mBsm;

            lblCs_Zd.Text = mSbztObj.mXtbj.mBjfs;
            lblCs_Mc.Text = mSbztObj.mXtbj.mBjmb;
            lblCs_Wg.Text = mSbztObj.mXtbj.mSpjx + "/" + mSbztObj.mXtbj.mCzjx;

            mCmbBjfs.Text = mSbztObj.mXtbj.mBjfs;
            mTxtSpjx.Text = mSbztObj.mXtbj.mSpjx;
            mTxtBjmb.Text = mSbztObj.mXtbj.mBjmb;
            mTxtCzjx.Text = mSbztObj.mXtbj.mCzjx;
        }

        private Entity.Sbzt getViewValue()
        {
            mSbztObj.mXtsz.mJlzt=mCKJlzt.Checked?"1":"0";
            mSbztObj.mXtsz.mJlfs= mCmbJlfs.Text ;
            mSbztObj.mXtsz.mJlgs= mCmbJlgs.Text;
            mSbztObj.mXtsz.mFgwj = mCmbFgwj.Text;
            mSbztObj.mXtsz.mJljg =mCmbJljg.Text  ;
            mSbztObj.mXtsz.mBsm= mTxtBsm.Text;

            mSbztObj.mXtbj.mBjfs= mCmbBjfs.Text;
            mSbztObj.mXtbj.mSpjx=mTxtSpjx.Text ;
            mSbztObj.mXtbj.mBjmb=mTxtBjmb.Text;
            mSbztObj.mXtbj.mCzjx= mTxtCzjx.Text;

            setValue(mSbztObj);
            return mSbztObj;
        }


        private void mBcBjsz_Click(object sender, EventArgs e)
        {
            RaiseEvent(getViewValue());
        }

        private void mCzBjsz_Click(object sender, EventArgs e)
        {
            setValue(mSbztObj);
        }

        private void mBcXtsz_Click(object sender, EventArgs e)
        {
            RaiseEvent(getViewValue());
        }


        private void mCzXtsz_Click(object sender, EventArgs e)
        {
            setValue(mSbztObj);
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
    }
}

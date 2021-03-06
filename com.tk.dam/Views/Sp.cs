﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;

namespace com.tk.dam.Views
{
    public partial class Sp : XtraUserControlBase
    {
        public Sp()
        {
            InitializeComponent();
        }

        private void Sp_Load(object sender, EventArgs e)
        {
            videoCtrl(pboxVideo2, lblVideo2, pboxVideo2.Name);
            setAudioOff();
            panel25.Parent = pboxVideo2;
            panel25.DoubleClick += panel25_DoubleClick;
            pictureBox5.Visible = false;
        }

        private void panelMenu_MouseEnter(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.Cursor = Cursors.Hand;
            panel.BackColor = Color.FromArgb(227, 166, 41);
        }

        private void panelMenu_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.BackColor = Color.FromArgb(0, 89, 145);
        }

        private void panelViedo_MouseEnter(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.Cursor = Cursors.Hand;
            panel.BorderStyle = BorderStyle.Fixed3D;
            //panel.
        }

        private void panelVideo_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.BorderStyle = BorderStyle.None;
            //panel.BackColor = Color.FromArgb(0, 89, 145);
        }

        private void panel8_DoubleClick(object sender, EventArgs e)
        {
            //videoCtrl(pboxVideo1, lblVideo1, pboxVideo1.Name);
        }

        private void panel10_DoubleClick(object sender, EventArgs e)
        {
            //videoCtrl(pboxVideo2, lblVideo2, pboxVideo2.Name);
        }

        private void panel12_DoubleClick(object sender, EventArgs e)
        {
            //videoCtrl(pboxVideo3, lblVideo3, pboxVideo3.Name);
        }

        private void panel14_DoubleClick(object sender, EventArgs e)
        {
            //videoCtrl(pboxVideo4, lblVideo4, pboxVideo4.Name);
        }

        private void videoCtrl(PictureBox PlayScreen, Label lblVideo,string screan)
        {
            string mciCommand;
            string alias = "MyAVI";
            if (lblVideo.Tag == null || lblVideo.Tag.ToString() != "正在播放")
            {
                lblVideo.Hide();

                mciCommand = string.Format("open {0}\\video\\video.wmv alias {1} ", Environment.CurrentDirectory, alias);
                mciCommand = mciCommand + " parent " + PlayScreen.Handle.ToInt32() + " style child ";
                LibWrap.mciSendString(mciCommand, null, 0, 0);
                Rectangle r = PlayScreen.ClientRectangle;
                mciCommand = string.Format(" put {0} window at 0 0 {1} {2}", alias, r.Width, r.Height);
                LibWrap.mciSendString(mciCommand, null, 0, 0);
                LibWrap.mciSendString(string.Format(" play {0} repeat", alias), null, 0, 0);

                lblVideo.Tag = "正在播放";
            }
            else
            {
                LibWrap.mciSendString(string.Format("close {0}", alias), null, 0, 0);
                lblVideo.Show();
                lblVideo.Tag = "停止播放";
            }
        }

        private void Sp_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        public void resume()
        {
            string alias = "MyAVI";
            LibWrap.mciSendString(string.Format(" resume {0} ", alias), null, 0, 0);
        }
        public void pause()
        {
            string alias = "MyAVI";
            LibWrap.mciSendString(string.Format(" pause {0} ", alias), null, 0, 0);
        }
        public void setAudioOff()
        {
            string alias = "MyAVI";
            LibWrap.mciSendString(string.Format(" setaudio   {0} off", alias), null, 0, 0);
        }
        public void setAudioOn()
        {
            string alias = "MyAVI";
            LibWrap.mciSendString(string.Format(" setaudio   {0} on ", alias), null, 0, 0);
        }

        private bool mFull = false;
        void panel25_DoubleClick(object sender, EventArgs e)
        {
            if (!mFull)
            {
                this.panel22.Controls.Remove(this.pboxVideo2);
                pictureBox5.BringToFront();
                pictureBox5.Controls.Add(pboxVideo2);
                pictureBox5.Visible = true;
                string mciCommand = string.Format(" put {0} window at 0 0 {1} {2}", "MyAVI", pictureBox5.Width, pictureBox5.Height-60);
                LibWrap.mciSendString(mciCommand, null, 0, 0);
            }
            else
            {
                this.pictureBox5.Controls.Remove(this.pboxVideo2);
                pictureBox5.Visible = false;
                panel22.Controls.Add(pboxVideo2);

                string mciCommand = string.Format(" put {0} window at 0 0 {1} {2}", "MyAVI", pboxVideo2.Width, pboxVideo2.Height);
                LibWrap.mciSendString(mciCommand, null, 0, 0);
            }
            mFull = !mFull;
        }


    }
    public class LibWrap
    {
        [DllImport(("winmm.dll "), EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        public static extern int mciSendString(string lpszCommand, string lpszReturnString,
                    uint cchReturn, int hwndCallback);
    }
}

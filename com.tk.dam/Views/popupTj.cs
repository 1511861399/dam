using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;

namespace com.tk.dam.Views
{
    public partial class popupTj : PopupUserControlBase
    {
        IList<TjItemEnum> mSelectedTjItems = new List<TjItemEnum>();

        public popupTj()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void popupTj_Load(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.tcMain.Focus();
            MainForm.SelectedTjItems = mSelectedTjItems;
            MainForm.HidenFlyout();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.tcMain.Focus();
            MainForm.HidenFlyout();
        }

        private void tileItemSjdy_ItemClick(object sender, TileItemEventArgs e)
        {
            tileItemClick(tileItemSjdy, TjItemEnum.数据打印);
        }

        private void tileItemKqys_ItemClick(object sender, TileItemEventArgs e)
        {
            tileItemClick(tileItemKqys, TjItemEnum.库区雨水);
        }

        private void tileItemZsjs_ItemClick(object sender, TileItemEventArgs e)
        {
            tileItemClick(tileItemZsjs, TjItemEnum.知识介绍);
        }

        private void tileItemNbjc_ItemClick(object sender, TileItemEventArgs e)
        {
            tileItemClick(tileItemNbjc, TjItemEnum.内部监测);
        }

        private void tileItemGcjs_ItemClick(object sender, TileItemEventArgs e)
        {
            tileItemClick(tileItemGcjs, TjItemEnum.工程介绍);
        }

        public void Reload()
        {
            if (MainForm != null)
            {
                mSelectedTjItems = MainForm.SelectedTjItems;
                initTileItem(tileItemSjdy, mSelectedTjItems.Contains(TjItemEnum.数据打印));
                initTileItem(tileItemNbjc, mSelectedTjItems.Contains(TjItemEnum.内部监测));
                initTileItem(tileItemKqys, mSelectedTjItems.Contains(TjItemEnum.库区雨水));
                initTileItem(tileItemGcjs, mSelectedTjItems.Contains(TjItemEnum.工程介绍));
                initTileItem(tileItemZsjs, mSelectedTjItems.Contains(TjItemEnum.知识介绍));
            }
        }

        private void initTileItem(TileItem item, bool selected)
        {
            if (selected)
            {
                item.Elements[1].Text = "已选择";
                item.Checked = true;
            }
            else
            {
                item.Elements[1].Text = "点击选择";
                item.Checked = false; ;
            }
        }

        private void tileItemClick(TileItem item, TjItemEnum itemEnum)
        {
            if (mSelectedTjItems.Contains(itemEnum))
            {
                mSelectedTjItems.Remove(itemEnum);
            }
            else
            {
                mSelectedTjItems.Add(itemEnum);
            }
            initTileItem(item, mSelectedTjItems.Contains(itemEnum));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;

namespace Quizzer
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void LoadControl(XtraUserControl ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            splitContainerControl.Panel2.Controls.Clear();
            splitContainerControl.Panel2.Controls.Add(ctrl);
        }

        private void nbiEntry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucDataEntry uc = new ucDataEntry();
            LoadControl(uc);
            ribbonControl.MergeRibbon(uc.ribbonControl);
            homeRibbonPage.MergeOrder = 1;
            ribbonControl.SelectedPage = ribbonControl.MergedRibbon.SelectedPage;
        }

        private void bStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuiz frm = new frmQuiz();
            frm.ShowDialog();
        }
    }
}
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
            string Round;
            int Team, QType, NoOfQ, Time;
            frmStart frm = new frmStart();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Round = frm.Round;
                Team = frm.Team;
                QType = frm.QuestionType;
                NoOfQ = frm.NoOfQuestion;
                Time = frm.Time;
                frmQuiz form = new frmQuiz(Round, Team, QType, NoOfQ, Time);
                form.ShowDialog();
            }

            

        }

        private void nbiTeams_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucTeams uc = new ucTeams();
            LoadControl(uc);
            ribbonControl.MergeRibbon(uc.ribbonControl1);
            homeRibbonPage.MergeOrder = 1;
            ribbonControl.SelectedPage = ribbonControl.MergedRibbon.SelectedPage;
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace Quizzer
{
    public partial class frmQuiz : XtraForm
    {

        Quiz Q = new Quiz();

        int counter;
        string round;
        int team, qType, noOfQ, time;
        //bool fifty50 = false;


        public frmQuiz()
        {
            InitializeComponent();
        }


        void LoadQuestion()
        {
            Questions q = new Questions();
            q = Q.getQuestion(qType);
            lblQSTN.Text = q.Question;
            bOptA.Text = "A." + q.Option1;
            bOptB.Text = "B." + q.Option2;
            bOptC.Text = "C." + q.Option3;
            bOptD.Text = "D." + q.Option4;
        }
        public frmQuiz(string Round, int Team, int QType, int NoOfQ, int Time)
        {
            InitializeComponent();
            round = Round;
            team = Team;
            qType = QType;
            noOfQ = NoOfQ;
            time = Time;

            lblRound.Text = round;
            
            //LoadQuestion();
        }

        Quiz q = new Quiz();
        private void tmr_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter <= 5 && counter >= 1)
                q.playAudio("sounds/tick.wav");
            if (counter == 0)
            {
                tmr.Stop();
                q.playAudio("sounds/tada.wav");
            }
            digitalGauge1.Text = counter.ToString();
        }

        private void StartTimer()
        {
            counter = time;
            tmr.Start();
            digitalGauge1.Text = counter.ToString();
        }

        private void mBGColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            //XtraMessageBox.Show("BG Color");
        }

        private void mStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadQuestion();
            StartTimer();
        }

        private void mStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void mNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void mPrev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void mOptA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bOptA.Checked = true;
            bOptB.Checked = false;
            bOptC.Checked = false;
            bOptD.Checked = false;
        }

        private void mOptB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bOptA.Checked = false;
            bOptB.Checked = true;
            bOptC.Checked = false;
            bOptD.Checked = false;
        }

        private void mOptC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bOptA.Checked = false;
            bOptB.Checked = false;
            bOptC.Checked = true;
            bOptD.Checked = false;
        }

        private void mOptD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bOptA.Checked = false;
            bOptB.Checked = false;
            bOptC.Checked = false;
            bOptD.Checked = true;
        }

        private void mTrue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void mFalse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void m5050_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn5050_CheckedChanged(object sender, EventArgs e)
        {
            if (btn5050.Checked)
            {

            }
        }

        private void mBgColor_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BackColor = mBgColor.Checked == true ? Color.Green : Color.FromArgb(235, 236, 239);
        }

        private void mFullScreen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void mCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bOptA.Checked)
            {
                bOptA.Image = Properties.Resources.True_16x16;
            }
            else if (bOptB.Checked)
                bOptB.Image = Properties.Resources.True_16x16;
            else if (bOptC.Checked)
                bOptC.Image = Properties.Resources.True_16x16;
            else
                bOptD.Image = Properties.Resources.True_16x16;
        }

        private void bOptA_CheckedChanged(object sender, EventArgs e)
        {
            //bOptA.Checked = bOptA.Checked == true ? false : true;
        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.Green;
        //    //235, 236, 239
        //}

        //private void checkButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    BackColor = checkButton1.Checked == true ? Color.Green : Color.FromArgb(235, 236, 239);
        //}
    }
}
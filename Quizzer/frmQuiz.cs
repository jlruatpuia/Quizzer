using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace Quizzer
{
    public partial class frmQuiz : XtraForm
    {

        int counter;

        public frmQuiz()
        {
            InitializeComponent();
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

        private void btnTimer_Click(object sender, EventArgs e)
        {
            counter = 10;
            tmr.Start();
            digitalGauge1.Text = counter.ToString();
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
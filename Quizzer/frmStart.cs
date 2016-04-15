using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class frmStart : XtraForm
    {
        public string Round { get; set; }
        public int Team { get; set; }
        public int QuestionType { get; set; }
        public int NoOfQuestion { get; set; }
        public int Time { get; set; }

        public frmStart()
        {
            InitializeComponent();

            getData gd = new getData();
            Quiz q = new Quiz();

            gd = q.getTeams("Active");
            lueTeam.Properties.DataSource = gd.DT;
            lueTeam.Properties.DisplayMember = "TeamName";
            lueTeam.Properties.ValueMember = "ID";

            gd = q.getQuestionTypes();
            lueQType.Properties.DataSource = gd.DT;
            lueQType.Properties.DisplayMember = "QuestionType";
            lueQType.Properties.ValueMember = "ID";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Round = cboRound.Text;
            Team = Convert.ToInt32(lueTeam.EditValue);
            QuestionType = Convert.ToInt32(lueQType.EditValue);
            NoOfQuestion = Convert.ToInt32(txtNoQ.Text);
            Time = Convert.ToInt32(txtTime.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
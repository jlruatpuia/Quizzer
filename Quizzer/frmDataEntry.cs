using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quizzer
{
    public partial class frmDataEntry : XtraForm
    {
        public frmDataEntry()
        {
            InitializeComponent();

            getData gd = new getData();
            Quiz q = new Quiz();

            gd = q.getQuestionTypes();
            lueQTP.Properties.DataSource = gd.DT;
            lueQTP.Properties.DisplayMember = "QuestionType";
            lueQTP.Properties.ValueMember = "ID";

            lueQTP_EditValueChanged(null, null);
        }

        private void lueQTP_EditValueChanged(object sender, EventArgs e)
        {
            if(lueQTP.EditValue == null)
            {
                lcgMTPL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                Height = 180;
            }
            else if ((int)lueQTP.EditValue == 3)
            {
                lcgMTPL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                Height = 355;
            }
            else
            {
                lcgMTPL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                Height = 180;
            }
        }

        private void rdoANS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ep = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            if(txtANS1.Text == "")
            {
                ep.SetError(txtANS1, "Please enter answer #1");
                return;
            }
            else if(txtANS2.Text == "")
            {
                ep.SetError(txtANS2, "Please enter answer #2");
                return;
            }
            else if (txtANS2.Text == "")
            {
                ep.SetError(txtANS3, "Please enter answer #3");
                return;
            }
            else if (txtANS2.Text == "")
            {
                ep.SetError(txtANS4, "Please enter answer #4");
                return;
            }
            else
            {
                ep.ClearErrors();
            }
            switch (rdoANS.SelectedIndex)
            {
                case 0:
                    txtANS.Text = txtANS1.Text;
                    break;
                case 1:
                    txtANS.Text = txtANS2.Text;
                    break;
                case 2:
                    txtANS.Text = txtANS3.Text;
                    break;
                case 3:
                    txtANS.Text = txtANS4.Text;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getData gd = new getData();
            Questions q = new Questions();
            Quiz qz = new Quiz();

            q.QuestionType = Convert.ToInt32(lueQTP.EditValue);
            q.Question = txtQSTN.Text;
            q.Option1 = txtANS1.Text;
            q.Option2 = txtANS2.Text;
            q.Option3 = txtANS3.Text;
            q.Option4 = txtANS4.Text;
            q.Answer = txtANS.Text;
            q.MaxTime = Convert.ToInt32(txtSEC.EditValue);
            q.Points = Convert.ToInt32(txtVAL.EditValue);

            gd = qz.addQuestion(q);
            if(gd.Count == 1 || gd.Message == "")
            {
                XtraMessageBox.Show("Question successfully added!");
            }
        }
    }
}
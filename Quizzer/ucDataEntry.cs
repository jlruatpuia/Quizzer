using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quizzer
{
    public partial class ucDataEntry : XtraUserControl
    {
        public ucDataEntry()
        {
            InitializeComponent();

            getData gd = new getData();
            Quiz q = new Quiz();
            gd = q.getQuestions();
            grd.DataSource = gd.DT;
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDataEntry frm = new frmDataEntry();
            frm.ShowDialog();
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int QID = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            frmDataEntry frm = new frmDataEntry(QID);
            frm.ShowDialog();
        }
    }
}

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
    public partial class ucTeams : XtraUserControl
    {
        getData gd = new getData();
        Quiz q = new Quiz();
        public ucTeams()
        {
            InitializeComponent();

            gd = q.getAllTeams();

            grd.DataSource = gd.DT;
        }
    }
}

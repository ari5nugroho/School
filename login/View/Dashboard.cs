using login.Model.Context;
using login.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Controller
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void CountStudent()
        {
            string labelcount = lblstd.Text.ToString();
            var repo = new DashboardRepository(new DbContext());
            string stdcount = repo.GetCountStd(labelcount);
            if (!string.IsNullOrEmpty(stdcount))
            {
                lblstd.Text = stdcount;
            }

        }


        private void CountTeacher()
        {
            string labelcounttcr = lbltcr.Text.ToString();
            var repo = new DashboardRepository(new DbContext());
            string tcrcount = repo.GetCountTcr(labelcounttcr);
            if (!string.IsNullOrEmpty(tcrcount))
            {
                lbltcr.Text = tcrcount;
            }

        }
        private void CountEvent()
        {
            string labelcountevn = lblevn.Text.ToString();
            var repo = new DashboardRepository(new DbContext());
            string evncount = repo.GetCountEvn(labelcountevn);
            if (!string.IsNullOrEmpty(evncount))
            {
                lblevn.Text = evncount;
            }

        }
        private void FeeSum()
        {
            string labelsumfee = lblevn.Text.ToString();
            var repo = new DashboardRepository(new DbContext());
            string sumfee = repo.GetSumFee(labelsumfee);
            if (!string.IsNullOrEmpty(sumfee))
            {
                lblfee.Text = sumfee;
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeacher();
            CountEvent();
            FeeSum();
        }
    }
}

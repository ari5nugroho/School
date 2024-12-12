using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.View
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width += 3;
            if (flowLayoutPanel1.Width >= 599)
            {
                timer1.Stop();
                Login lgn = new Login();
                lgn.Show();
                this.Hide();
            }
        }
    }
}

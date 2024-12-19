using Guna.UI2.WinForms;
using login.Controller;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void moveImageBook(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X +127, b.Location.Y -26 );
            imgSlide.SendToBack();
        }
        private void LoadUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }
        private void guna2Button6_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBook(sender);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();  // Membuat instance dari UserControl Student
            LoadUserControl(student);  // Menampilkan Student di mainPanel
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();  // Membuat instance dari UserControl Dashboard
            LoadUserControl(dashboard);  // Menampilkan Dashboard di mainPanel
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTcrSB_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers();  // Membuat instance dari UserControl Teacher
            LoadUserControl(teacher);  // Menampilkan teacher di mainPanel
        }

        private void btnAttSB_Click(object sender, EventArgs e)
        {
            AttendacesControl att = new AttendacesControl();  // Membuat instance dari UserControl Attedaces
            LoadUserControl(att);  // Menampilkan attedaces di mainPanel
        }

        private void btnEvntSB_Click(object sender, EventArgs e)
        {
            EventsControl evnt = new EventsControl();  // Membuat instance dari UserControl Event
            LoadUserControl(evnt);  // Menampilkan Event di mainPanel
        }

        private void btnFeeSB_Click(object sender, EventArgs e)
        {
            FeesControl fee = new FeesControl();  // Membuat instance dari UserControl Fee
            LoadUserControl(fee);  // Menampilkan Fee di mainPanel
        }
    }
}

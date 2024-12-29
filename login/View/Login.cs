using login.Controller;
using login.View;
using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;


namespace login
{
    public partial class Login : Form
    {
        private string filePath = "config.txt";

        public Login()
        {
            InitializeComponent();
            LoadRememberme();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void LoadRememberme()
        {
            if (File.Exists("rememberme.txt"))
            {
                string savedUsername = File.ReadAllText("rememberme.txt");
                UNametb.Text = savedUsername;
                guna2ToggleSwitch1.Checked = true;
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                    {
                        return true; 
                    }
                }
            }
            return false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = UNametb.Text;
            string password = Passtb.Text;

            if (ValidateLogin(username, password))
            {
                if (guna2ToggleSwitch1.Checked)
                {
                    File.WriteAllText("rememberme.txt", username);
                }
                else
                {
                    if (File.Exists("rememberme.txt")) File.Delete("rememberme.txt");
                }

                MessageBox.Show("Login Berhasil!");
                this.Hide();
                var dashboard = new Form1();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string username = UNametb.Text;
            
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Masukkan username terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).ToList();
                bool userFound = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split(':');
                    if (parts.Length == 2 && parts[0] == username)
                    {
                        userFound = true;

                        // Prompt untuk password baru
                        string newPassword = Prompt.ShowDialog("Masukkan password baru:", "Reset Password");

                        if (!string.IsNullOrEmpty(newPassword))
                        {
                            // Update password di file
                            lines[i] = $"{username}:{newPassword}";
                            File.WriteAllLines(filePath, lines);

                            MessageBox.Show("Password berhasil direset!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Password baru tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }
                }

                if (!userFound)
                {
                    MessageBox.Show("Username tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File config.txt tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

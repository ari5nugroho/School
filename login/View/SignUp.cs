using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace login.View
{
    public partial class SignUp : Form
    {
        private string filePath = "config.txt";
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string newUsername = NewUNametb.Text.Trim();
            string newPassword = NewPasstb.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsUsernameExists(newUsername))
            {
                MessageBox.Show("Username sudah terdaftar. Silakan pilih username lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            File.AppendAllText(filePath, $"{newUsername}:{newPassword}{Environment.NewLine}");
            MessageBox.Show("Akun berhasil dibuat!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var Login = new Login();
            Login.Show();
            this.Close();
        }

        private bool IsUsernameExists(string username)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2 && parts[0] == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Close();
        }
    }
}

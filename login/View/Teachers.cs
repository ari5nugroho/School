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
using login.Model.Entity;
using Guna.UI2.AnimatorNS;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using K4os.Hash.xxHash;
namespace login.View
{
    public delegate void CreateUpdateEventTcrHandler(Teacher tcr);
    public partial class Teachers : UserControl
    {
        private List<Teacher> ListOfTeacher = new List<Teacher>();
        public event CreateUpdateEventTcrHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventTcrHandler OnUpdate;
        // deklarasi event ketika terjadi proses hapus data
        public event CreateUpdateEventTcrHandler OnDelete;
        private TeacherController controller;
        private bool isNewData = true;
        private Teacher tcr;
        public Teachers()
        {
            InitializeComponent();
            controller = new TeacherController();
            InisialisasiGridView();
            LoadDataTeacher();

            this.Resize += Teachers_Resize;
            CenterGridView();

            OnCreate += TeacherCreatedHandler;
            OnUpdate += TeacherUpdateHandler;
            OnDelete += TeacherDeleteHandler;
        }
        private void TeacherCreatedHandler(Teacher tcr)
        {
            MessageBox.Show($"Teacher {tcr.tcName} berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataTeacher(); // Refresh DataGridView
        }
        private void TeacherUpdateHandler(Teacher tcr)
        {
            MessageBox.Show($"Teacher {tcr.tcName} berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataTeacher(); // Refresh DataGridView
        }
        private void TeacherDeleteHandler(Teacher tcr)
        {
            MessageBox.Show($"Teacher {tcr.tcName} berhasil dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataTeacher(); // Refresh DataGridView
        }
        private void InisialisasiGridView()
        {
            GDVTcr.Columns.Clear();

            GDVTcr.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                Width = 55,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVTcr.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 111,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVTcr.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gen",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            GDVTcr.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "DOB",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVTcr.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVTcr.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subject",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            GDVTcr.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Mengatur garis grid
            GDVTcr.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GDVTcr.GridColor = System.Drawing.Color.Black;
        }
        private void LoadDataTeacher()
        {
            // Kosongkan DataGridView
            GDVTcr.Rows.Clear();

            // Panggil method ReadAll untuk mengambil data dari database
            List<Teacher> ListOfTeacher = controller.ReadAll();

            // Iterasi melalui data mahasiswa dan tambahkan ke DataGridView
            foreach (var tcr in ListOfTeacher)
            {
                GDVTcr.Rows.Add(
                    tcr.tcId, // Kolom ID
                    tcr.tcName,                  // Kolom Nama
                    tcr.tcGen,                   // Kolom Gender
                    tcr.tcDOB, // Kolom Tanggal Lahir
                    tcr.tcPhone,                 // Kolom Kelas
                    tcr.tcSubject,     // Kolom Biaya
                    tcr.tcAdrs                   // Kolom Alamat
                );
            }

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
       

        private void Teachers_Resize(object sender, EventArgs e)
        {
            CenterGridView();
        }
        private void CenterGridView()
        {
            // Hitung posisi horizontal untuk menempatkan di tengah
            GDVTcr.Left = (415 - 203) / 2;

        }
        private void btnAddTcr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameTcr.Text) ||
           cmbGenTcr.SelectedIndex == -1 ||
           string.IsNullOrWhiteSpace(txtPhoneTcr.Text) ||
            string.IsNullOrWhiteSpace(txtAdrsTcr.Text) ||
           cmbSubjectTcr.SelectedIndex == -1)
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menambahkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isNewData) tcr = new Teacher();
            tcr.tcName = txtNameTcr.Text;
            tcr.tcGen = cmbGenTcr.SelectedItem.ToString();
            tcr.tcDOB = dtDOBTcr.Text;
            tcr.tcPhone = txtPhoneTcr.Text;
            tcr.tcSubject = cmbSubjectTcr.SelectedItem.ToString();        
            tcr.tcAdrs = txtAdrsTcr.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(tcr);
                if (result > 0)
                {
                    OnCreate?.Invoke(tcr);

                    txtNameTcr.Clear();
                    cmbGenTcr.SelectedIndex = -1;
                    dtDOBTcr.Value = DateTime.Now;
                    txtPhoneTcr.Clear();
                    cmbSubjectTcr.SelectedIndex = -1;
                    txtAdrsTcr.Clear();
                    txtNameTcr.Focus();
                    LoadDataTeacher();
                }
            }
            else
            {


                MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        int Key = 0;
        private void btnEdtTcr_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Silakan pilih data yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input
            if (string.IsNullOrWhiteSpace(txtNameTcr.Text) ||
           cmbGenTcr.SelectedIndex == -1 ||
           string.IsNullOrWhiteSpace(txtPhoneTcr.Text) ||
            string.IsNullOrWhiteSpace(txtAdrsTcr.Text) ||
           cmbSubjectTcr.SelectedIndex == -1)
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menambahkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update data mahasiswa
            tcr = new Teacher
            {
                tcId = GDVTcr.SelectedRows[0].Cells[0].Value.ToString(),
                tcName = txtNameTcr.Text,
                tcGen = cmbGenTcr.SelectedItem.ToString(),
                tcDOB = dtDOBTcr.Text,
                tcPhone = txtPhoneTcr.Text,
                tcSubject = cmbSubjectTcr.SelectedItem.ToString(),
                tcAdrs = txtAdrsTcr.Text
            };

            // Kirim data ke controller untuk diperbarui
            int result = controller.Update(tcr);

            if (result > 0)
            {
                OnUpdate?.Invoke(tcr);
                
                LoadDataTeacher(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelTcr_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Silakan pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi penghapusan
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                tcr = new Teacher
                {
                    tcId = GDVTcr.SelectedRows[0].Cells[0].Value.ToString()
                };

                int result = controller.Delete(tcr);
                if (result > 0)
                {
                    OnDelete?.Invoke(tcr);
                    
                    LoadDataTeacher(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      

        private void GDVTcr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan klik berada di dalam baris data
            {
                DataGridViewRow row = GDVTcr.Rows[e.RowIndex];

                txtNameTcr.Text = row.Cells[1].Value.ToString();
                cmbGenTcr.SelectedItem = row.Cells[2].Value.ToString();
                dtDOBTcr.Text = row.Cells[3].Value.ToString();
                txtPhoneTcr.Text = row.Cells[4].Value.ToString();
                cmbSubjectTcr.SelectedItem = row.Cells[5].Value.ToString();
                txtAdrsTcr.Text = row.Cells[6].Value.ToString();
                Key = Convert.ToInt32(row.Cells[0].Value.ToString()); // Set Key sesuai Tc
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

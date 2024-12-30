using login.Controller;
using login.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace login.View
{
    public delegate void CreateUpdateEventHandler(Student std);
    public partial class Students : UserControl
    {
        private List<Student> ListOfStudent = new List<Student>();
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi event ketika terjadi proses hapus data
        public event CreateUpdateEventHandler OnDelete;
        private StudentController controller;
        private bool isNewData = true;



        private Student std;
        public Students()
        {
            InitializeComponent();
            controller = new StudentController();
            InisialisasiGridView();
            LoadDataStudent();

            // Tambahkan handler untuk event Resize
            this.Resize += Students_Resize;

            // Pastikan posisi awal datagrid berada di tengah
            CenterGridView();

            OnCreate += StudentCreatedHandler;
            OnUpdate += StudentUpdateHandler;
            OnDelete += StudentDeleteHandler;

            GDVStd.CellClick += GDVStd_CellClick;

            GDVStd.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void StudentCreatedHandler(Student std)
        {
            MessageBox.Show($"Student {std.StName} berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataStudent(); // Refresh DataGridView
        }
        private void StudentUpdateHandler(Student std)
        {
            MessageBox.Show($"Student {std.StName} berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataStudent(); // Refresh DataGridView
        }
        private void StudentDeleteHandler(Student std)
        {
            MessageBox.Show($"Student {std.StName} berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataStudent(); // Refresh DataGridView
        }
        private void InisialisasiGridView()
        {
            GDVStd.Columns.Clear();

            GDVStd.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "StId",
                Width = 55,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVStd.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 111,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVStd.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gen",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            GDVStd.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "DOB",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVStd.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Class",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVStd.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fee",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            GDVStd.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Mengatur garis grid
            GDVStd.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GDVStd.GridColor = System.Drawing.Color.Black;
        }
        private void LoadDataStudent()
        {
            // Kosongkan DataGridView
            GDVStd.Rows.Clear();

            // Panggil method ReadAll untuk mengambil data dari database
            List<Student> ListOfStudent = controller.ReadAll();

            // Iterasi melalui data mahasiswa dan tambahkan ke DataGridView
            foreach (var std in ListOfStudent)
            {
                GDVStd.Rows.Add(
                    std.StId, // Kolom ID
                    std.StName,                  // Kolom Nama
                    std.StGen,                   // Kolom Gender
                    std.StDOB, // Kolom Tanggal Lahir
                    std.StClass,                 // Kolom Kelas
                    std.StFee,     // Kolom Biaya
                    std.StAdrs                   // Kolom Alamat
                );
            }

        }




        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            
            // Perbaikan
            if (string.IsNullOrWhiteSpace(txtNameStd.Text) ||
            cmbGenStd.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(txtFeeStd.Text) ||
             string.IsNullOrWhiteSpace(txtAdrsStd.Text) ||
            cmbClsStd.SelectedIndex == -1)
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menambahkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isNewData) std = new Student();
            std.StName = txtNameStd.Text;
            std.StGen = cmbGenStd.SelectedItem.ToString();
            std.StDOB = dtDOBStd.Text;
            std.StClass = cmbClsStd.SelectedItem.ToString();
            std.StFee = txtFeeStd.Text;
            std.StAdrs = txtAdrsStd.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(std);
                if (result > 0)
                {
                    OnCreate?.Invoke(std);

                    txtNameStd.Clear();
                    cmbGenStd.SelectedIndex = -1;
                    dtDOBStd.Value = DateTime.Now;
                    cmbClsStd.SelectedIndex = -1;
                    txtFeeStd.Clear();
                    txtAdrsStd.Clear();

                    txtNameStd.Focus();
                }
            }
            else
            {
               
                    
                        MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                
            }
        }

      

        private void btnEdtStd_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Silakan pilih data yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input
            if (string.IsNullOrWhiteSpace(txtNameStd.Text) ||
                cmbGenStd.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtFeeStd.Text) ||
                string.IsNullOrWhiteSpace(txtAdrsStd.Text) ||
                cmbClsStd.SelectedIndex == -1)
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menyimpan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update data mahasiswa
            std = new Student
            {
                StId = GDVStd.SelectedRows[0].Cells[0].Value.ToString(),
                StName = txtNameStd.Text,
                StGen = cmbGenStd.SelectedItem.ToString(),
                StDOB = dtDOBStd.Text,
                StClass = cmbClsStd.SelectedItem.ToString(),
                StFee = txtFeeStd.Text,
                StAdrs = txtAdrsStd.Text
            };

            // Kirim data ke controller untuk diperbarui
            int result = controller.Update(std);

            if (result > 0)
            {
                OnUpdate?.Invoke(std);
                
                LoadDataStudent(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnDelStd_Click(object sender, EventArgs e)
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
                std = new Student
                {
                    StId = GDVStd.SelectedRows[0].Cells[0].Value.ToString()
                };

                int result = controller.Delete(std);
                if (result > 0)
                {
                    OnDelete?.Invoke(std);
                    
                    LoadDataStudent(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            /*if (Key == 0)
            {
                MessageBox.Show("Pilih Murid");
            }

            if (isNewData) std = new Student();
            std.StName = txtNameStd.Text;
            std.StGen = cmbGenStd.SelectedItem.ToString();
            std.StDOB = dtDOBStd.Text;
            std.StClass = cmbClsStd.SelectedItem.ToString();
            std.StFee = txtFeeStd.Text;
            std.StAdrs = txtAdrsStd.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Delete(std);
                if (result > 0)
                {
                    if (OnDelete != null)
                    {
                        OnDelete(std);
                    }
                    else
                    {
                        MessageBox.Show("Event OnCreate belum diatur!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtNameStd.Clear();
                    cmbGenStd.SelectedIndex = -1;
                    dtDOBStd.Value = DateTime.Now;
                    cmbClsStd.SelectedIndex = -1;
                    txtFeeStd.Clear();
                    txtAdrsStd.Clear();

                    txtNameStd.Focus();
                }
            }
            else
            {
               
                        MessageBox.Show("Event OnUpdate belum diatur!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
            /*else
            {
                MessageBox.Show("Silakan pilih siswa yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */


        }
        int Key = 0;
       

        private void Students_Resize(object sender, EventArgs e)
        {
            CenterGridView();
        }
        private void CenterGridView()
        {
            // Hitung posisi horizontal untuk menempatkan di tengah
            GDVStd.Left = (415 - 203) / 2;

        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GDVStd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            /*txtNameStd.Text = GDVStd.SelectedRows[0].Cells[1].Value.ToString();
            cmbGenStd.SelectedItem = GDVStd.SelectedRows[0].Cells[2].Value.ToString();
            dtDOBStd.Text = GDVStd.SelectedRows[0].Cells[3].Value.ToString();
            cmbClsStd.SelectedItem = GDVStd.SelectedRows[0].Cells[4].Value.ToString();
            txtFeeStd.Text = GDVStd.SelectedRows[0].Cells[5].Value.ToString();
            txtAdrsStd.Text = GDVStd.SelectedRows[0].Cells[6].Value.ToString();
            if (txtNameStd.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(GDVStd.SelectedRows[0].Cells[0].Value.ToString());
            }*/

            // Pastikan klik berada di dalam baris data, bukan header
            if (e.RowIndex >= 0 && e.RowIndex < GDVStd.Rows.Count)
            {
                try
                {
                    // Ambil baris yang diklik
                    DataGridViewRow row = GDVStd.Rows[e.RowIndex];

                    // Validasi data pada setiap kolom sebelum digunakan
                    if (row.Cells[0].Value != null)
                        Key = Convert.ToInt32(row.Cells[0].Value.ToString()); // Set Key sesuai StId

                    if (row.Cells[1].Value != null)
                        txtNameStd.Text = row.Cells[1].Value.ToString();

                    if (row.Cells[2].Value != null)
                        cmbGenStd.SelectedItem = row.Cells[2].Value.ToString();

                    if (row.Cells[3].Value != null)
                        dtDOBStd.Text = row.Cells[3].Value.ToString();

                    if (row.Cells[4].Value != null)
                        cmbClsStd.SelectedItem = row.Cells[4].Value.ToString();

                    if (row.Cells[5].Value != null)
                        txtFeeStd.Text = row.Cells[5].Value.ToString();

                    if (row.Cells[6].Value != null)
                        txtAdrsStd.Text = row.Cells[6].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat memilih data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetForm()
        {
            txtNameStd.Clear();
            cmbGenStd.SelectedIndex = -1;
            dtDOBStd.Value = DateTime.Now;
            cmbClsStd.SelectedIndex = -1;
            txtFeeStd.Clear();
            txtAdrsStd.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

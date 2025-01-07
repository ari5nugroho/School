using login.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Controller;
using login.Model.Repository;
using System.Data.SqlClient;
using Guna.UI2.AnimatorNS;
using login.Model.Context;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace login.View
{
    public delegate void CreateUpdateEventAttHandler(Attendance att);
    public partial class Attendaces : UserControl
    {
        private List<Attendance> ListOfAttendance = new List<Attendance>();
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventAttHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventAttHandler OnUpdate;
        // deklarasi event ketika terjadi proses hapus data
        public event CreateUpdateEventAttHandler OnDelete;
        private AttendanceController controller;
        private bool isNewData = true;
        private Attendance att;
        public Attendaces()
        {
            InitializeComponent();
            controller = new AttendanceController();
            InisialisasiGridView();

            LoadDataAttendance();
            FillStId();
            this.Resize += Attendances_Resize;

            CenterGridView();

            OnCreate += AttendanceCreatedHandler;
            OnUpdate += AttendanceUpdateHandler;
            OnDelete += AttendanceDeleteHandler;
            GDVAtt.CellClick += GDVAtt_CellClick;

            GDVAtt.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void AttendanceCreatedHandler(Attendance att)
        {
            MessageBox.Show($"Student {att.AttStName} berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataAttendance(); // Refresh DataGridView
        }
        private void AttendanceUpdateHandler(Attendance att)
        {
            MessageBox.Show($"Student {att.AttStName} berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataAttendance(); // Refresh DataGridView
        }
        private void AttendanceDeleteHandler(Attendance att)
        {
            MessageBox.Show($"Student {att.AttStName} berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataAttendance(); // Refresh DataGridView
        }
        private void InisialisasiGridView()
        {
            GDVAtt.Columns.Clear();


            GDVAtt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "StId",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVAtt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVAtt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            GDVAtt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Mengatur garis grid
            GDVAtt.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GDVAtt.GridColor = System.Drawing.Color.Black;
        }


        private void LoadDataAttendance()
        {
            // Kosongkan DataGridView
            GDVAtt.Rows.Clear();

            // Panggil method ReadAll untuk mengambil data dari database
            ListOfAttendance = controller.ReadAll();


            // Iterasi melalui data mahasiswa dan tambahkan ke DataGridView
            foreach (var att in ListOfAttendance)
            {
                GDVAtt.Rows.Add(
                    att.StId,
                    att.AttStName,            
                    att.AttStDOB,
                    att.AttStStatus
                );
            }

        }

        private void Attendances_Resize(object sender, EventArgs e)
        {
            CenterGridView();
        }
        private void CenterGridView()
        {
            // Hitung posisi horizontal untuk menempatkan di tengah
            GDVAtt.Left = (470 - 203) / 2;

        }
        private void AttendacesControl_Load(object sender, EventArgs e)
        {

        }
        private void FillStId()
        {
            try
            {
                // Panggil repository untuk mengambil semua student ID
                var repo = new AttendanceRepository(new DbContext());
                DataTable dt = repo.GetStId();

                // Atur data sumber ComboBox
                cmbStIdAtt.DataSource = dt;
                cmbStIdAtt.DisplayMember = "StName"; // Kolom yang akan ditampilkan di ComboBox
                cmbStIdAtt.ValueMember = "StName";   // Nilai yang akan diambil (ID)
                cmbStIdAtt.SelectedIndex = -1;     // Default kosong
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat Nama siswa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddAtt_Click(object sender, EventArgs e)
        {
            att = new Attendance
            {
                AttStName = cmbStIdAtt.SelectedValue.ToString(),
                StId = txtNameAtt.Text,
                AttStDOB = dtAtt.Text, // Format sesuai database
                AttStStatus = cmbStatusAtt.SelectedItem.ToString()
            };

            try
            {
                int result = controller.Create(att);
                if (result > 0)
                {
                    OnCreate?.Invoke(att);
                    ResetInput();
                    LoadDataAttendance();
                    GDVAtt.ClearSelection();
                    GDVAtt.Refresh();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdtAtt_Click(object sender, EventArgs e)
        {
            if (GDVAtt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = GDVAtt.SelectedRows[0].Index;
            att = ListOfAttendance[rowIndex];

            att.AttStName = cmbStIdAtt.SelectedValue.ToString();
            att.StId = txtNameAtt.Text.Trim();
            att.AttStDOB = dtAtt.Text;
            att.AttStStatus = cmbStatusAtt.SelectedItem.ToString();

            try
            {
                int result = controller.Update(att);
                if (result > 0)
                {
                    OnUpdate?.Invoke(att);
                    ResetInput();
                    LoadDataAttendance();
                    GDVAtt.ClearSelection();
                    GDVAtt.Refresh();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelAtt_Click(object sender, EventArgs e)
        {
            if (GDVAtt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = GDVAtt.SelectedRows[0].Index;
            att = ListOfAttendance[rowIndex];

            DialogResult confirmation = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    int result = controller.Delete(att);
                    if (result > 0)
                    {
                        OnDelete?.Invoke(att);

                        LoadDataAttendance();
                        GDVAtt.ClearSelection();
                        GDVAtt.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetInput()
        {
            cmbStIdAtt.SelectedIndex = -1;
            txtNameAtt.Clear();
            dtAtt.Value = DateTime.Now;
            cmbStatusAtt.SelectedIndex = -1;
            isNewData = true;
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbStIdAtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStIdAtt.SelectedValue != null)
            {
                string selectedStId = cmbStIdAtt.SelectedValue.ToString();
                var repo = new AttendanceRepository(new DbContext());
                string studentName = repo.GetStName(selectedStId);

                if (!string.IsNullOrEmpty(studentName))
                {
                    txtNameAtt.Text = studentName;
                }
                else
                {
                    txtNameAtt.Clear();
                }
            }

        }

        private void GDVAtt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan klik berada di dalam baris data, bukan header
            if (e.RowIndex >= 0 && e.RowIndex < GDVAtt.Rows.Count)
            {
                try
                {
                    // Ambil baris yang diklik
                    DataGridViewRow row = GDVAtt.Rows[e.RowIndex];

                    // Validasi data pada setiap kolom sebelum digunakan
                    if (row.Cells[0].Value != null)
                        txtNameAtt.Text = row.Cells[0].Value.ToString();

                    if (row.Cells[1].Value != null)
                        cmbStIdAtt.SelectedValue = row.Cells[1].Value.ToString();

                    if (row.Cells[2].Value != null)
                        dtAtt.Text = row.Cells[2].Value.ToString();

                    if (row.Cells[3].Value != null)
                        cmbStatusAtt.SelectedItem = row.Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat memilih data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        private void txtNameAtt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GDVAtt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

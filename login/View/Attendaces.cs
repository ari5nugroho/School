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
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVAtt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVAtt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Day",
                Width = 70,
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
            List<Attendance> ListOfAttendance = controller.ReadAll();

            // Iterasi melalui data mahasiswa dan tambahkan ke DataGridView
            foreach (var att in ListOfAttendance)
            {
                GDVAtt.Rows.Add(
                    att.AttStId,
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
            GDVAtt.Left = (415 - 203) / 2;

        }
        private void AttendacesControl_Load(object sender, EventArgs e)
        {

        }
        private void FillStId()
        {
            
        }
        private void btnAddAtt_Click(object sender, EventArgs e)
        {
            if (isNewData) att = new Attendance();
            att.AttStId = cmbStIdAtt.Text;
            att.AttStName = txtNameAtt.Text;
            att.AttStDOB = dtAtt.Text;
            att.AttStStatus = cmbStatusAtt.SelectedItem.ToString();

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(att);
                if (result > 0)
                {
                    OnCreate(att);

                    cmbStIdAtt.SelectedIndex = -1;
                    txtNameAtt.Clear();
                    dtAtt.Value = DateTime.Now;
                    cmbStatusAtt.SelectedIndex = -1;


                    cmbStIdAtt.Focus();
                }

            }
            else
            {
                result = controller.Update(att);
                if (result > 0)
                {
                    OnUpdate(att);
                    //this.Close();
                }
            }
        }

        private void btnEdtAtt_Click(object sender, EventArgs e)
        {
            if (GDVAtt.SelectedRows.Count > 0)
            {
                int rowIndex = GDVAtt.SelectedRows[0].Index;
                Attendance att = ListOfAttendance[rowIndex]; // studentList adalah koleksi data mahasiswa
                att.AttStId = cmbStIdAtt.SelectedItem.ToString();
                att.AttStName = txtNameAtt.Text;
                att.AttStDOB = dtAtt.Text;
                att.AttStStatus = cmbStatusAtt.SelectedItem.ToString();

                // Update data student dengan data dari input

                // Panggil fungsi update di controller
                int result = controller.Update(att);
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    GDVAtt.Refresh();

                    // Kosongkan input setelah berhasil

                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Pilih data yang akan diperbarui", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelAtt_Click(object sender, EventArgs e)
        {
            if (GDVAtt.SelectedRows.Count > 0)
            {
                // Ambil data yang dipilih dari DataGridView
                int rowIndex = GDVAtt.SelectedRows[0].Index;
                Attendance att = ListOfAttendance[rowIndex]; // studentList adalah koleksi data mahasiswa

                // Konfirmasi penghapusan
                DialogResult confirmation = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus data ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    // Hapus data melalui controller
                    int result = controller.Delete(att);

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Hapus data dari koleksi
                        ListOfAttendance.RemoveAt(rowIndex);

                        // Refresh DataGridView
                        GDVAtt.DataSource = null;
                        GDVAtt.DataSource = ListOfAttendance;
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
        private AttendanceController attcontroller;
        private bool isNewData = true;
        private Attendance att;
        public Attendaces()
        {
            InitializeComponent();
            attcontroller = new AttendanceController();
        }

        private void AttendacesControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAtt_Click(object sender, EventArgs e)
        {
            if (isNewData) att = new Attendance();
            att.AttStId = txtStIdAtt.Text;
            att.AttStName = txtNameAtt.Text;
            att.AttStDOB = dtAtt.Text;
            att.AttStStatus = cmbStatusAtt.SelectedItem.ToString();

            int result = 0;

            if (isNewData)
            {
                result = attcontroller.Create(att);
                if (result > 0)
                {
                    OnCreate(att);

                    txtStIdAtt.Clear();
                    txtNameAtt.Clear();
                    dtAtt.Value = DateTime.Now;
                    cmbStatusAtt.SelectedIndex = -1;


                    txtStIdAtt.Focus();
                }

            }
            else
            {
                result = attcontroller.Update(att);
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
                att.AttStId = txtStIdAtt.Text;
                att.AttStName = txtNameAtt.Text;
                att.AttStDOB = dtAtt.Text;
                att.AttStStatus = cmbStatusAtt.SelectedItem.ToString();

                // Update data student dengan data dari input

                // Panggil fungsi update di controller
                int result = attcontroller.Update(att);
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
                    int result = attcontroller.Delete(att);

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
    }
}

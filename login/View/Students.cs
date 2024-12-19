using login.Controller;
using login.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
       
        private Student std;
        public Students()
        {
            InitializeComponent();
            GDVStd.SelectionChanged += GDVStd_SelectionChanged; // Menghubungkan eve
            LoadStudents();
        }
        private void LoadStudents()
        {
            StudentController studentController = new StudentController();
            var students = studentController.ReadAll();
            GDVStd.DataSource = students;
        }
        private void GDVStd_SelectionChanged(object sender, EventArgs e)
        {
            if (GDVStd.SelectedRows.Count > 0)
            {
                var selectedRow = GDVStd.SelectedRows[0];
                txtNameStd.Text = selectedRow.Cells["StName"].Value.ToString();
                cmbGenStd.Text = selectedRow.Cells["StGen"].Value.ToString();
                dtDOBStd.Text = selectedRow.Cells["StDOB"].Value.ToString();
                cmbClsStd.Text = selectedRow.Cells["StClass"].Value.ToString();
                txtFeeStd.Text = selectedRow.Cells["StFee"].Value.ToString();
                txtAdrsStd.Text = selectedRow.Cells["StAdrs"].Value.ToString();
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
            Student std = new Student
            {
                StName = txtNameStd.Text,
                StGen = cmbGenStd.Text,
                StDOB = dtDOBStd.Text,
                StClass = cmbClsStd.Text,
                StFee = txtFeeStd.Text,
                StAdrs = txtAdrsStd.Text
            };

            StudentController studentController = new StudentController();
            studentController.Create(std);
            LoadStudents(); // Refresh DataGridView
        }

        private void btnEdtStd_Click(object sender, EventArgs e)
        {
            if (GDVStd.SelectedRows.Count > 0)
            {
                var selectedRow = GDVStd.SelectedRows[0];
                Student std = new Student
                {
                    StName = selectedRow.Cells["StName"].Value.ToString(),
                    StGen = selectedRow.Cells["StGen"].Value.ToString(),
                    StDOB = selectedRow.Cells["StDOB"].Value.ToString(),
                    StClass = selectedRow.Cells["StClass"].Value.ToString(),
                    StFee = selectedRow.Cells["StFee"].Value.ToString(),
                    StAdrs = selectedRow.Cells["StAdrs"].Value.ToString()
                };

                // Update data dari textbox
                std.StName = txtNameStd.Text;
                std.StGen = cmbGenStd.Text;
                std.StDOB = dtDOBStd.Text;
                std.StClass = cmbClsStd.Text;
                std.StFee = txtFeeStd.Text;
                std.StAdrs = txtAdrsStd.Text;

                StudentController studentController = new StudentController();
                studentController.Update(std);
                LoadStudents(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Silakan pilih siswa yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelStd_Click(object sender, EventArgs e)
        {
            if (GDVStd.SelectedRows.Count > 0)
            {
                var selectedRow = GDVStd.SelectedRows[0];
                Student std = new Student
                {
                    StName = selectedRow.Cells["StName"].Value.ToString()
                    // Anda mungkin ingin menambahkan ID atau parameter lain jika diperlukan
                };

                StudentController studentController = new StudentController();
                studentController.Delete(std);
                LoadStudents(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Silakan pilih siswa yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void GDVStd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

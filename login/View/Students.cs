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
        }

        private void StudentCreatedHandler(Student std)
        {
            MessageBox.Show($"Student {std.StName} berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataStudent(); // Refresh DataGridView
        }
        private void StudentUpdateHandler(Student std)
        {
            MessageBox.Show($"Student {std.StId} berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataStudent(); // Refresh DataGridView
        }
        private void StudentDeleteHandler(Student std)
        {
            MessageBox.Show($"Student {std.StId} berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            /*
            // Validasi input kosong
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
                    OnCreate(std);

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
                result = controller.Update(std);
                if (result > 0)
                {
                    OnUpdate(std);
                    this.Close();
                }
            }*/
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
                    if (OnCreate != null)
                    {
                        OnCreate(std);
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
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void btnEdtStd_Click(object sender, EventArgs e)
        {


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
                result = controller.Update(std);
                if (result > 0)
                {
                    if (OnUpdate != null)
                    {
                        OnUpdate(std);
                    }
                    else
                    {
                        MessageBox.Show("Event OnUpdate belum diatur!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    std.StName = txtNameStd.Text;
                    std.StGen = cmbGenStd.SelectedIndex.ToString();
                    std.StDOB = dtDOBStd.Value.ToString("yyyy-MM-dd");
                    std.StClass = cmbClsStd.SelectedIndex.ToString();
                    std.StFee = txtFeeStd.Text;
                    std.StAdrs = txtAdrsStd.Text;
                }
            }
            else
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
                        MessageBox.Show("Event OnUpdate belum diatur!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelStd_Click(object sender, EventArgs e)
        {
            if (Key == 0)
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
            }*/

        }
        int Key = 0;
        private void GDVStd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

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

        private void GDVStd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtNameStd.Text = GDVStd.SelectedRows[0].Cells[1].Value.ToString();
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
            }
        }
    }
}

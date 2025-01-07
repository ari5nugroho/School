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
using Mysqlx.Crud;
using System.IO;

namespace login.View
{
    public delegate void CreateUpdateEventFeeHandler(Fees fees);
    public partial class FeesControl : UserControl
    {
        private List<Fees> ListOfFees = new List<Fees>();
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventFeeHandler OnCreate;

        private FeesController controller;
        private bool isNewData = true;
        private Fees fees;
        public FeesControl()
        {
            InitializeComponent();
            controller = new FeesController();
            InisialisasiGridView();

            LoadDataFees();
            FillStId();
            this.Resize += Fees_Resize;

            CenterGridView();

            OnCreate += FeesCreatedHandler;

            GDVFee.CellClick += GDVFee_CellClick;
            GDVFee.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void FeesCreatedHandler(Fees fees)
        {
            MessageBox.Show($"Student {fees.StNameFees} berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataFees(); // Refresh DataGridView
        }
        private void InisialisasiGridView()
        {
            GDVFee.Columns.Clear();


            GDVFee.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = " StId",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVFee.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = " Name",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVFee.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = " Periode",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            GDVFee.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = " Amount",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Mengatur garis grid
            GDVFee.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GDVFee.GridColor = System.Drawing.Color.Black;
        }

        private void LoadDataFees()
        {
            // Kosongkan DataGridView
            GDVFee.Rows.Clear();

            // Panggil method ReadAll untuk mengambil data dari database
            ListOfFees = controller.ReadAll();


            // Iterasi melalui data mahasiswa dan tambahkan ke DataGridView
            foreach (var fees in ListOfFees)
            {
                GDVFee.Rows.Add(
                    fees.StId,
                    fees.StNameFees,
                    fees.StPrdFees,
                    fees.StAmountFees
                );
            }
        }
        private void Fees_Resize(object sender, EventArgs e)
        {
            CenterGridView();
        }
        private void CenterGridView()
        {
            // Hitung posisi horizontal untuk menempatkan di tengah
            GDVFee.Left = (470 - 203) / 2;

        }
        private void FillStId()
        {
            try
            {
                // Panggil repository untuk mengambil semua student ID
                var repo = new FeesRepository(new DbContext());
                DataTable dt = repo.GetStIdfee();

                // Atur data sumber ComboBox
                cmbStIdFee.DataSource = dt;
                cmbStIdFee.DisplayMember = "StName"; // Kolom yang akan ditampilkan di ComboBox
                cmbStIdFee.ValueMember = "StName";   // Nilai yang akan diambil (ID)
                cmbStIdFee.SelectedIndex = -1;     // Default kosong
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat Nama siswa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddFee_Click(object sender, EventArgs e)
        {
            fees = new Fees
            {
                StNameFees = cmbStIdFee.SelectedValue.ToString(),
                StId = txtNameFee.Text,
                StPrdFees = dtFee.Text, // Format sesuai database
                StAmountFees = txtAmountFee.Text
            };

            try
            {
                int result = controller.Create(fees);
                if (result > 0)
                {
                    var repo = new FeesRepository(new DbContext());
                    repo.UpdateStudentFeeToZero(fees.StId);

                    OnCreate?.Invoke(fees);
                    ResetInput();
                    LoadDataFees();
                    GDVFee.ClearSelection();
                    GDVFee.Refresh();
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
        private void ResetInput()
        {
            cmbStIdFee.SelectedIndex = -1;
            txtNameFee.Clear();
            dtFee.Value = DateTime.Now;
            txtAmountFee.Clear();
            isNewData = true;
        }
        private void cmbStIdFee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        private void cmbStIdFee_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbStIdFee.SelectedValue != null)
            {
                string selectedStId = cmbStIdFee.SelectedValue.ToString();
                var repo = new FeesRepository(new DbContext());
                string studentNamefee = repo.GetStNamefee(selectedStId);

                if (!string.IsNullOrEmpty(studentNamefee))
                {
                    txtNameFee.Text = studentNamefee;
                }
                else
                {
                    txtNameFee.Clear();
                }
            }
            if (cmbStIdFee.SelectedValue != null)
            {
                string selectedstIdFee = cmbStIdFee.SelectedValue.ToString();
                var repo = new FeesRepository(new DbContext());
                string FeesAmountstd = repo.GetAmountFees(selectedstIdFee);

                if (!string.IsNullOrEmpty(FeesAmountstd))
                {
                    txtAmountFee.Text = FeesAmountstd;
                }
                else
                {
                    txtAmountFee.Clear();
                }
            }
        }

        private void GDVFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan klik berada di dalam baris data, bukan header
            if (e.RowIndex >= 0 && e.RowIndex < GDVFee.Rows.Count)
            {
                try
                {
                    // Ambil baris yang diklik
                    DataGridViewRow row = GDVFee.Rows[e.RowIndex];

                    // Validasi data pada setiap kolom sebelum digunakan
                    if (row.Cells[0].Value != null)
                        txtNameFee.Text = row.Cells[0].Value.ToString();
                    if (row.Cells[1].Value != null)
                        cmbStIdFee.SelectedValue = row.Cells[1].Value.ToString();


                    if (row.Cells[2].Value != null)
                        dtFee.Text = row.Cells[2].Value.ToString();

                    if (row.Cells[3].Value != null)
                        txtAmountFee.Text = row.Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat memilih data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            try
            {
                // Lokasi penyimpanan file HTML
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Fees.html");

                // Template HTML
                StringBuilder htmlContent = new StringBuilder();
                htmlContent.AppendLine("<!DOCTYPE html>");
                htmlContent.AppendLine("<html lang='en'>");
                htmlContent.AppendLine("<head>");
                htmlContent.AppendLine("<meta charset='UTF-8'>");
                htmlContent.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1.0'>");
                htmlContent.AppendLine("<title>Data Fees</title>");
                htmlContent.AppendLine("<style>");
                htmlContent.AppendLine("table { width: 100%; border-collapse: collapse; margin: 20px 0; }");
                htmlContent.AppendLine("th, td { border: 1px solid #ddd; padding: 8px; text-align: center; }");
                htmlContent.AppendLine("th { background-color: #c0c0c0;}"); 
                htmlContent.AppendLine("</style>");
                htmlContent.AppendLine("</head>");
                htmlContent.AppendLine("<body>");
                htmlContent.AppendLine("<h1>Student Payment</h1>");
                htmlContent.AppendLine("<table>");
                htmlContent.AppendLine("<thead>");
                htmlContent.AppendLine("<tr>");
                htmlContent.AppendLine("<th>StId</th>");
                htmlContent.AppendLine("<th>Name</th>");
                htmlContent.AppendLine("<th>Periode</th>");
                htmlContent.AppendLine("<th>Amount</th>");
                htmlContent.AppendLine("</tr>");
                htmlContent.AppendLine("</thead>");
                htmlContent.AppendLine("<tbody>");

                // Iterasi data dari GDVFee
                for (int i = 0; i < GDVFee.Rows.Count; i++)
                {
                    if (GDVFee.Rows[i].Cells[0].Value != null) // Validasi data
                    {
                        htmlContent.AppendLine("<tr>");
                        htmlContent.AppendLine($"<td>{GDVFee.Rows[i].Cells[0].Value}</td>"); // StId
                        htmlContent.AppendLine($"<td>{GDVFee.Rows[i].Cells[1].Value}</td>"); // Name
                        htmlContent.AppendLine($"<td>{GDVFee.Rows[i].Cells[2].Value}</td>"); // Periode
                        htmlContent.AppendLine($"<td>{GDVFee.Rows[i].Cells[3].Value}</td>"); // Amount
                        htmlContent.AppendLine("</tr>");
                    }
                }

                htmlContent.AppendLine("</tbody>");
                htmlContent.AppendLine("</table>");
                htmlContent.AppendLine("</body>");
                htmlContent.AppendLine("</html>");

                // Tulis file HTML ke disk
                File.WriteAllText(filePath, htmlContent.ToString());

                // Buka file HTML di browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

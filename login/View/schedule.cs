using System;
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
using System.IO;

namespace login.View
{
    public delegate void CreateUpdateEventSchHandler(Schedule sch);
    public partial class schedule : UserControl
    {
        private List<Schedule> ListOfSchedule = new List<Schedule>();
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventSchHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventSchHandler OnUpdate;
        // deklarasi event ketika terjadi proses hapus data
        public event CreateUpdateEventSchHandler OnDelete;
        private ScheduleController controller;
        private bool isNewData = true;
        private Schedule sch;
        public schedule()
        {
            InitializeComponent();

            controller = new ScheduleController();
            InisialisasiGridView();

            LoadDataSchedule();
            FilltcId();
            this.Resize += Schedule_Resize;

            CenterGridView();

            OnCreate += ScheduleCreatedHandler;
            OnUpdate += ScheduleUpdateHandler;
            OnDelete += ScheduleDeleteHandler;
            GDVSch.CellClick += GDVSch_CellClick;

            GDVSch.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ScheduleCreatedHandler(Schedule sch)
        {
            MessageBox.Show($"Schedule {sch.SchSubjects} berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataSchedule(); // Refresh DataGridView
        }
        private void ScheduleUpdateHandler(Schedule sch)
        {
            MessageBox.Show($"Schedule {sch.SchSubjects} berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataSchedule(); // Refresh DataGridView
        }
        private void ScheduleDeleteHandler(Schedule sch)
        {
            MessageBox.Show($"Schedule {sch.SchSubjects} berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataSchedule(); // Refresh DataGridView
        }
        private void InisialisasiGridView()
        {
            GDVSch.Columns.Clear();


            GDVSch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVSch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Techer Name",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVSch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subject",
                Width = 160,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            GDVSch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Day",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            GDVSch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Time",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            GDVSch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Class",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Mengatur garis grid
            GDVSch.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GDVSch.GridColor = System.Drawing.Color.Black;
        }
        private void schedule_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataSchedule()
        {
            // Kosongkan DataGridView
            GDVSch.Rows.Clear();

            // Panggil method ReadAll untuk mengambil data dari database
            ListOfSchedule = controller.ReadAll();


            // Iterasi melalui data mahasiswa dan tambahkan ke DataGridView
            foreach (var sch in ListOfSchedule)
            {
                GDVSch.Rows.Add(
                    sch.tcId,
                    sch.SchName,
                    sch.SchSubjects,
                    sch.SchDay,
                    sch.SchTime,
                    sch.SchClass
                );
            }

        }
        private void Schedule_Resize(object sender, EventArgs e)
        {
            CenterGridView();
        }
        private void CenterGridView()
        {
            // Hitung posisi horizontal untuk menempatkan di tengah
            GDVSch.Left = (320 - 203) / 2;

        }
        private void FilltcId()
        {
            try
            {
                // Panggil repository untuk mengambil semua student ID
                var repo = new ScheduleRepository(new DbContext());
                DataTable dt = repo.GettcIdsch();

                // Atur data sumber ComboBox
                cmbSchTcr.DataSource = dt;
                cmbSchTcr.DisplayMember = "StcId"; // Kolom yang akan ditampilkan di ComboBox
                cmbSchTcr.ValueMember = "tcId";   // Nilai yang akan diambil (ID)
                cmbSchTcr.SelectedIndex = -1;     // Default kosong
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat ID siswa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSch_Click(object sender, EventArgs e)
        {
            sch = new Schedule
            {
                tcId = cmbSchTcr.SelectedValue.ToString(),
                SchName = txtSchName.Text,
                SchSubjects = txtSchSub.Text, 
                SchDay = cmbSchDay.SelectedItem.ToString(),
                SchTime = cmbSchTime.SelectedItem.ToString(),
                SchClass = cmbSchCls.SelectedItem.ToString()
            };

            try
            {
                int result = controller.Create(sch);
                if (result > 0)
                {
                    OnCreate?.Invoke(sch);
                    ResetInput();
                    LoadDataSchedule();
                    GDVSch.ClearSelection();
                    GDVSch.Refresh();
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

        private void btnEdtSch_Click(object sender, EventArgs e)
        {
            if (GDVSch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = GDVSch.SelectedRows[0].Index;
            sch = ListOfSchedule[rowIndex];

            sch.tcId = cmbSchTcr.SelectedValue.ToString();
            sch.SchName = txtSchName.Text.Trim();
            sch.SchSubjects = txtSchSub.Text.Trim();
            sch.SchDay = cmbSchDay.SelectedItem.ToString();
            sch.SchTime = cmbSchTime.SelectedItem.ToString();
            sch.SchClass = cmbSchCls.SelectedItem.ToString();

            try
            {
                int result = controller.Update(sch);
                if (result > 0)
                {
                    OnUpdate?.Invoke(sch);
                    ResetInput();
                    LoadDataSchedule();
                    GDVSch.ClearSelection();
                    GDVSch.Refresh();
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

        private void btnDelSch_Click(object sender, EventArgs e)
        {
            if (GDVSch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = GDVSch.SelectedRows[0].Index;
            sch = ListOfSchedule[rowIndex];

            DialogResult confirmation = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    int result = controller.Delete(sch);
                    if (result > 0)
                    {
                        OnDelete?.Invoke(sch);

                        LoadDataSchedule();
                        GDVSch.ClearSelection();
                        GDVSch.Refresh();
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
            cmbSchTcr.SelectedIndex = -1;
            txtSchName.Clear();
            txtSchSub.Clear();
            cmbSchDay.SelectedIndex = -1;
            cmbSchTime.SelectedIndex = -1;
            cmbSchCls.SelectedIndex = -1;
            isNewData = true;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbSchTcr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSchTcr.SelectedValue != null)
            {
                string selectedtcId = cmbSchTcr.SelectedValue.ToString();
                var repo = new ScheduleRepository(new DbContext());
                string teacherNamesch = repo.GettcNamesch(selectedtcId);

                if (!string.IsNullOrEmpty(teacherNamesch))
                {
                    txtSchName.Text = teacherNamesch;
                }
                else
                {
                    txtSchName.Clear();
                }
            }

            if (cmbSchTcr.SelectedValue != null)
            {
                string selectedtcIdsch = cmbSchTcr.SelectedValue.ToString();
                var repo = new ScheduleRepository(new DbContext());
                string teacherSubjectssch = repo.GettcSubjectssch(selectedtcIdsch);

                if (!string.IsNullOrEmpty(teacherSubjectssch))
                {
                    txtSchSub.Text = teacherSubjectssch;
                }
                else
                {
                    txtSchSub.Clear();
                }
            }
        }

        private void GDVSch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan klik berada di dalam baris data, bukan header
            if (e.RowIndex >= 0 && e.RowIndex < GDVSch.Rows.Count)
            {
                try
                {
                    // Ambil baris yang diklik
                    DataGridViewRow row = GDVSch.Rows[e.RowIndex];

                    // Validasi data pada setiap kolom sebelum digunakan
                    if (row.Cells[0].Value != null)
                        cmbSchTcr.SelectedValue = row.Cells[0].Value.ToString();

                    if (row.Cells[1].Value != null)
                        txtSchName.Text = row.Cells[1].Value.ToString();

                    if (row.Cells[2].Value != null)
                        txtSchSub.Text = row.Cells[2].Value.ToString();

                    if (row.Cells[3].Value != null)
                        cmbSchDay.SelectedItem = row.Cells[3].Value.ToString();

                    if (row.Cells[4].Value != null)
                        cmbSchTime.SelectedItem = row.Cells[4].Value.ToString();

                    if (row.Cells[5].Value != null)
                        cmbSchCls.SelectedItem = row.Cells[5].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e) // Button Ekspor
        {

            try
            {
                // Lokasi penyimpanan file HTML
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Jadwal.html");

                // Template HTML
                StringBuilder htmlContent = new StringBuilder();
                htmlContent.AppendLine("<!DOCTYPE html>");
                htmlContent.AppendLine("<html lang='en'>");
                htmlContent.AppendLine("<head>");
                htmlContent.AppendLine("<meta charset='UTF-8'>");
                htmlContent.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1.0'>");
                htmlContent.AppendLine("<title>Jadwal Mata Pelajaran</title>");
                htmlContent.AppendLine("<style>");
                htmlContent.AppendLine("table { width: 100%; border-collapse: collapse; margin: 20px 0; }");
                htmlContent.AppendLine("th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }");
                htmlContent.AppendLine("th { background-color: #c0c0c0; }");
                htmlContent.AppendLine("</style>");
                htmlContent.AppendLine("</head>");
                htmlContent.AppendLine("<body>");
                htmlContent.AppendLine("<h1>Jadwal Mata Pelajaran</h1>");
                htmlContent.AppendLine("<table>");
                htmlContent.AppendLine("<thead>");
                htmlContent.AppendLine("<tr>");
                htmlContent.AppendLine("<th>No</th>");
                htmlContent.AppendLine("<th>Mata Pelajaran</th>");
                htmlContent.AppendLine("<th>Guru</th>");
                htmlContent.AppendLine("<th>Kelas</th>");
                htmlContent.AppendLine("<th>Hari</th>");
                htmlContent.AppendLine("<th>Waktu</th>");
                htmlContent.AppendLine("</tr>");
                htmlContent.AppendLine("</thead>");
                htmlContent.AppendLine("<tbody>");

                // Iterasi data dari GDVSch
                for (int i = 0; i < GDVSch.Rows.Count; i++)
                {
                    if (GDVSch.Rows[i].Cells[0].Value != null) // Validasi data
                    {
                        htmlContent.AppendLine("<tr>");
                        htmlContent.AppendLine($"<td>{i + 1}</td>");
                        htmlContent.AppendLine($"<td>{GDVSch.Rows[i].Cells[2].Value}</td>");
                        htmlContent.AppendLine($"<td>{GDVSch.Rows[i].Cells[1].Value}</td>");
                        htmlContent.AppendLine($"<td>{GDVSch.Rows[i].Cells[5].Value}</td>");
                        htmlContent.AppendLine($"<td>{GDVSch.Rows[i].Cells[3].Value}</td>");
                        htmlContent.AppendLine($"<td>{GDVSch.Rows[i].Cells[4].Value}</td>");
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

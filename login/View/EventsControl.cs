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
using login.Model.Entity;
using Mysqlx.Session;

namespace login.View
{
    public delegate void CreateUpdateEventEvntHandler(Event evn);
    public partial class EventsControl : UserControl
    {
        private List<Event> ListOfEvent = new List<Event>();
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventEvntHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventEvntHandler OnUpdate;
        // deklarasi event ketika terjadi proses hapus data
        public event CreateUpdateEventEvntHandler OnDelete;
        private EventController controller;
        private bool isNewData = true;



        private Event evn;
        public EventsControl()
        {
            InitializeComponent();
            controller = new EventController();
            InisialisasiGridView();
            LoadDataEvent();

            this.Resize += EventsContol_Resize;

            CenterGridView();

            OnCreate += EventCreatedHandler;
            OnUpdate += EventUpdateHandler;
            OnDelete += EventDeleteHandler;
        }
        private void EventCreatedHandler(Event evn)
        {
            MessageBox.Show($"Event {evn.EvntName} berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataEvent(); // Refresh DataGridView
        }
        private void EventUpdateHandler(Event evn)
        {
            MessageBox.Show($"Event {evn.EvntName} berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataEvent(); // Refresh DataGridView
        }
        private void EventDeleteHandler(Event evn)
        {
            MessageBox.Show($"Event {evn.EvntName} berhasil dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataEvent(); // Refresh DataGridView
        }


        private void InisialisasiGridView()
        {
            GDVEvnt.Columns.Clear();

            GDVEvnt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "EvntId",
                Width = 55,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVEvnt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nama Event",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            GDVEvnt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Duration/Hour",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });
            GDVEvnt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tanggal",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });


            // Mengatur garis grid
            GDVEvnt.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GDVEvnt.GridColor = System.Drawing.Color.Black;
        }
        private void LoadDataEvent()
        {
            // Kosongkan DataGridView
            GDVEvnt.Rows.Clear();

            // Panggil method ReadAll untuk mengambil data dari database
            List<Event> ListOfEvent = controller.ReadAll();

            // Iterasi melalui data mahasiswa dan tambahkan ke DataGridView
            foreach (var evn in ListOfEvent)
            {
                GDVEvnt.Rows.Add(
                    evn.EvntId, // Kolom ID
                    evn.EvntName,                 
                    evn.EvntDuration,                 
                    evn.EvntDate 
                                 
                );
            }

        }
        private void EventsContol_Resize(object sender, EventArgs e)
        {
            CenterGridView();
        }
        private void CenterGridView()
        {
            // Hitung posisi horizontal untuk menempatkan di tengah
            GDVEvnt.Left = (430 - 203) / 2;

        }
        private void btnAddEvnt_Click(object sender, EventArgs e)
        {
            // Perbaikan
            if (string.IsNullOrWhiteSpace(txtNameEvnt.Text) ||
             string.IsNullOrWhiteSpace(txtHourEvnt.Text))
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menambahkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isNewData) evn = new Event();
            evn.EvntName = txtNameEvnt.Text;
            evn.EvntDuration = txtHourEvnt.Text;
            evn.EvntDate = dtEvent.Text;
           
           

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(evn);
                if (result > 0)
                {
                    OnCreate?.Invoke(evn);

                    txtNameEvnt.Clear();
                    txtHourEvnt.Clear();
                    dtEvent.Value = DateTime.Now;
                   



                    txtNameEvnt.Focus();
                }
            }
            else
            {


                MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        int Key = 0;
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdtEvnt_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Silakan pilih data yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input
            if (string.IsNullOrWhiteSpace(txtNameEvnt.Text) ||
           string.IsNullOrWhiteSpace(txtHourEvnt.Text))
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menyimpan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update data mahasiswa
            evn = new Event
            {
                EvntId = GDVEvnt.SelectedRows[0].Cells[0].Value.ToString(),
                EvntName = txtNameEvnt.Text,
                EvntDuration = txtHourEvnt.Text,
                EvntDate = dtEvent.Text
                

               
            };

            // Kirim data ke controller untuk diperbarui
            int result = controller.Update(evn);

            if (result > 0)
            {
                OnUpdate?.Invoke(evn);

                LoadDataEvent(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelEvnt_Click(object sender, EventArgs e)
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
                evn = new Event
                {
                    EvntId = GDVEvnt.SelectedRows[0].Cells[0].Value.ToString()
                };

                int result = controller.Delete(evn);
                if (result > 0)
                {
                    OnDelete?.Invoke(evn);

                    LoadDataEvent(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GDVEvnt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
        private void ResetForm()
        {
            txtNameEvnt.Clear();
            txtHourEvnt.Clear();
            dtEvent.Value = DateTime.Now;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GDVEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan klik berada di dalam baris data
            {
                DataGridViewRow row = GDVEvnt.Rows[e.RowIndex];

                txtNameEvnt.Text = row.Cells[1].Value.ToString();
                txtHourEvnt.Text = row.Cells[2].Value.ToString();
                dtEvent.Text = row.Cells[3].Value.ToString();

                Key = Convert.ToInt32(row.Cells[0].Value.ToString()); // Set Key sesuai StId
            }
        }
    }
}

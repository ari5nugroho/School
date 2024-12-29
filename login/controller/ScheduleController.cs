using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login.Model.Entity;
using login.Model.Context;
using login.Model.Repository;
using System.Windows.Forms;
using System.Data;

namespace login.Controller
{
    internal class ScheduleController
    {
        private ScheduleRepository _schrepository;
        public List<Schedule> ReadAll()
        {
            // membuat objek collection
            List<Schedule> list = new List<Schedule>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _schrepository = new ScheduleRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _schrepository.ReadAll();
            }
            return list;
        }

        public DataTable FetchStudentIds()
        {
            return _schrepository.GettcIdsch();
        }
        public int Create(Schedule sch)
        {
            int result = 0;
            if (string.IsNullOrEmpty(sch.tcId))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(sch.SchName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(sch.SchSubjects))
            {
                MessageBox.Show("Subject harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchDay))
            {
                MessageBox.Show("Day harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchTime))
            {
                MessageBox.Show("Time harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchClass))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _schrepository = new ScheduleRepository(context);
                result = _schrepository.Create(sch);
            }
            if (result > 0)
            {
                MessageBox.Show("Jadwal Pelajaran berhasil Ditambahkan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Jadwal Pelajaran gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;

        }

        public int Update(Schedule sch)
        {
            int result = 0;
            if (string.IsNullOrEmpty(sch.tcId))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(sch.SchName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(sch.SchSubjects))
            {
                MessageBox.Show("Subject harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchDay))
            {
                MessageBox.Show("Day harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchTime))
            {
                MessageBox.Show("Time harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchClass))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                _schrepository = new ScheduleRepository(context);
                result = _schrepository.Update(sch);
            }
            if (result > 0)
            {
                MessageBox.Show("Jadwal Pelajaran berhasil Diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Jadwal Pelajaran gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result; ;
        }
        public int Delete(Schedule sch)
        {
            int result = 0;
            if (string.IsNullOrEmpty(sch.tcId))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(sch.SchName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(sch.SchSubjects))
            {
                MessageBox.Show("Subject harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchDay))
            {
                MessageBox.Show("Day harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchTime))
            {
                MessageBox.Show("Time harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sch.SchClass))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                _schrepository = new ScheduleRepository(context);
                result = _schrepository.Delete(sch);
            }
            if (result > 0)
            {
                MessageBox.Show("Mata Pelajaran berhasil Dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Mata Pelajaran gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result; ;
        }
    }
}

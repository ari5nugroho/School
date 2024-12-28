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
    internal class AttendanceController
    {
        private AttendanceRepository _attrepository;
        public List<Attendance> ReadAll()
        {
            // membuat objek collection
            List<Attendance> list = new List<Attendance>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _attrepository = new AttendanceRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _attrepository.ReadAll();
            }
            return list;
        }

        public DataTable FetchStudentIds()
        {
            return _attrepository.GetStId();
        }
        public int Create(Attendance att)
        {
            int result = 0;
            if (string.IsNullOrEmpty(att.StId))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(att.AttStName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(att.AttStDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(att.AttStStatus))
            {
                MessageBox.Show("Status harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _attrepository = new AttendanceRepository(context);
                result = _attrepository.Create(att);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Murid berhasil Ditambahkan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Data Murid gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;

        }

        public int Update(Attendance att)
        {
            int result = 0;
            if (string.IsNullOrEmpty(att.StId))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(att.AttStName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(att.AttStDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(att.AttStStatus))
            {
                MessageBox.Show("Status harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                _attrepository = new AttendanceRepository(context);
                result = _attrepository.Update(att);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Murid berhasil Diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Data Murid gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result; ;
        }
        public int Delete(Attendance att)
        {
            int result = 0;
            if (string.IsNullOrEmpty(att.StId))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(att.AttStName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(att.AttStDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(att.AttStStatus))
            {
                MessageBox.Show("Status harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                _attrepository = new AttendanceRepository(context);
                result = _attrepository.Delete(att);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Murid berhasil Dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Data Murid gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result; ;
        }
    }
}

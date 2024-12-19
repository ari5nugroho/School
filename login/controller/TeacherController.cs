using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Model.Context;
using login.Model.Entity;
using login.Model.Repository;
namespace login.Controller
{
    internal class TeacherController
    {
        private TeacherRepository _tcrepository;
        public List<Teacher> ReadAll()
        {
            List<Teacher> list = new List<Teacher>();
            using (DbContext context = new DbContext())
            {
                _tcrepository = new TeacherRepository(context);
                list = _tcrepository.ReadAll();
            }
            return list;
        }

        public int Create(Teacher tcr)
        {
            int result = 0;
            if (string.IsNullOrEmpty(tcr.tcName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tcr.tcGen))
            {
                MessageBox.Show("Gen harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tcr.tcDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcPhone))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcSubject))
            {
                MessageBox.Show("Fee harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcAdrs))
            {
                MessageBox.Show("Address harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _tcrepository = new TeacherRepository(context);
                result = _tcrepository.Create(tcr);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Guru berhasil Ditambahkan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Data Guru gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;

        }

        public int Update(Teacher tcr)
        {
            int result = 0;
            if (string.IsNullOrEmpty(tcr.tcName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tcr.tcGen))
            {
                MessageBox.Show("Gen harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tcr.tcDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcPhone))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcSubject))
            {
                MessageBox.Show("Fee harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcAdrs))
            {
                MessageBox.Show("Address harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _tcrepository = new TeacherRepository(context);
                result = _tcrepository.Update(tcr);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Guru berhasil Diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Data Guru gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;

        }

        public int Delete(Teacher tcr)
        {
            int result = 0;
            if (string.IsNullOrEmpty(tcr.tcName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tcr.tcGen))
            {
                MessageBox.Show("Gen harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tcr.tcDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcPhone))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcSubject))
            {
                MessageBox.Show("Fee harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tcr.tcAdrs))
            {
                MessageBox.Show("Address harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _tcrepository = new TeacherRepository(context);
                result = _tcrepository.Delete(tcr);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Guru berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Data Guru gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;

        }
    }
}

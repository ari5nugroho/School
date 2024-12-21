using System;
using System.Collections.Generic;
using System.Windows.Forms;
using login.Model.Context;
using login.Model.Entity;
using login.Model.Repository;

namespace login.Controller
{
    public class StudentController
    {
        private StudentRepository _repository;

        private bool ValidateStudent(Student std)
        {
            if (string.IsNullOrEmpty(std.StName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(std.StGen))
            {
                MessageBox.Show("Gen harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(std.StDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(std.StClass))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(std.StFee))
            {
                MessageBox.Show("Fee harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(std.StAdrs))
            {
                MessageBox.Show("Address harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public int Create(Student std)
        {
            int result = 0;
            if (string.IsNullOrEmpty(std.StName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(std.StGen))
            {
                MessageBox.Show("Gen harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(std.StDOB))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(std.StClass))
            {
                MessageBox.Show("Class harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(std.StFee))
            {
                MessageBox.Show("Fee harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(std.StAdrs))
            {
                MessageBox.Show("Address harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new StudentRepository(context);
                result = _repository.Create(std);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Murid berhasil Ditambahkan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Data Murid gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Student std)
        {
            if (!ValidateStudent(std)) return 0;

            using (DbContext context = new DbContext())
            {
                _repository = new StudentRepository(context);
                int result = _repository.Update(std);
                if (result > 0)
                {
                    MessageBox.Show("Data Murid berhasil Diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Murid gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return result;
            }
        }

        public int Delete(Student std)
        {
            if (string.IsNullOrEmpty(std.StName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new StudentRepository(context);
                int result = _repository.Delete(std);
                if (result > 0)
                {
                    MessageBox.Show("Data Murid berhasil Dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Murid gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return result;
            }
        }

        public List<Student> ReadAll()
        {
            List<Student> list = new List<Student>();
            using (DbContext context = new DbContext())
            {
                _repository = new StudentRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }
    }
}
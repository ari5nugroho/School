using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login.Model.Entity;
using login.Model.Context;
using login.Model.Repository;
using System.Data;
using System.Windows.Forms;

namespace login.Controller
{
    internal class FeesController
    {
        private FeesRepository _feesrepository;
        public List<Fees> ReadAll()
        {
            // membuat objek collection
            List<Fees> list = new List<Fees>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _feesrepository = new FeesRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _feesrepository.ReadAll();
            }
            return list;
        }
        public DataTable FetchStudentId()
        {
            return _feesrepository.GetStIdfee();
        }
        public int Create(Fees fees)
        {
            int result = 0;
            if (string.IsNullOrEmpty(fees.StId))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(fees.StNameFees))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(fees.StPrdFees))
            {
                MessageBox.Show("DOB harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(fees.StAmountFees))
            {
                MessageBox.Show("Status harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _feesrepository = new FeesRepository(context);
                result = _feesrepository.Create(fees);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Murid berhasil Ditambahkan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Data Murid gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;

        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login.Model.Repository;
using login.Model.Entity;
using login.Model.Context;
using System.Windows.Forms;

namespace login.Controller
{
    public class EventController
    {
        private EventReposiotory _evnrepository;
        public int Create(Event evn)
        {
            int result = 0;
            if (string.IsNullOrEmpty(evn.EvntName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(evn.EvntDate))
            {
                MessageBox.Show("Date harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(evn.EvntDuration))
            {
                MessageBox.Show("Duration harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
           
            using (DbContext context = new DbContext())
            {
                _evnrepository = new EventReposiotory(context);
                result = _evnrepository.Create(evn);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Event berhasil Ditambahkan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

                MessageBox.Show("Data Event gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Event evn)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _evnrepository = new EventReposiotory(context);
                result = _evnrepository.Update(evn);


            }
            if (result > 0)
            {
                MessageBox.Show("Data Event berhasil Diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

                MessageBox.Show("Data Event gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Event evn)
        {


            using (DbContext context = new DbContext())
            {
                _evnrepository = new EventReposiotory(context);
                int result = _evnrepository.Delete(evn);
                if (result > 0)
                {
                    MessageBox.Show("Data Event berhasil Dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Event gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return result;
            }
        }

        public List<Event> ReadAll()
        {
            List<Event> list = new List<Event>();
            using (DbContext context = new DbContext())
            {
                _evnrepository = new EventReposiotory(context);
                list = _evnrepository.ReadAll();
            }

            return list;
        }
    }
}

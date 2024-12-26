using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using login.Model.Entity;
using login.Model.Context;

namespace login.Model.Repository
{
    public class TeacherRepository
    {
        private SQLiteConnection Con;
        public TeacherRepository(DbContext context)
        {
            Con = context.Conn;
        }
        public int Create(Teacher tcr)
        {
            int result = 0;
            string sql = @"insert into tbTeacher (tcName, tcGen, tcDOB, tcPhone, tcSubject, tcAdrs) values (@tcName,@tcGen,@tcDOB,@tcPhone,@tcSubject,@tcAdrs)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@tcName", tcr.tcName);
                cmd.Parameters.AddWithValue("@tcGen", tcr.tcGen);
                cmd.Parameters.AddWithValue("@tcDOB", tcr.tcDOB);
                cmd.Parameters.AddWithValue("@tcPhone", tcr.tcPhone);
                cmd.Parameters.AddWithValue("@tcSubject", tcr.tcSubject);
                cmd.Parameters.AddWithValue("@tcAdrs", tcr.tcAdrs);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Update(Teacher tcr)
        {
            int result = 0;
            string sql = @"update tbTeacher set tcName=@tcName,tcGen=@tcGen,tcDOB=@tcDOB,tcPhone=@tcPhone,tcSubject=@tcSubject,tcAdrs=@tcAdrs where tcId = @tcId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@tcId", tcr.tcId);
                cmd.Parameters.AddWithValue("@tcName", tcr.tcName);
                cmd.Parameters.AddWithValue("@tcGen", tcr.tcGen);
                cmd.Parameters.AddWithValue("@tcDOB", tcr.tcDOB);
                cmd.Parameters.AddWithValue("@tcPhone", tcr.tcPhone);
                cmd.Parameters.AddWithValue("@tcSubject", tcr.tcSubject);
                cmd.Parameters.AddWithValue("@tcAdrs", tcr.tcAdrs);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Teacher tcr)
        {
            int result = 0;
            string sql = @"Delete from tbTeacher where tcId = @tcId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@tcId", tcr.tcId);
                cmd.Parameters.AddWithValue("@tcName", tcr.tcName);
                cmd.Parameters.AddWithValue("@tcGen", tcr.tcGen);
                cmd.Parameters.AddWithValue("@tcDOB", tcr.tcDOB);
                cmd.Parameters.AddWithValue("@tcPhone", tcr.tcPhone);
                cmd.Parameters.AddWithValue("@tcSubject", tcr.tcSubject);
                cmd.Parameters.AddWithValue("@tcAdrs", tcr.tcAdrs);

                try
                {

                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }
        public List<Teacher> ReadAll()
        {
            List<Teacher> list = new List<Teacher>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from tbTeacher";
                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Teacher tcr = new Teacher();
                            tcr.tcId = dtr["tcId"].ToString();
                            tcr.tcName = dtr["tcName"].ToString();
                            tcr.tcGen = dtr["tcGen"].ToString();
                            tcr.tcDOB = dtr["tcDOB"].ToString();
                            tcr.tcPhone = dtr["tcPhone"].ToString();
                            tcr.tcSubject = dtr["tcSubject"].ToString();
                            tcr.tcAdrs = dtr["tcAdrs"].ToString();
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(tcr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;

        }
    }
}

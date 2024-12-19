using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login.Model.Context;
using login.Model.Entity;
using System.Data.SQLite;
namespace login.Model.Repository
{
    internal class AttendanceRepository
    {
        private SQLiteConnection Con;
        public AttendanceRepository(DbContext context)
        {
            Con = context.Conn;
        }
        public int Create(Attendance att)
        {
            int result = 0;
            string sql = @"insert into tbAttendance (stIdAtt, stNameAtt, stDOBAtt, stStatusAtt) values (@SId,@SName,@SDOB,@SStatus)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stIdAtt", att.AttStId);
                cmd.Parameters.AddWithValue("@stNameAtt", att.AttStName);
                cmd.Parameters.AddWithValue("@stDOBAtt", att.AttStDOB);
                cmd.Parameters.AddWithValue("@stStatusAtt", att.AttStStatus);

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

        public int Update(Attendance att)
        {
            int result = 0;
            string sql = @"update tbAttendance set stIdAtt=@SId,stNameAtt=@SName,stDOBAtt=@SDOB,stStatusAtt=@SStatus)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stIdAtt", att.AttStId);
                cmd.Parameters.AddWithValue("@stNameAtt", att.AttStName);
                cmd.Parameters.AddWithValue("@stDOBAtt", att.AttStDOB);
                cmd.Parameters.AddWithValue("@stStatusAtt", att.AttStStatus);
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

        public int Delete(Attendance att)
        {
            int result = 0;
            string sql = @"Delete from tbAttendance where stIdAtt = @SId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stIdAtt", att.AttStId);
                cmd.Parameters.AddWithValue("@stNameAtt", att.AttStName);
                cmd.Parameters.AddWithValue("@stDOBAtt", att.AttStDOB);
                cmd.Parameters.AddWithValue("@stStatusAtt", att.AttStStatus);
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
        public List<Attendance> ReadAll()
        {
            List<Attendance> list = new List<Attendance>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from tbAttendance";
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
                            Attendance att = new Attendance();
                            att.AttStId = dtr["stIdAtt"].ToString();
                            att.AttStName = dtr["stNameAtt"].ToString();
                            att.AttStDOB = dtr["stDOBAtt"].ToString();
                            att.AttStStatus = dtr["stStatusAtt"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(att);
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

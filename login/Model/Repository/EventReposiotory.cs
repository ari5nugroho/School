using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using login.Model.Context;
using login.Model.Entity;

namespace login.Model.Repository
{
    public class EventReposiotory
    {
        private SQLiteConnection Con;
        public EventReposiotory(DbContext context)
        {
            Con = context.Conn;
        }
        public int Create(Event evn)
        {
            int result = 0;
            string sql = @"insert into tbEvent (EvntName, EvntDate, EvntHour) values (@EvntName,@EvntDate,@EvntHour)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@EvntName", evn.EvntName);
                cmd.Parameters.AddWithValue("@EvntDate", evn.EvntDate);
                cmd.Parameters.AddWithValue("@EvntHour", evn.EvntDuration);
              
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

        public int Update(Event evn)
        {
            int result = 0;
            string sql = @"update tbEvent set EvntName=@EvntName,EvntDate=@EvntDate,EvntHour=@EvntHour WHERE EvntId = @EvntId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@EvntId", evn.EvntId);
                cmd.Parameters.AddWithValue("@EvntName", evn.EvntName);
                cmd.Parameters.AddWithValue("@EvntDate", evn.EvntDate);
                cmd.Parameters.AddWithValue("@EvntHour", evn.EvntDuration);

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

        public int Delete(Event evn)
        {
            int result = 0;
            string sql = @"Delete from tbEvent where EvntId = @EvntId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@EvntId", evn.EvntId);

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
        public List<Event> ReadAll()
        {
            List<Event> list = new List<Event>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from tbEvent";
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
                            Event evn = new Event();
                            evn.EvntId = dtr["EvntId"].ToString();
                            evn.EvntName = dtr["EvntName"].ToString();
                            evn.EvntDate = dtr["EvntDate"].ToString();
                            evn.EvntDuration = dtr["EvntHour"].ToString();
                           
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(evn);
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

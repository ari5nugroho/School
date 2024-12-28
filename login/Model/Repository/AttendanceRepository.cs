﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login.Model.Context;
using login.Model.Entity;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
namespace login.Model.Repository
{
    public class AttendanceRepository
    {
        private SQLiteConnection Con;
        public AttendanceRepository(DbContext context)
        {
            Con = context.Conn;
        }
        public DataTable GetStId()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT stId FROM stStudent";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    dt.Columns.Add("StId", typeof(int));
                    dt.Load(rdr);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStudentIds error: {0}", ex.Message);
            }

            return dt;
        }
        public int Create(Attendance att)
        {
            int result = 0;
            string sql = @"insert into tbAttendance (stIdAtt, stNameAtt, stDobAtt, stStatusAtt) values (@stIdAtt,@stNameAtt,@stDobAtt,@stStatusAtt)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stIdAtt", att.AttStId);
                cmd.Parameters.AddWithValue("@stNameAtt", att.AttStName);
                cmd.Parameters.AddWithValue("@stDobAtt", att.AttStDOB);
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
            string sql = @"update tbAttendance set stIdAtt=@stIdAtt,stNameAtt=@stNameAtt,stDobAtt=@stDobAtt,stStatusAtt=@stStatusAtt";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stIdAtt", att.AttStId);
                cmd.Parameters.AddWithValue("@stNameAtt", att.AttStName);
                cmd.Parameters.AddWithValue("@stDobAtt", att.AttStDOB);
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
            string sql = @"Delete from tbAttendance where stIdAtt = @stIdAtt";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stIdAtt", att.AttStId);
                cmd.Parameters.AddWithValue("@stNameAtt", att.AttStName);
                cmd.Parameters.AddWithValue("@stDobAtt", att.AttStDOB);
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
                            att.AttStDOB = dtr["stDobAtt"].ToString();
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

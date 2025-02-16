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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
namespace login.Model.Repository
{
    public class AttendanceRepository
    {
        private SQLiteConnection Con;
        public AttendanceRepository(DbContext context)
        {
            Con = context.Conn;
        }
        public string GetStName(string stName)
        {
            string studentName = string.Empty;
            string sql = "SELECT stId FROM stStudent WHERE stName = @stName";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@stName", stName);
                    studentName = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStId error: {0}", ex.Message);
            }

            return studentName;
        }
       
        public DataTable GetStId()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT stName FROM stStudent";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    dt.Load(rdr); // Langsung load data ke DataTable
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStId error: {0}", ex.Message);
            }

            return dt;
        }
        public int Create(Attendance att)
        {
            int result = 0;
            string sql = @"insert into tbAttendance (stId,stNameAtt, stDobAtt, stStatusAtt) values (@stId,@stNameAtt, @stDobAtt,@stStatusAtt)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stId", att.StId);
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
            string sql = @"update tbAttendance set stDobAtt=@stDobAtt,stStatusAtt=@stStatusAtt WHERE stId=@stId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stId", att.StId);
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
            string sql = @"Delete from tbAttendance where stId = @stId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stId", att.StId);
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
                            att.StId = dtr["StId"].ToString();
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

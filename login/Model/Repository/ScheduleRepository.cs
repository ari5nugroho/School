using System;
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
    public class ScheduleRepository
    {
        private SQLiteConnection Con;
        public ScheduleRepository(DbContext context)
        {
            Con = context.Conn;
        }
        public string GettcNamesch(string tcName)
        {
            string teacherNamesch = string.Empty;
            string sql = "SELECT tcId FROM tbTeacher WHERE tcName = @tcName";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@tcName", tcName);
                    teacherNamesch = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GettcId error: {0}", ex.Message);
            }

            return teacherNamesch;
        }
        public string GettcSubjectssch(string tcName)
        {
            string teacherSubjectssch = string.Empty;
            string sql = "SELECT tcSubject FROM tbTeacher WHERE tcName = @tcName";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@tcName", tcName);
                    teacherSubjectssch = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GettcSubject error: {0}", ex.Message);
            }

            return teacherSubjectssch;
        }

        public DataTable GettcIdsch()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT tcName FROM tbTeacher";

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
                System.Diagnostics.Debug.Print("GettcName error: {0}", ex.Message);
            }

            return dt;
        }
        public int Create(Schedule sch)
        {
            int result = 0;
            string sql = @"insert into tbSchedule (tcId,schName, schSubjects, schDay, schTime, schClass) values (@tcId, @schName, @schSubjects, @schDay, @schTime, @schClass)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@tcId", sch.tcId);
                cmd.Parameters.AddWithValue("@schName", sch.SchName);
                cmd.Parameters.AddWithValue("@schSubjects", sch.SchSubjects);
                cmd.Parameters.AddWithValue("@schDay", sch.SchDay);
                cmd.Parameters.AddWithValue("@schTime", sch.SchTime);
                cmd.Parameters.AddWithValue("@schClass", sch.SchClass);

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
        public int Update(Schedule sch)
        {
            int result = 0;
            string sql = @"update tbSchedule set schDay=@schDay,schTime=@schTime, schClass=@schClass WHERE tcId=@tcId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@tcId", sch.tcId);
                cmd.Parameters.AddWithValue("@schName", sch.SchName);
                cmd.Parameters.AddWithValue("@schSubjects", sch.SchSubjects);
                cmd.Parameters.AddWithValue("@schDay", sch.SchDay);
                cmd.Parameters.AddWithValue("@schTime", sch.SchTime);
                cmd.Parameters.AddWithValue("@schClass", sch.SchClass);
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
        public int Delete(Schedule sch)
        {
            int result = 0;
            string sql = @"Delete from tbSchedule where tcId = @tcId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@tcId", sch.tcId);
                cmd.Parameters.AddWithValue("@schName", sch.SchName);
                cmd.Parameters.AddWithValue("@schSubjects", sch.SchSubjects);
                cmd.Parameters.AddWithValue("@schDay", sch.SchDay);
                cmd.Parameters.AddWithValue("@schTime", sch.SchTime);
                cmd.Parameters.AddWithValue("@schClass", sch.SchClass);
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

        public List<Schedule> ReadAll()
        {
            List<Schedule> list = new List<Schedule>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from tbSchedule";
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
                            Schedule sch = new Schedule();
                            sch.tcId = dtr["tcId"].ToString();
                            sch.SchName = dtr["SchName"].ToString();
                            sch.SchSubjects = dtr["SchSubjects"].ToString();
                            sch.SchDay = dtr["SchDay"].ToString();
                            sch.SchTime = dtr["SchTime"].ToString();
                            sch.SchClass = dtr["SchClass"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(sch);
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

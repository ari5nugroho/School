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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace login.Model.Repository
{
    public class FeesRepository
    {
        private SQLiteConnection Con;
        public FeesRepository(DbContext context)
        {
            Con = context.Conn;
        }
        public string GetStNamefee(string stName)
        {
            string studentNamefee = string.Empty;
            string sql = "SELECT stId FROM stStudent WHERE stName = @stName";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@stName", stName);
                    studentNamefee = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStName error: {0}", ex.Message);
            }

            return studentNamefee;
        }
        public string GetAmountFees(string stName)
        {
            string FeesAmountstd = string.Empty;
            string sql = "SELECT stFee FROM stStudent WHERE stName = @stName";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@stName", stName);
                    FeesAmountstd = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GettcName error: {0}", ex.Message);
            }

            return FeesAmountstd;
        }
        public DataTable GetStIdfee()
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
        public int Create(Fees fees)
        {
            int result = 0;
            string sql = @"insert into tbFees (stId,StNameFees, StPrdFees, StAmountFees) values (@stId,@StNameFees, @StPrdFees, @StAmountFees)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stId", fees.StId);
                cmd.Parameters.AddWithValue("@StNameFees", fees.StNameFees);
                cmd.Parameters.AddWithValue("@StPrdFees", fees.StPrdFees);
                cmd.Parameters.AddWithValue("@StAmountFees", fees.StAmountFees);

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
        public int UpdateStudentFeeToZero(string stId)
        {
            int result = 0;
            string sql = "UPDATE stStudent SET stFee = 0 WHERE stId = @stId";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@stId", stId);

                    // Jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("UpdateStudentFeeToZero error: {0}", ex.Message);
            }

            return result;
        }
        public List<Fees> ReadAll()
        {
            List<Fees> list = new List<Fees>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from tbFees";
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
                            Fees fees = new Fees();
                            fees.StId = dtr["StId"].ToString();
                            fees.StNameFees = dtr["StNameFees"].ToString();
                            fees.StPrdFees = dtr["StPrdFees"].ToString();
                            fees.StAmountFees = dtr["StAmountFees"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(fees);
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

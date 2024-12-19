using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace login.Model.Context
{
    internal class DbContext : IDisposable
    {
        // deklarasi private variabel / field
        private SQLiteConnection Con;
        // deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public SQLiteConnection Conn
        {
            get
            {
                if (Con == null || Con.State == ConnectionState.Closed)
                {
                    Con = GetOpenConnection();
                }
                return Con;
            }
        }
        // Method untuk melakukan koneksi ke database
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                string dbName = @"E:\Pemrograman Lanjut\ProjectFinal\Database\DbSchool.db";
                string connectionString = $"Data Source={dbName};FailIfMissing=True";
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                throw; // Lempar kembali pengecualian untuk penanganan lebih lanjut
            }
            return conn;
        }
        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan

        public void Dispose()
        {
            if (Con != null)
            {
                try
                {
                    if (Con.State != ConnectionState.Closed)
                    {
                        Con.Close();
                    }
                }
                finally
                {
                    Con.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }


    }
}

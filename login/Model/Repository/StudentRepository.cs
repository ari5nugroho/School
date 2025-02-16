﻿using login.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using login.Model.Entity;

namespace login.Model.Repository
{
    public class StudentRepository
    {
        private SQLiteConnection Con;
        public StudentRepository(DbContext context)
        {
            Con = context.Conn;
        }
        public int Create(Student std)
        {
            int result = 0;
            string sql = @"insert into stStudent (stName, stGen, stDOB, stClass, stFee, stAdrs) values (@stName,@stGen,@stDOB,@stClass,@stFee,@stAdrs)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stName", std.StName);
                cmd.Parameters.AddWithValue("@stGen", std.StGen);
                cmd.Parameters.AddWithValue("@stDOB", std.StDOB);
                cmd.Parameters.AddWithValue("@stClass", std.StClass);
                cmd.Parameters.AddWithValue("@stFee", std.StFee);
                cmd.Parameters.AddWithValue("@stAdrs", std.StAdrs);
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

        public int Update(Student std)
        {
            int result = 0;
            string sql = @"update stStudent set stName=@stName,stGen=@stGen,stDOB=@stDOB,stClass=@stClass,stFee=@stFee,stAdrs=@stAdrs WHERE stId = @stId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stId", std.StId);
                cmd.Parameters.AddWithValue("@stName", std.StName);
                cmd.Parameters.AddWithValue("@stGen", std.StGen);
                cmd.Parameters.AddWithValue("@stDOB", std.StDOB);
                cmd.Parameters.AddWithValue("@stClass", std.StClass);
                cmd.Parameters.AddWithValue("@stFee", std.StFee);
                cmd.Parameters.AddWithValue("@stAdrs", std.StAdrs);
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

        public int Delete(Student std)
        {
            int result = 0;
            string sql = @"Delete from stStudent where stId = @stId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
            {
                cmd.Parameters.AddWithValue("@stId", std.StId);
               
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
        public List<Student> ReadAll()
        {
            List<Student> list = new List<Student>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from stStudent";
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
                            Student std = new Student();
                            std.StId = dtr["StId"].ToString();
                            std.StName = dtr["StName"].ToString();
                            std.StGen = dtr["StGen"].ToString();
                            std.StDOB = dtr["stDOB"].ToString();
                            std.StClass = dtr["stClass"].ToString();
                            std.StFee = dtr["stFee"].ToString();
                            std.StAdrs = dtr["stAdrs"].ToString();
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(std);
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

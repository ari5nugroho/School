using login.Model.Context;
using login.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Model.Repository
{
    public class DashboardRepository
    {
        private SQLiteConnection Con;
        public DashboardRepository(DbContext context)
        {
            Con = context.Conn;
        }

        //operasi Read database
        public string GetCountStd(string labelcount)
        {
            string stdCount = string.Empty;
            string sql = "SELECT count(*) FROM stStudent";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@count", stdCount);
                    stdCount = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStName error: {0}", ex.Message);
            }

            return stdCount;
        }
        public string GetCountTcr(string labelcounttcr)
        {
            string tcrCount = string.Empty;
            string sql = "SELECT count(*) FROM tbTeacher";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@count", tcrCount);
                    tcrCount = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStName error: {0}", ex.Message);
            }

            return tcrCount;
        }
        public string GetCountEvn(string labelcountevn)
        {
            string evnCount = string.Empty;
            string sql = "SELECT count(*) FROM tbEvent";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@count", evnCount);
                    evnCount = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStName error: {0}", ex.Message);
            }

            return evnCount;
        }
        public string GetSumFee(string labelsumfee)
        {
            string feeSum = string.Empty;
            string sql = "SELECT sum(StAmountFees) FROM tbFees";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@count", feeSum);
                    feeSum = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetStName error: {0}", ex.Message);
            }

            return feeSum;
        }
    }
}

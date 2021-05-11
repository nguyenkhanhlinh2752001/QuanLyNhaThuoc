using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace QuanLyNhaThuoc.DAL
{
    class ConnectionData
    {
        protected static String connectionString = @"Data Source=VT-PGH\SQLEXPRESS;Initial Catalog=QuanLyNhaThuoc;Integrated Security=True";
        static SqlConnection conn;


        public static void OpenConnection()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public static DataTable ExecQuery(string sql)
        { 
            OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            ad.Fill(dt);
            CloseConnection();
            return dt;
        }
        public static void ExeNonQuery(string sql)
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }



    }

}

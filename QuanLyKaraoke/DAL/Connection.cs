using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection conn;

        public static void connect()
        {
            string s = "Data Source=LAPTOP-FISS31HP\\SQLEXPRESS;Initial Catalog=QuanLyKaraoke;Integrated Security=True";
            conn = new SqlConnection(s);
            conn.Open();
        }

        public static void actionQuery(string sql, SqlParameter[] parameters)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql, SqlParameter[] parameters)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    dataAdapter.SelectCommand.Parameters.Add(parameter);
                }
            }
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            //conn.Close();
            return dt;
        }
    }
}

using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playgroundManager
{
    class DbConnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M3JLTQ3;Initial Catalog=playground;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();

        public DbConnection()
        { }

        public void Inserts(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Updates(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Deletes(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable Select(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
    
}

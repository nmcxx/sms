using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class DataProvider
    {
        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                connect.Close();
            }
            return dt;
        }
    }
}

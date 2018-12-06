using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusStation
{
    public class xuLyDB
    {
        public static SqlConnection connect = new SqlConnection();
        public xuLyDB()
        {
            try
            {
                connect.ConnectionString = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLyBenXe;Integrated Security=True";
                connect.Open();
            }catch(SqlException sqlEx)
            {
                connect.Close();
                throw sqlEx;

            }
        }
    }
}

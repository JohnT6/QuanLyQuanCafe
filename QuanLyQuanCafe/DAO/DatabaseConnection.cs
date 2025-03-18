using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class DatabaseConnection
    {

        private static readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

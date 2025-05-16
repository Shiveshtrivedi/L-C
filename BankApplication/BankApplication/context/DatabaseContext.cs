using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.context
{
    public class DatabaseContext
    {
        private static readonly string connectionString = "Server=ITT-SHIVESH-TRI\\SQLEXPRESS;Database=BankApplication;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_DATABASE
{
    public class NewDBConnection
    {
        public static SqlConnection _sqlConnection = Setup();

        public static SqlConnection Setup()
        {
            string connectionString = GetConnectionString();
            var sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

        public static string GetConnectionString()
        {
            return @"Data Source=DESKTOP-F3KC1IH\TEW_SQLEXPRESS;Initial Catalog=PeopleDB;Integrated Security=True";
        }
    }
}

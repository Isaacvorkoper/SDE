using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MinOrm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            string query = "SELECT = FROM "

            SqlConnection myConn = GetConnection();
            myConn.Open();

            SqlCommand cmd = new SqlCommand(query, myConn);
            cmd.ExecuteReader();

            myConn.Close();
            Console.WriteLine("Hello again");
        }

        static SqlConnection GetSqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                InitialCatalog =
                UserID =
                password =
                DataSource =
            };

            SqlConnection conn = new SqlConnection(builder.ConnectionString);
            return conn;
        }
    }
}

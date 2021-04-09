using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace employeeManagementSystem
{
    class databaseConnection
    {
        public static String CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";


        public SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);
            connection.Open();

            return connection;
        }
    }
}

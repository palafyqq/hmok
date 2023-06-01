using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmok.Code
{
    internal class DB
    {
        //SqlConnection connection = new SqlConnection("Data Source = K1-312-05\\SQLEXPRESS;Initial Catalog = plfqq;User ID = Palafyqq; Password = 12345");
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-SV30352;Initial Catalog = q1;User ID = UserSQL; Password = 12345");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}

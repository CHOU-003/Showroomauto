using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBconnect
{
    public class SqlConnectionManager
    {
        private string connectionString;

        public SqlConnectionManager()
        {
            connectionString = "Data Source=TINO;Initial Catalog=Showroomauto;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        }

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Kết nối thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối thất bại: " + ex.Message);

            }


            return connection;

        }

    }
}

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
            connectionString = "Data Source=LAPTOP-3O5S38SK\\DINHCHAU;User ID=AutoUser;Password=showroom;Initial Catalog=Showroomauto;";

        }

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Kết nối thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message);

            }


            return connection;

        }

    }
}

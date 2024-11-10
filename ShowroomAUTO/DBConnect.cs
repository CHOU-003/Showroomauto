
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace DBConnect

{
    public class SqlConnectionManager
    {
        private string connectionString;

        public SqlConnectionManager()
        {

            connectionString = "Data Source=WINDOWS-DMT5G0O;User ID=test;Password=1234;Initial Catalog=Showroomauto;";

            

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

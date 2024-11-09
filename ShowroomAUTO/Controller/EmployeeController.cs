using ShowroomAUTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DBconnect;
using System.Drawing;
using ShowroomAUTO.View;

namespace ShowroomAUTO.Controller
{
    internal class EmployeeController : IController
    {
        private List<IModel> _items;
        private SqlConnectionManager _connectionManager;
        private EmployeeModel models;
        public List<IModel> Items => this._items;

		public EmployeeController()
		{
			_items = new List<IModel>();
			_connectionManager = new SqlConnectionManager();
		}
		public bool Login(string employeeID, string password)
		{
			using (SqlConnection connection = _connectionManager.GetConnection())
			{
				string query = "SELECT * FROM EMPLOYEE WHERE employeeID = @employeeID AND password = @password";
				SqlCommand cmd = new SqlCommand(query, connection);

				cmd.Parameters.AddWithValue("@employeeID", employeeID);
				cmd.Parameters.AddWithValue("@password", password);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.HasRows)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
		}

		public bool Create(IModel model)
        {
            EmployeeModel cus = (EmployeeModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "INSERT INTO EMPLOYEE VALUES (@EmployeeID, @username, @password, @role)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeID", cus.employeeID);
                    command.Parameters.AddWithValue("@username", cus.username);
                    command.Parameters.AddWithValue("@password", cus.password);
                    command.Parameters.AddWithValue("@role", cus.role);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Create: " + ex.Message);
                return false;
            }
        }

        public bool Delete(IModel model)
        {
            EmployeeModel cus = (EmployeeModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "DELETE FROM EMPLOYEE WHERE employeeID = @EmployeeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", cus.employeeID);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Delete: " + ex.Message);
                return false;
            }
        }

        public bool IsExist(object employeeID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE employeeID = @EmployeeID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID.ToString());
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xử lý: " + ex.Message);
                return false;
            }
        }

        public bool Load()
        {
            try
            {
                _items.Clear();
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT employeeID, username, password, role FROM EMPLOYEE";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        EmployeeModel model = new EmployeeModel
                        {
                            employeeID = reader["employeeID"].ToString(),
                            username = reader["username"].ToString(),
                            password = reader["password"].ToString(),
                            role = reader["role"].ToString(),
                        };
                        _items.Add(model);
                    }
                    reader.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Load: " + ex.Message);
                return false;
            }
        }

        public bool Load(object emlployeeID)
        {
            throw new NotImplementedException();
        }

        public IModel Read(IModel employeeID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT * FROM  EMPLOYEE WHERE employeeID = @EmployeeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            EmployeeModel model = new EmployeeModel
                            {
                                employeeID = reader["employeeID"].ToString(),
                                username = reader["username"].ToString(),
                                password = reader["password"].ToString(),
                                role = reader["role"].ToString(),
                            };
                            return model;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Read: " + ex.Message);
            }
            return null;
        }

        public List<IModel> Search(string name)
        {
            List<IModel> results = new List<IModel>();
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT employeeID, username, password, role FROM EMPLOYEE WHERE username LIKE @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", "%" + name + "%");
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeModel model = new EmployeeModel
                            {
                                employeeID = reader["employeeID"].ToString(),
                                username = reader["username"].ToString(),
                                password = reader["password"].ToString(),
                                role = reader["role"].ToString(),
                            };
                            results.Add(model);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SearchByName: " + ex.Message);
            }
            return results;
        }

        public bool Update(IModel model)
        {
            EmployeeModel cus = (EmployeeModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "UPDATE EMPLOYEE SET username = @Username, role = @role, password = @password WHERE employeeID = @EmployeeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", cus.employeeID);
                        command.Parameters.AddWithValue("@Username", cus.username);
						command.Parameters.AddWithValue("@Password", cus.password);
						command.Parameters.AddWithValue("@Role", cus.role);
                   
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Update: " + ex.Message);
                return false;
            }
        }
        public bool Read(Object employeeID)
        {

            return true;
        }
        IModel IController.Read(object customerID)
        {
            throw new NotImplementedException();
        }
    }
}

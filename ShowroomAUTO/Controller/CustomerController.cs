using ShowroomAUTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DBConnect;

namespace ShowroomAUTO.Controller
{
    internal class CustomerController : IController
    {
        private List<IModel> _items;
        private SqlConnectionManager _connectionManager;
        private CustomerModel models;

        public CustomerController()
        {
            _items = new List<IModel>();
            _connectionManager = new SqlConnectionManager();
        }

        public List<IModel> Items => this._items;

        public bool Create(IModel model)
        {
            CustomerModel cus = (CustomerModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "INSERT INTO CUSTOMER (customerID, name, phone, address, status) VALUES (@CustomerID, @Name, @Phone, @Address, @Status)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", cus.customerID);
                    command.Parameters.AddWithValue("@Name", cus.name);
                    command.Parameters.AddWithValue("@Phone", cus.phone);
                    command.Parameters.AddWithValue("@Address", cus.address);
                    command.Parameters.AddWithValue("@Status", cus.status);
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
            CustomerModel cus = (CustomerModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "DELETE FROM CUSTOMER WHERE customerID = @CustomerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", cus.customerID);
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


        public bool Load()
        {
            try
            {
                _items.Clear();
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT customerID, name, phone, address, status FROM CUSTOMER";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        CustomerModel model = new CustomerModel
                        {
                            customerID = reader["customerID"].ToString(),
                            name = reader["name"].ToString(),
                            phone = reader["phone"].ToString(),
                            address = reader["address"].ToString(),
                            status = reader["status"].ToString()
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


        public bool Load(object customerID)
        {
            throw new NotImplementedException();
        }

        public IModel Read(IModel customerID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT * FROM  CUSTOMER WHERE customerID = @CustomerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            CustomerModel model = new CustomerModel
                            {
                                customerID = reader["CustomerID"].ToString(),
                                name = reader["Name"].ToString(),
                                phone = reader["Phone"].ToString(),
                                address = reader["Address"].ToString(),
                                status = reader["Status"].ToString()
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

        public bool Update(IModel model)
        {
            CustomerModel cus = (CustomerModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "UPDATE CUSTOMER SET name = @Name, phone = @Phone, address = @Address, status = @Status WHERE customerID = @CustomerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", cus.customerID);
                        command.Parameters.AddWithValue("@Name", cus.name);
                        command.Parameters.AddWithValue("@Phone", cus.phone);
                        command.Parameters.AddWithValue("@Address", cus.address);
                        command.Parameters.AddWithValue("@Status", cus.status);
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

        public List<IModel> Search(string name)
        {
            List<IModel> results = new List<IModel>();
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT customerID, name, phone, address, status FROM CUSTOMER WHERE name LIKE @Name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", "%" + name + "%");
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomerModel model = new CustomerModel
                            {
                                customerID = reader["customerID"].ToString(),
                                name = reader["name"].ToString(),
                                phone = reader["phone"].ToString(),
                                address = reader["address"].ToString(),
                                status = reader["status"].ToString()
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


        public bool IsExist(object customerID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM CUSTOMER WHERE customerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID.ToString());
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


        public bool Read(Object customerID)
        {

            return true;
        }

        IModel IController.Read(object customerID)
        {
            throw new NotImplementedException();
        }
    }
}

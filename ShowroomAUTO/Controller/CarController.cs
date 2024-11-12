using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowroomAUTO.Model;
using System.Data.SqlClient;
using ShowroomAUTO.Controller;
using DBconnect;

namespace ShowroomAUTO.Controllers
{
    internal class CarController : IController
    {
        private List<IModel> _items;
        private SqlConnectionManager _connectionManager;
        private CarModel models;

        public CarController()
        {
            _items = new List<IModel>();
            _connectionManager = new SqlConnectionManager();
        }

        public List<IModel> Items => this._items;

        public bool Create(IModel model)
        {
            CarModel crm = (CarModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "insert into CAR (carID,brand,model,price,status, color) Values (@CarID, @Brand, @Model, @Price, @Status, @Color)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CarID", crm.carID);
                    command.Parameters.AddWithValue("@Brand", crm.brand);
                    command.Parameters.AddWithValue("@Model", crm.model);
                    command.Parameters.AddWithValue("@Price", crm.price);
                    command.Parameters.AddWithValue("@Status", crm.status);
                    command.Parameters.AddWithValue("@Color", crm.color);
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
            CarModel crm = (CarModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "DELETE FROM CAR WHERE carID = @CarID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarID", crm.carID);
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
                    string query = "SELECT * FROM CAR";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        CarModel model = new CarModel
                        {
                            carID = reader["CarID"].ToString(),
                            brand = reader["Brand"].ToString(),
                            model = reader["Model"].ToString(),
                            price = reader["Price"].ToString(),
                            status = reader["Status"].ToString(),
                            color = reader["Color"].ToString()
                        };
                        _items.Add(model);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Load: " + ex.Message);
                return false;
            }

        }

        public bool Load(object id)
        {
            throw new NotImplementedException();
        }

        public IModel Read(IModel id)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT * FROM CAR WHERE carID = @CarID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarID", id);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            CarModel model = new CarModel
                            {
                                carID = reader["CarID"].ToString(),
                                brand = reader["Brand"].ToString(),
                                model = reader["Model"].ToString(),
                                price = reader["Price"].ToString(),
                                status = reader["Status"].ToString(),
                                color = reader["Color"].ToString()
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
            CarModel crm = (CarModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "UPDATE CAR SET brand = @Brand, model = @Model, price = @Price, status = @Status, color = @Color WHERE carID = @CarID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarID", crm.carID);
                        command.Parameters.AddWithValue("@Brand", crm.brand);
                        command.Parameters.AddWithValue("@Model", crm.model);
                        command.Parameters.AddWithValue("@Price", crm.price);
                        command.Parameters.AddWithValue("@Status", crm.status);
                        command.Parameters.AddWithValue("@Color", crm.color);
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

        public List<IModel> Search(string brand)
        {
            List<IModel> results = new List<IModel>();
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT carID, brand, model, price, status, color FROM CAR WHERE brand LIKE @Brand";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Brand", "%" + brand + "%");
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            CarModel model = new CarModel
                            {
                                carID = reader["CarID"].ToString(),
                                brand = reader["Brand"].ToString(),
                                model = reader["Model"].ToString(),
                                price = reader["Price"].ToString(),
                                status = reader["Status"].ToString(),
                                color = reader["Color"].ToString()
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

        public bool IsExist(object id)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM CAR WHERE carID = @CarID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CarID", id.ToString());
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


        public bool Read(Object id)
        {

            return true;
        }

        IModel IController.Read(object id)
        {
            throw new NotImplementedException();
        }
    }
}

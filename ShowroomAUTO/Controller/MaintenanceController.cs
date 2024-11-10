using ShowroomAUTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DBconnect;

namespace ShowroomAUTO.Controller
{
    internal class MaintenanceController : IController
    {
        private List<IModel> _items;
        private SqlConnectionManager _connectionManager;
        private MaintenanceModel models;

        public MaintenanceController()
        {
            _items = new List<IModel>();
            _connectionManager = new SqlConnectionManager();
        }

        public List<IModel> Items => this._items;

        public bool Create(IModel model)
        {
            MaintenanceModel main = (MaintenanceModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "INSERT INTO MAINTENANCE (maintenanceID, nameCustomer, vehicle, details, dateBD, typeBD ,maintenanceStatus, totalCost, nameEmployee, notes) " +
                        "VALUES (@MaintenanceID, @NameCustomer, @Vehicle, @Details,@DateBD, @TypeBD,  @MaintenanceStatus, @TotalCost, @NameEmployee, @Notes)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaintenanceID", main.maintenanceID);
                    command.Parameters.AddWithValue("@NameCustomer", main.nameCustomer);
                    command.Parameters.AddWithValue("@Vehicle", main.vehicle);
                    command.Parameters.AddWithValue("@Details", main.details);
                    command.Parameters.AddWithValue("@DateBD", main.dateBD);
                    command.Parameters.AddWithValue("@TypeBD", main.typeBD);
                    command.Parameters.AddWithValue("@MaintenanceStatus", main.maintenanceStatus);
                    command.Parameters.AddWithValue("@TotalCost", main.totalCost);
                    command.Parameters.AddWithValue("@NameEmployee", main.nameEmployee);
                    command.Parameters.AddWithValue("@Notes", main.notes);

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
            MaintenanceModel main = (MaintenanceModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "DELETE FROM MAINTENANCE WHERE maintenanceID = @MaintenanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaintenanceID", main.maintenanceID);
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
                    string query = "SELECT maintenanceID, nameCustomer, vehicle, details, dateBD, typeBD, maintenanceStatus, totalCost, nameEmployee, notes FROM MAINTENANCE";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MaintenanceModel model = new MaintenanceModel
                        {
                            maintenanceID = reader["maintenanceID"].ToString(),
                            nameCustomer = reader["nameCustomer"].ToString(),
                            vehicle = reader["vehicle"].ToString(),
                            details = reader["details"].ToString(),
                            dateBD = reader["dateBD"].ToString(),
                            typeBD = reader["typeBD"].ToString(),
                            maintenanceStatus = reader["maintenanceStatus"].ToString(),
                            totalCost = reader["totalCost"].ToString(),
                            nameEmployee = reader["nameEmployee"].ToString(),
                            notes = reader["notes"].ToString(),
                        };
                        _items.Add(model);
                    }
                    reader.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Load: " + ex.ToString());
                return false;
            }
        }



        public bool Load(object maintenanceID)
        {
            throw new NotImplementedException();
        }

        public IModel Read(IModel maintenanceID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT * FROM  MAINTENANCE WHERE maintenanceID = @MaintenanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaintenanceID", maintenanceID);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            MaintenanceModel model = new MaintenanceModel
                            {
                                maintenanceID = reader["MaintenanceID"].ToString(),
                                nameCustomer = reader["NameCustomer"].ToString(),
                                vehicle = reader["Vehicle"].ToString(),
                                details = reader["Details"].ToString(),
                                dateBD = reader["DateBD"].ToString(),
                                typeBD = reader["TypeBD"].ToString(),
                                maintenanceStatus = reader["MaintenanceStatus"].ToString(),
                                totalCost = reader["TotalCost"].ToString(),
                                nameEmployee = reader["NameEmployee"].ToString(),
                                notes = reader["Notes"].ToString(),
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
            MaintenanceModel main = (MaintenanceModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "UPDATE MAINTENANCE SET nameCustomer = @NameCustomer, vehicle = @Vehicle, dateBD = @DateBD, typeBD = @TypeBD, details = @Details, maintenanceStatus = @MaintenanceStatus, totalCost = @TotalCost, nameEmployee = @NameEmployee, notes = @Notes" +
                        " WHERE maintenanceID = @MaintenanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaintenanceID", main.maintenanceID);
                        command.Parameters.AddWithValue("@NameCustomer", main.nameCustomer);
                        command.Parameters.AddWithValue("@Vehicle", main.vehicle);
                        command.Parameters.AddWithValue("@DateBD", main.dateBD);
                        command.Parameters.AddWithValue("@TypeBD", main.typeBD);
                        command.Parameters.AddWithValue("@Details", main.details);
                        command.Parameters.AddWithValue("@MaintenanceStatus", main.maintenanceStatus);
                        command.Parameters.AddWithValue("@TotalCost", main.totalCost);
                        command.Parameters.AddWithValue("@NameEmployee", main.nameEmployee);
                        command.Parameters.AddWithValue("@Notes", main.notes);
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

        public List<IModel> Search(string nameCustomer)
        {
            List<IModel> results = new List<IModel>();
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT maintenanceID, nameCustomer, vehicle, details, dateBD, typeBD,maintenanceStatus, totalCost, nameEmployee, notes  FROM MAINTENANCE WHERE nameCustomer LIKE @NameCustomer";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NameCustomer", "%" + nameCustomer + "%");
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            MaintenanceModel model = new MaintenanceModel
                            {
                                maintenanceID = reader["maintenanceID"].ToString(),
                                nameCustomer = reader["nameCustomer"].ToString(),
                                vehicle = reader["vehicle"].ToString(),
                                details = reader["details"].ToString(),
                                dateBD = reader["dateBD"].ToString(),
                                typeBD = reader["typeBD"].ToString(),     
                                maintenanceStatus = reader["maintenanceStatus"].ToString(),
                                totalCost = reader["totalCost"].ToString(),
                                nameEmployee = reader["nameEmployee"].ToString(),
                                notes = reader["notes"].ToString(),
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


        public bool IsExist(object maintenanceID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM MAINTENANCE WHERE maintenanceID = @MaintenanceID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaintenanceID", maintenanceID.ToString());
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


        public bool Read(Object maintenanceID)
        {

            return true;
        }

        IModel IController.Read(object maintenanceID)
        {
            throw new NotImplementedException();
        }
    }
}

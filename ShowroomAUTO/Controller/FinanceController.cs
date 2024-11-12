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
    internal class FinanceController : IController
    {
        private List<IModel> _items;
        private SqlConnectionManager _connectionManager;
        private FinanceModel models;

        public FinanceController()
        {
            _items = new List<IModel>();
            _connectionManager = new SqlConnectionManager();
        }

        public List<IModel> Items => this._items;

        public bool Create(IModel model)
        {
            FinanceModel fin = (FinanceModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "INSERT INTO FINANCE (financeID, income, expense) VALUES (@FinanceID, @Income, @Expense)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FinanceID", fin.financeID);
                    command.Parameters.AddWithValue("@Income", fin.income);
                    command.Parameters.AddWithValue("@Expense", fin.expense);
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
            FinanceModel fin = (FinanceModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "DELETE FROM FINANCE WHERE financeID = @FinanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FinanceID", fin.financeID);
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
                    string query = "SELECT financeID, income, expense FROM FINANCE";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        FinanceModel model = new FinanceModel
                        {
                            financeID = reader["financeID"].ToString(),
                            income = reader["income"].ToString(),
                            expense = reader["expense"].ToString(),
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


        public bool Load(object financeID)
        {
            throw new NotImplementedException();
        }

        public IModel Read(IModel financeID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT * FROM  FINANCE WHERE financeID = @FinanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FinanceID", financeID);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            FinanceModel model = new FinanceModel
                            {
                                financeID = reader["FinanceID"].ToString(),
                                income = reader["Income"].ToString(),
                                expense = reader["Expense"].ToString(),
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
            FinanceModel fin = (FinanceModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "UPDATE FINANCE SET income = @Income, expense = @Expense WHERE financeID = @FinanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FinanceID", fin.financeID);
                        command.Parameters.AddWithValue("@Income", fin.income);
                        command.Parameters.AddWithValue("@Expense", fin.expense);
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

        public List<IModel> Search(string financeID)
        {
            List<IModel> results = new List<IModel>();
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT financeID, income, expense FROM FINANCE WHERE financeID LIKE @FinanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FinanceID", "%" + financeID + "%");
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            FinanceModel model = new FinanceModel
                            {
                                financeID = reader["financeID"].ToString(),
                                income = reader["income"].ToString(),
                                expense = reader["expense"].ToString(),
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


        public bool IsExist(object financeID)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM FINANCE WHERE financeID = @FinanceID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FinanceID", financeID.ToString());
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


        public bool Read(Object financeID)
        {

            return true;
        }

        IModel IController.Read(object financeID)
        {
            throw new NotImplementedException();
        }
    }
}

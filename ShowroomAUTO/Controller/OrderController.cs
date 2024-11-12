using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowroomAUTO.Model;
using System.Data.SqlClient;
using ShowroomAUTO.Controllers;
using ShowroomAUTO.View;
using DBconnect;

namespace ShowroomAUTO.Controller
{
    internal class OrderController : IController
    {
        private List<IModel> _items;
        private SqlConnectionManager _connectionManager;
        private OrderModel models;

        private CustomerController customerController = new CustomerController();
        private CarController carController = new CarController();
        private EmployeeController employeeController = new EmployeeController();

        public OrderController()
        {
            _items = new List<IModel>();
            _connectionManager = new SqlConnectionManager();
        }

        public List<IModel> Items => this._items;

        public bool Create(IModel model)
        {
            OrderModel order = (OrderModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    ; // Mở kết nối trước khi thực thi câu lệnh

                    string query = "INSERT INTO [ORDER] (orderID, customer_id, car_id, employee_id, orderDate, value, status) " +
                                   "VALUES (@OrderID, @Customer_ID, @Car_ID, @Employee_ID, @OrderDate, @Value, @Status)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@OrderID", order.orderID);
                    command.Parameters.AddWithValue("@Customer_ID", order.customer_id);
                    command.Parameters.AddWithValue("@Car_ID", order.car_id);
                    command.Parameters.AddWithValue("@Employee_ID", order.employee_id);
                    command.Parameters.AddWithValue("@OrderDate", order.orderDate);
                    command.Parameters.AddWithValue("@Value", order.value);
                    command.Parameters.AddWithValue("@Status", order.status);

                    command.ExecuteNonQuery(); // Thực thi câu lệnh chèn

                }
                return true;
            }
            catch (Exception ex)
            {
                // Ghi ra lỗi chi tiết để chẩn đoán
                Console.WriteLine("Error in Create: " + ex.Message);
                return false;
            }
        }




        public bool Delete(IModel model)
        {
            OrderModel order = (OrderModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "DELETE FROM [ORDER] WHERE orderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", order.orderID);
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
                // Khởi tạo lại danh sách trước khi tải dữ liệu mới
                //if (_items == null)
                //{
                //    _items = new List<OrderModel>(); // Đảm bảo _items được khởi tạo
                //}

                _items.Clear();

                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    // Sử dụng dấu ngoặc vuông để đảm bảo không gặp vấn đề với từ khóa 'ORDER'
                    string query = "SELECT * FROM [ORDER]";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ DataReader
                    while (reader.Read())
                    {
                        OrderModel model = new OrderModel
                        {
                            orderID = reader["orderID"].ToString(),
                            customer_id = reader["customer_id"].ToString(),
                            car_id = reader["car_id"].ToString(),
                            employee_id = reader["employee_id"].ToString(),
                            // Kiểm tra nếu 'orderDate' là null và chuyển đổi giá trị thích hợp
                            orderDate = reader["orderDate"] != DBNull.Value ? Convert.ToDateTime(reader["orderDate"]) : DateTime.MinValue,
                            // Kiểm tra nếu 'value' là null và gán giá trị mặc định 0
                            value = reader["value"] != DBNull.Value ? Convert.ToDecimal(reader["value"]) : 0,
                            status = reader["status"] != DBNull.Value ? reader["status"].ToString() : "Unknown"

                        };
                        _items.Add(model);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ghi lỗi ra console nếu có lỗi xảy ra
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
                    string query = "SELECT * FROM [ORDER] WHERE orderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", id);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            OrderModel model = new OrderModel
                            {
                                orderID = reader["OrderID"].ToString(),
                                customer_id = reader["Customer_id"].ToString(),
                                car_id = reader["Car_id"].ToString(),
                                employee_id = reader["Employee_id"].ToString(),
                                orderDate = Convert.ToDateTime(reader["OrderDate"]),
                                value = Convert.ToDecimal(reader["value"]),
                                status = reader["Status"].ToString(),
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
            OrderModel order = (OrderModel)model; // Chuyển đổi model thành OrderModel
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "UPDATE [ORDER] SET customer_id = @CustomerID, car_id = @CarID, employee_id = @EmployeeID, orderDate = @OrderDate, value = @Value, status = @Status WHERE orderID = @OrderID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số với giá trị từ các thuộc tính của odr
                        command.Parameters.AddWithValue("@OrderID", order.orderID);
                        command.Parameters.AddWithValue("@CustomerID", order.customer_id);
                        command.Parameters.AddWithValue("@CarID", order.car_id);
                        command.Parameters.AddWithValue("@EmployeeID", order.employee_id);
                        command.Parameters.AddWithValue("@OrderDate", order.orderDate);
                        command.Parameters.AddWithValue("@Value", order.value);
                        command.Parameters.AddWithValue("@Status", order.status);

                        command.ExecuteNonQuery(); // Thực thi câu lệnh cập nhật
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


        public List<IModel> Search(string customerID)
        {
            List<IModel> results = new List<IModel>();
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT orderID, customer_id, car_id, employee_id, orderDate, value, status FROM [ORDER] WHERE customer_id LIKE @CustomerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", "%" + customerID + "%");
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            OrderModel model = new OrderModel
                            {
                                orderID = reader["OrderID"].ToString(),
                                customer_id = reader["Customer_id"].ToString(),
                                car_id = reader["Car_id"].ToString(),
                                employee_id = reader["Employee_id"].ToString(),
                                orderDate = Convert.ToDateTime(reader["OrderDate"]),
                                value = Convert.ToDecimal(reader["Value"]),
                                status = reader["Status"].ToString(),
                            };
                            results.Add(model);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Search: " + ex.Message);
            }
            return results;
        }

        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn7;

        public bool IsExist(object id)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM [ORDER] WHERE orderID = @OrderID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderID", id.ToString());
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

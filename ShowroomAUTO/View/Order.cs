using ShowroomAUTO.Controller;
using ShowroomAUTO.Controllers;
using ShowroomAUTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ShowroomAUTO.View
{
    public partial class Order : Form , IView
    {
        private OrderController controller;
        private OrderModel order;
        public Order()
        {
            InitializeComponent();
            controller = new OrderController();
            order = new OrderModel();

            this.Load += new EventHandler(OrderView_Load);
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            try
            {
                // Xóa tất cả các hàng hiện tại trong DataGridView trước khi tải dữ liệu mới
                dataGridView1.Rows.Clear();

                // Gọi phương thức Load() của controller để tải dữ liệu
                if (controller.Load())
                {
                    // Kiểm tra xem controller.Items có chứa dữ liệu không
                    if (controller.Items != null && controller.Items.Count > 0)
                    {
                        foreach (var Order in controller.Items)
                        {
                            OrderModel order = (OrderModel)Order;
                            dataGridView1.Rows.Add(order.orderID, order.customer_id, order.car_id, order.employee_id, order.orderDate, order.value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Danh sách hàng trống.");
                    }
                }
                else
                {
                    MessageBox.Show("Không tải được danh sách hàng.");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi chi tiết nếu có ngoại lệ
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách hàng: " + ex.Message);
            }
        }


        private void GetDataFromTextBoxes()
        {
            order.orderID = textBoxID.Text;            // Sử dụng textBoxOrderID cho orderID
            order.customer_id = textBoxCustomer.Text;     // Sử dụng textBoxCustomerID cho customer_id
            order.car_id = textBoxCar.Text;               // Sử dụng textBoxCarID cho car_id
            order.employee_id = textBoxEmployee.Text;     // Sử dụng textBoxEmployeeID cho employee_id
            order.orderDate = dateTimePicker1.Value; // Sử dụng dateTimePickerOrderDate cho orderDate
            order.value = decimal.TryParse(textBoxValue.Text, out decimal parsedValue) ? parsedValue : 0;  // Sử dụng textBoxValue cho value, với kiểm tra chuyển đổi
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng từ DataGridView
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ các cột của hàng vào các TextBox và các điều khiển khác tương ứng
                textBoxID.Text = row.Cells["orderID"].Value?.ToString();           // orderID
                textBoxCustomer.Text = row.Cells["customer_id"].Value?.ToString();    // customer_id
                textBoxCar.Text = row.Cells["car_id"].Value?.ToString();              // car_id
                textBoxEmployee.Text = row.Cells["employee_id"].Value?.ToString();    // employee_id
                dateTimePicker1.Value = row.Cells["orderDate"].Value != null
                    ? Convert.ToDateTime(row.Cells["orderDate"].Value)
                    : DateTime.Now;                                                     // orderDate
                textBoxValue.Text = row.Cells["value"].Value?.ToString();               // value
            }
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            string searchName = textBoxFind.Text;
            List<IModel> results = controller.Search(searchName);

            dataGridView1.Rows.Clear();
            foreach (OrderModel model in results)
            {
                dataGridView1.Rows.Add(order.orderID, order.customer_id, order.car_id, order.employee_id, order.orderDate, order.value);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!order.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(order.orderID))
            {
                controller.Update(order);

            }
            else
            {
                controller.Create(order);
            }

            LoadOrderList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string orderID = textBoxID.Text;

            if (string.IsNullOrEmpty(orderID))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Kiểm tra xem ID có tồn tại trong cơ sở dữ liệu không
                if (controller.IsExist(orderID))
                {
                    order.orderID = orderID;
                    if (controller.Delete(order))   
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với ID này!");
                }

                LoadOrderList();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!order.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(order.orderID))
            {
                if (controller.Update(order))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với ID này!");
            }

            LoadOrderList();
        }

        public void GetDataFromText()
        {
            order.car_id = textBoxCar.Text;
            order.employee_id = textBoxEmployee.Text;
            order.customer_id = textBoxCustomer.Text;
            order.orderDate = DateTime.Now;
            var value = textBoxValue.Text;
            if (value != null && !value.Equals(""))
            {
                order.value = decimal.Parse(value);
            }
            else { 
                order.value = 0;
            }
        }

        public void SetDataToText()
        {
            textBoxCar.Text = order.car_id;
            textBoxCustomer.Text = order.employee_id;
            textBoxEmployee.Text = order.customer_id;
            textBoxValue.Text = order.value.ToString();
        }
    }
}

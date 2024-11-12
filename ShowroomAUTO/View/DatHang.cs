using ShowroomAUTO.Controller;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShowroomAUTO.View
{
    public partial class DatHang : Form
    {
        public DatHang()
        {
            InitializeComponent();
            controller = new OrderController();
            order = new OrderModel();
        }
        private OrderController controller;
        private OrderModel order;
        private void GetDataFromTextBoxes()
        {
            order.orderID = textBoxID.Text;                  // Sử dụng textBoxOrderID cho orderID
            order.customer_id = textBoxCustomer.Text;        // Sử dụng textBoxCustomerID cho customer_id
            order.car_id = textBoxCar.Text;                  // Sử dụng textBoxCarID cho car_id
            order.employee_id = textBoxEmployee.Text;        // Sử dụng textBoxEmployeeID cho employee_id
            order.orderDate = dateTimePicker1.Value;         // Sử dụng dateTimePickerOrderDate cho orderDate
            order.value = decimal.TryParse(textBoxValue.Text, out decimal parsedValue) ? parsedValue : 0;
            order.status = "Đang xử lý";                     // Thiết lập giá trị mặc định cho status
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
                bool isCreated = controller.Create(order);
                MessageBox.Show("Thêm thành công");

                if (!isCreated)
                {
                    MessageBox.Show("Không thể tạo dữ liệu mới. Vui lòng kiểm tra kết nối hoặc dữ liệu đầu vào.");
                }
            }

        }

        private void buttonhHuy_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của các ô nhập liệu
            textBoxID.Text = string.Empty;
            textBoxCustomer.Text = string.Empty;
            textBoxCar.Text = string.Empty;
            textBoxEmployee.Text = string.Empty;
            textBoxValue.Text = string.Empty;

            // Đặt lại giá trị mặc định cho DateTimePicker nếu cần
            dateTimePicker1.Value = DateTime.Now;

            // Tùy chọn: Thiết lập trạng thái mặc định cho các trường hoặc các checkbox khác nếu có
            // Ví dụ: nếu có checkbox cần bỏ chọn khi nhấn nút Hủy
            // checkBoxStatus.Checked = false;

            // Tùy chọn: Đặt lại tiêu đề hoặc trạng thái hiển thị mặc định cho các nút điều khiển khác nếu cần
            // Ví dụ:
            // buttonSave.Text = "Lưu";
        }
    }
}

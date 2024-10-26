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
using System.Xml.Linq;

namespace ShowroomAUTO.View
{
    public partial class Customer : Form
    {
        private CustomerController controller;

        private CustomerModel customer;


        public Customer()
        {
            InitializeComponent();
            controller = new CustomerController();
            customer = new CustomerModel();
            this.Load += new EventHandler(CustomerView_Load);
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void LoadCustomerList()
        {
            dataGridView.Rows.Clear();
            if (controller.Load())
            {
                foreach (CustomerModel customer in controller.Items)
                {
                    dataGridView.Rows.Add(customer.customerID, customer.name, customer.phone, customer.address, customer.status);
                }
            }
            else
            {
                MessageBox.Show("Không tải được danh sách khách hàng.");
            }
        }


        private void GetDataFromTextBoxes()
        {
            customer.customerID = txtCustomerID.Text;
            customer.name = txtName.Text;
            customer.phone = txtPhone.Text;
            customer.address = txtAddress.Text;
            customer.status = txtStatus.Text;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtPhone.Text = row.Cells[2].Value?.ToString();
                txtAddress.Text = row.Cells[3].Value?.ToString();
                txtStatus.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!customer.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(customer.customerID))
            {
                controller.Update(customer);

            }
            else
            {
                controller.Create(customer);
            }

            LoadCustomerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!customer.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(customer.customerID))
            {
                if (controller.Update(customer))
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

            LoadCustomerList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomerID.Text;

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (controller.IsExist(customerID))
                {
                    customer.customerID = customerID;
                    if (controller.Delete(customer))
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

                LoadCustomerList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchName = textBox6.Text;
            List<IModel> results = controller.Search(searchName);

            dataGridView.Rows.Clear();
            foreach (CustomerModel model in results)
            {
                dataGridView.Rows.Add(model.customerID, model.name, model.phone, model.address, model.status);
            }
        }
    }
}

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

        }

    }
}

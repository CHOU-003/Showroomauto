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
    public partial class Employee : Form
    {
        private EmployeeController controller;

        private EmployeeModel employee;
        public Employee()
        {
            InitializeComponent();
            controller = new EmployeeController();
            employee = new EmployeeModel();
            this.Load += new EventHandler(EmployeeView_Load);
        }
        private void EmployeeView_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }
        private void LoadEmployeeList()
        {
            dataGridView.Rows.Clear();
            if (controller.Load())
            {
                foreach (EmployeeModel employee in controller.Items)
                {
                    dataGridView.Rows.Add(employee.employeeID, employee.username, employee.password, employee.role);
                }
            }
            else
            {
                MessageBox.Show("Không tải được danh sách nhân viên.");
            }
        }
        private void GetDataFromTextBoxes()
        {
            employee.employeeID = txtEmployeeID.Text;
            employee.username = txtUsername.Text;
            employee.password = txtPassword.Text;
            employee.role = txtRole.Text;
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtEmployeeID.Text = row.Cells[0].Value?.ToString();
                txtUsername.Text = row.Cells[1].Value?.ToString();
                txtPassword.Text = row.Cells[2].Value?.ToString();
                txtRole.Text = row.Cells[3].Value?.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!employee.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(employee.employeeID))
            {
                controller.Update(employee);

            }
            else
            {
                controller.Create(employee);
            }

            LoadEmployeeList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!employee.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(employee.employeeID))
            {
                if (controller.Update(employee))
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

            LoadEmployeeList();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;

            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (controller.IsExist(employeeID))
                {
                    employee.employeeID = employeeID;
                    if (controller.Delete(employee))
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

                LoadEmployeeList();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string searchName = textBox6.Text;
            List<IModel> results = controller.Search(searchName);

            dataGridView.Rows.Clear();
            foreach (EmployeeModel model in results)
            {
                dataGridView.Rows.Add(model.employeeID, model.username, model.password, model.role);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}

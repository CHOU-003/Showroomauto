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
    public partial class Maintenance : Form
    {
        private MaintenanceController controller;
        private MaintenanceModel maintenance;

        public Maintenance()
        {
            InitializeComponent();
            controller = new MaintenanceController();
            maintenance = new MaintenanceModel();
            this.Load += new EventHandler(MaintenanceView_Load);
        }

        private void MaintenanceView_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridView.Rows.Clear();
            if (controller.Load())
            {
                foreach (MaintenanceModel maintenance in controller.Items)
                {
                    dataGridView.Rows.Add(maintenance.maintenanceID, maintenance.nameCustomer, maintenance.vehicle,
                       maintenance.details, maintenance.dateBD, maintenance.typeBD, maintenance.maintenanceStatus,
                        maintenance.totalCost, maintenance.nameEmployee, maintenance.notes);
                }
            }
            else
            {
                MessageBox.Show("Không tải được danh sách bảo dưỡng.");
            }
        }

        private void GetDataFromTextBoxes()
        {
            maintenance.maintenanceID = txtCustomerID.Text;
            maintenance.nameCustomer = txtName.Text;
            maintenance.vehicle = txtAddress.Text;
            maintenance.details = textBox1.Text;

            maintenance.dateBD = txtPhone.Text;

            maintenance.typeBD = txtStatus.Text;

            maintenance.maintenanceStatus = textBox2.Text;

            maintenance.totalCost = textBox3.Text;
            maintenance.nameEmployee = textBox4.Text;
            maintenance.notes = textBox5.Text;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtAddress.Text = row.Cells[2].Value?.ToString();
                textBox1.Text = row.Cells[3].Value?.ToString();
                txtPhone.Text = row.Cells[4].Value?.ToString();
                txtStatus.Text = row.Cells[5].Value?.ToString();
                textBox2.Text = row.Cells[6].Value?.ToString();
                textBox3.Text = row.Cells[7].Value?.ToString();
                textBox4.Text = row.Cells[8].Value?.ToString();
                textBox5.Text = row.Cells[9].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!maintenance.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(maintenance.maintenanceID))
            {
                controller.Update(maintenance);

            }
            else
            {
                controller.Create(maintenance);
            }

            LoadList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!maintenance.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(maintenance.maintenanceID))
            {
                if (controller.Update(maintenance))
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

            LoadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maintenanceID = txtCustomerID.Text;

            if (string.IsNullOrEmpty(maintenanceID))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (controller.IsExist(maintenanceID))
                {
                    maintenanceID = maintenanceID;
                    if (controller.Delete(maintenance))
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

                LoadList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchName = textBox6.Text;
            List<IModel> results = controller.Search(searchName);

            dataGridView.Rows.Clear();
            foreach (MaintenanceModel model in results)
            {
                dataGridView.Rows.Add(model.maintenanceID, model.nameCustomer, model.vehicle, model.details, model.dateBD, model.typeBD, model.maintenanceStatus, model.totalCost, model.nameEmployee, model.notes);
            }
        }
    }
}

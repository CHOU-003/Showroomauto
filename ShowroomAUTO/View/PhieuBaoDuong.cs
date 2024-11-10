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

namespace ShowroomAUTO.View
{
    public partial class PhieuBaoDuong : Form
    {
        private MaintenanceController controller;
        private MaintenanceModel maintenance;
        public PhieuBaoDuong()
        {
            InitializeComponent();
            controller = new MaintenanceController();
            maintenance = new MaintenanceModel();
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
                controller.Update(maintenance);

            }
            else
            {
                controller.Create(maintenance);
                MessageBox.Show("Đặt lịch phiếu bảo dưỡng thành công!");
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class Finance : Form
    {
        private FinanceController controller;

        private FinanceModel finance;


        public Finance()
        {
            InitializeComponent();
            controller = new FinanceController();
            finance = new FinanceModel();
            this.Load += new EventHandler(View_Load);
        }

        private void View_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridView.Rows.Clear();
            if (controller.Load())
            {
                foreach (FinanceModel finance in controller.Items)
                {
                    dataGridView.Rows.Add(finance.financeID, finance.income, finance.expense);
                }
            }
            else
            {
                MessageBox.Show("Không tải được danh sách tài chính.");
            }
        }


        private void GetDataFromTextBoxes()
        {
            finance.financeID = txtCustomerID.Text;
            finance.income = txtPhone.Text;
            finance.expense = txtStatus.Text;
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells[0].Value?.ToString();
                txtPhone.Text = row.Cells[1].Value?.ToString();
                txtStatus.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!finance.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(finance.financeID))
            {
                controller.Update(finance);

            }
            else
            {
                controller.Create(finance);
            }

            LoadList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();

            if (!finance.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(finance.financeID))
            {
                if (controller.Update(finance))
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            string financeID = txtCustomerID.Text;

            if (string.IsNullOrEmpty(financeID))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (controller.IsExist(financeID))
                {
                    finance.financeID = financeID;
                    if (controller.Delete(finance))
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

        private void button4_Click_1(object sender, EventArgs e)
        {

            string searchName = textBox6.Text;
            List<IModel> results = controller.Search(searchName);

            dataGridView.Rows.Clear();
            foreach (FinanceModel model in results)
            {
                dataGridView.Rows.Add(model.financeID, model.income, model.expense);
            }
        }
    }
}

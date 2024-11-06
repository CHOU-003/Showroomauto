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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShowroomAUTO.View
{
    public partial class Car : Form , IView
    {
        private CarController controller;
        private CarModel car;

        public Car()
        {
            InitializeComponent();
            controller = new CarController();
            car = new CarModel();

            this.Load += new EventHandler(CarView_Load);
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private void CarView_Load(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void LoadCarList()
        {
            dataGridView1.Rows.Clear();
            if (controller.Load())
            {
                foreach (var Car in controller.Items)
                {
                    CarModel car = (CarModel)Car;
                    dataGridView1.Rows.Add(car.carID, car.brand, car.model, car.price, car.status);
                }
            }
            else
            {
                MessageBox.Show("Không tải được danh sách khách hàng.");
            }
        }

        //private void GetDataFromTextBoxes()
        //{
        //    car.carID = textBoxID.Text;                    // Sử dụng textBoxID cho carID
        //    car.brand = comboBoxBrand.Text;                // Sử dụng comboBoxBrand cho brand
        //    car.model = textBoxModel.Text;                 // Sử dụng textBoxModel cho model
        //    car.price = textBoxPrice.Text;                 // Sử dụng textBoxPrice cho price
        //    car.status = comboBoxStatus.Text;              // Sử dụng comboBoxStatus cho status
        //}


   



        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridView1TextBoxColumn4;

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (!car.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(car.carID))
            {
                controller.Update(car);

            }
            else
            {
                controller.Create(car);
            }

            LoadCarList();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (!car.IsValidate())
            {
                MessageBox.Show("Dữ liệu không được để trống.");
                return;
            }

            if (controller.IsExist(car.carID))
            {
                if (controller.Update(car))
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

            LoadCarList();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            string carID = textBoxID.Text;

            if (string.IsNullOrEmpty(carID))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Kiểm tra xem ID có tồn tại trong cơ sở dữ liệu không
                if (controller.IsExist(carID))
                {
                    car.carID = carID;
                    if (controller.Delete(car))
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

                LoadCarList();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng từ DataGridView
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ các cột của hàng vào các TextBox và các điều khiển khác tương ứng
                textBoxID.Text = row.Cells[0].Value?.ToString();             // carID
                comboBoxBrand.Text = row.Cells[1].Value?.ToString();         // brand
                textBoxModel.Text = row.Cells[2].Value?.ToString();          // model
                textBoxPrice.Text = row.Cells[3].Value?.ToString();          // price
                comboBoxStatus.Text = row.Cells[4].Value?.ToString();        // status
            }
            SetDataToText();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string searchName = textBoxFind.Text;
            List<IModel> results = controller.Search(searchName);

            dataGridView1.Rows.Clear();
            foreach (CarModel model in results)
            {
                dataGridView1.Rows.Add(car.carID, car.brand, car.model, car.price, car.status);
            }
        }

        public void GetDataFromText()
        {
            string carID = this.textBoxID.Text;
            string model = this.textBoxModel.Text;
            string price = this.textBoxPrice.Text;

            string brand = "";
            if (this.comboBoxBrand != null && this.comboBoxBrand.SelectedItem != null)
            {
                brand = this.comboBoxBrand.SelectedItem.ToString();
            }

            string status = "";
            if (this.comboBoxStatus != null && this.comboBoxStatus.SelectedItem != null)
            {
                status = this.comboBoxStatus.SelectedItem.ToString();
            }

            car.carID = carID;
            car.brand = brand;
            car.status = status;
            car.model = model;
            car.price = price;
        }


        public void SetDataToText()
        {
            textBoxID.Text = car.carID;
            textBoxPrice.Text = car.price;
            textBoxModel.Text = car.model; 
            comboBoxBrand.Text = car.brand;
            comboBoxStatus.Text = car.status;
        }
    }
}

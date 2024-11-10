using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ShowroomAUTO.View
{
    partial class Maintenance
    {
        private void InitializeComponent()
        {
            textBox6 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtStatus = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtCustomerID = new TextBox();
            label1 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(494, 12);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Nhập tên tìm kiếm";
            textBox6.Size = new Size(225, 27);
            textBox6.TabIndex = 33;
            // 
            // button4
            // 
            button4.Location = new Point(394, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 32;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 8;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(640, 475);
            button3.Name = "button3";
            button3.Size = new Size(99, 33);
            button3.TabIndex = 31;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(509, 475);
            button2.Name = "button2";
            button2.Size = new Size(92, 33);
            button2.TabIndex = 30;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView.Location = new Point(55, 243);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1310, 222);
            dataGridView.TabIndex = 28;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "MaintenanceID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên Khách Hàng";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tên Xe";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Chi Tiết";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ngày bảo dưỡng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Gói bảo dưỡng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Trạng thái";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tiền bảo dưỡng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "NV bảo dưỡng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 131);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 27;
            label6.Text = "Gói bảo dưỡng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 124);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 26;
            label5.Text = "Tên Xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 77);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 25;
            label4.Text = "Ngày bảo dưỡng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 77);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 24;
            label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 33);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 23;
            label2.Text = "MaintenanceID";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(538, 128);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(201, 27);
            txtStatus.TabIndex = 22;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(168, 124);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(204, 27);
            txtAddress.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(538, 74);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(201, 27);
            txtPhone.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 19;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(168, 30);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(204, 27);
            txtCustomerID.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, 4);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 17;
            label1.Text = "Thông tin bảo dưỡng xe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 172);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 34;
            label7.Text = "Chi tiết";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(538, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 179);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 37;
            label8.Text = "Trạng thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(774, 81);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 38;
            label9.Text = "Tiền bảo dưỡng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(774, 131);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 39;
            label10.Text = "NV  bảo dưỡng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(778, 179);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 40;
            label11.Text = "Ghi chú";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(895, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 41;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(895, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 27);
            textBox4.TabIndex = 42;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(895, 179);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(208, 27);
            textBox5.TabIndex = 43;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 518);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStatus);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtCustomerID);
            Controls.Add(label1);
            Name = "Maintenance";
            Text = "Maintenance";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox6;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtStatus;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtCustomerID;
        private Label label1;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
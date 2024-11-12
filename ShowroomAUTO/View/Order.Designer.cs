namespace ShowroomAUTO.View
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBoxStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxCar = new TextBox();
            textBoxEmployee = new TextBox();
            textBoxCustomer = new TextBox();
            textBoxFind = new TextBox();
            textBoxValue = new TextBox();
            textBoxID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            buttonFind = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBoxCar);
            panel1.Controls.Add(textBoxEmployee);
            panel1.Controls.Add(textBoxCustomer);
            panel1.Controls.Add(textBoxFind);
            panel1.Controls.Add(textBoxValue);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 209);
            panel1.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(670, 106);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(375, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBoxCar
            // 
            textBoxCar.Location = new Point(375, 154);
            textBoxCar.Name = "textBoxCar";
            textBoxCar.PlaceholderText = "ID Xe";
            textBoxCar.Size = new Size(125, 27);
            textBoxCar.TabIndex = 16;
            // 
            // textBoxEmployee
            // 
            textBoxEmployee.Location = new Point(115, 154);
            textBoxEmployee.Name = "textBoxEmployee";
            textBoxEmployee.PlaceholderText = "ID Nhân Viên";
            textBoxEmployee.Size = new Size(125, 27);
            textBoxEmployee.TabIndex = 15;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(115, 104);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.PlaceholderText = "ID Khách Hàng";
            textBoxCustomer.Size = new Size(125, 27);
            textBoxCustomer.TabIndex = 14;
            // 
            // textBoxFind
            // 
            textBoxFind.Location = new Point(670, 57);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.PlaceholderText = "Tìm kiếm ID Khách hàng";
            textBoxFind.Size = new Size(175, 27);
            textBoxFind.TabIndex = 13;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(375, 57);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.PlaceholderText = "Gía Bán";
            textBoxValue.Size = new Size(125, 27);
            textBoxValue.TabIndex = 10;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(115, 57);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "ID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 42);
            label1.TabIndex = 8;
            label1.Text = "QUẢN LÝ HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonFind);
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(buttonDelete);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 52);
            panel2.TabIndex = 1;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(291, 12);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(94, 29);
            buttonFind.TabIndex = 7;
            buttonFind.Text = "Tìm kiếm";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(795, 12);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(621, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(911, 244);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID Khách Hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID Nhân Viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "ID Xe";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thời Gian";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Giá Bán";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 140;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 505);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Order";
            Text = "Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxCustomer;
        private TextBox textBoxFind;
        private TextBox textBoxValue;
        private TextBox textBoxID;
        private Label label1;
        private Panel panel2;
        private Button buttonFind;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private TextBox textBoxCar;
        private TextBox textBoxEmployee;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxStatus;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
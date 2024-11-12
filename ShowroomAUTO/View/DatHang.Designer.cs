namespace ShowroomAUTO.View
{
    partial class DatHang
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
            dateTimePicker1 = new DateTimePicker();
            textBoxCar = new TextBox();
            textBoxEmployee = new TextBox();
            textBoxCustomer = new TextBox();
            textBoxValue = new TextBox();
            textBoxID = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            buttonhHuy = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBoxCar);
            panel1.Controls.Add(textBoxEmployee);
            panel1.Controls.Add(textBoxCustomer);
            panel1.Controls.Add(textBoxValue);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 404);
            panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(346, 313);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBoxCar
            // 
            textBoxCar.Location = new Point(346, 255);
            textBoxCar.Name = "textBoxCar";
            textBoxCar.PlaceholderText = "ID Xe";
            textBoxCar.Size = new Size(300, 27);
            textBoxCar.TabIndex = 16;
            // 
            // textBoxEmployee
            // 
            textBoxEmployee.Location = new Point(346, 140);
            textBoxEmployee.Name = "textBoxEmployee";
            textBoxEmployee.PlaceholderText = "ID Nhân Viên";
            textBoxEmployee.Size = new Size(300, 27);
            textBoxEmployee.TabIndex = 15;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(346, 196);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.PlaceholderText = "ID Khách Hàng";
            textBoxCustomer.Size = new Size(300, 27);
            textBoxCustomer.TabIndex = 14;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(346, 374);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.PlaceholderText = "Gía Bán";
            textBoxValue.Size = new Size(300, 27);
            textBoxValue.TabIndex = 10;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(346, 84);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "ID";
            textBoxID.Size = new Size(300, 27);
            textBoxID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 42);
            label1.TabIndex = 8;
            label1.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(448, 468);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Confirm";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonhHuy
            // 
            buttonhHuy.Location = new Point(623, 468);
            buttonhHuy.Name = "buttonhHuy";
            buttonhHuy.Size = new Size(94, 29);
            buttonhHuy.TabIndex = 6;
            buttonhHuy.Text = "Cancle";
            buttonhHuy.UseVisualStyleBackColor = true;
            buttonhHuy.Click += buttonhHuy_Click;
            // 
            // DatHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 509);
            Controls.Add(buttonhHuy);
            Controls.Add(buttonSave);
            Controls.Add(panel1);
            Name = "DatHang";
            Text = "DatHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxCar;
        private TextBox textBoxEmployee;
        private TextBox textBoxCustomer;
        private TextBox textBoxValue;
        private TextBox textBoxID;
        private Label label1;
        private Button buttonSave;
        private Button buttonhHuy;
    }
}
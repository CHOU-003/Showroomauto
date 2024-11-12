namespace ShowroomAUTO.View
{
    partial class Finance
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
            textBox6 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtStatus = new TextBox();
            txtPhone = new TextBox();
            txtCustomerID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(338, 12);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Nhập tên tìm kiếm";
            textBox6.Size = new Size(183, 27);
            textBox6.TabIndex = 33;
            // 
            // button4
            // 
            button4.Location = new Point(237, 11);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 32;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 8;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(389, 427);
            button3.Name = "button3";
            button3.Size = new Size(99, 33);
            button3.TabIndex = 31;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(237, 427);
            button2.Name = "button2";
            button2.Size = new Size(92, 33);
            button2.TabIndex = 30;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(95, 423);
            button1.Name = "button1";
            button1.Size = new Size(92, 41);
            button1.TabIndex = 29;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView.Location = new Point(62, 200);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(426, 183);
            dataGridView.TabIndex = 28;
            dataGridView.CellContentClick += dataGridView_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "FinanceID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Income";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Expense";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 146);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 27;
            label6.Text = "Expense";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 104);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 25;
            label4.Text = "Income";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 57);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 23;
            label2.Text = "CustomerID";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(168, 143);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(199, 27);
            txtStatus.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(168, 101);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(199, 27);
            txtPhone.TabIndex = 20;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(168, 54);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(199, 27);
            txtCustomerID.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 17;
            label1.Text = "Thông tin tài chính";
            // 
            // Finance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 473);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtStatus);
            Controls.Add(txtPhone);
            Controls.Add(txtCustomerID);
            Controls.Add(label1);
            Name = "Finance";
            Text = "Finance";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox txtStatus;
        private TextBox txtPhone;
        private TextBox txtCustomerID;
        private Label label1;
    }
}
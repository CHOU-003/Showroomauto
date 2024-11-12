namespace ShowroomAUTO.View
{
    partial class MecYellow
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mec1;
            pictureBox1.Location = new Point(39, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 44);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 1;
            label1.Text = "Hãng xe: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(359, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 2;
            label2.Text = "Dòng xe: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(359, 175);
            label3.Name = "label3";
            label3.Size = new Size(115, 24);
            label3.TabIndex = 3;
            label3.Text = "Trạng thái: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(359, 129);
            label4.Name = "label4";
            label4.Size = new Size(52, 24);
            label4.TabIndex = 4;
            label4.Text = "Giá: ";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(492, 265);
            button2.Name = "button2";
            button2.Size = new Size(109, 35);
            button2.TabIndex = 6;
            button2.Text = "Đặt Xe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(359, 224);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 7;
            label5.Text = "Màu sắc: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(462, 44);
            label6.Name = "label6";
            label6.Size = new Size(94, 24);
            label6.TabIndex = 8;
            label6.Text = "Mercedes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(462, 85);
            label7.Name = "label7";
            label7.Size = new Size(97, 24);
            label7.TabIndex = 9;
            label7.Text = "Coupe GT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(462, 129);
            label8.Name = "label8";
            label8.Size = new Size(120, 24);
            label8.TabIndex = 10;
            label8.Text = "1250000000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(462, 175);
            label9.Name = "label9";
            label9.Size = new Size(0, 24);
            label9.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(467, 175);
            label10.Name = "label10";
            label10.Size = new Size(109, 24);
            label10.TabIndex = 12;
            label10.Text = "Đang Nhập";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(467, 224);
            label11.Name = "label11";
            label11.Size = new Size(55, 24);
            label11.TabIndex = 13;
            label11.Text = "Vàng";
            // 
            // MecYellow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MecYellow";
            Text = "MecYellow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
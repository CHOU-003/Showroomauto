namespace ShowroomAUTO.View
{
    partial class Login
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
            groupBox1 = new GroupBox();
            dangnhap = new Button();
            cancelbutton = new Button();
            passwordtextbox = new TextBox();
            idtextbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dangnhap);
            groupBox1.Controls.Add(cancelbutton);
            groupBox1.Controls.Add(passwordtextbox);
            groupBox1.Controls.Add(idtextbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(102, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ĐĂNG NHẬP";
            // 
            // dangnhap
            // 
            dangnhap.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point);
            dangnhap.Location = new Point(431, 146);
            dangnhap.Name = "dangnhap";
            dangnhap.Size = new Size(112, 48);
            dangnhap.TabIndex = 5;
            dangnhap.Text = "Login";
            dangnhap.UseVisualStyleBackColor = true;
            dangnhap.Click += loginButton_Click;
            // 
            // cancelbutton
            // 
            cancelbutton.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point);
            cancelbutton.Location = new Point(313, 146);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(112, 48);
            cancelbutton.TabIndex = 4;
            cancelbutton.Text = "Cancel";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancel_button;
            // 
            // passwordtextbox
            // 
            passwordtextbox.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtextbox.Location = new Point(277, 90);
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.PasswordChar = '*';
            passwordtextbox.Size = new Size(150, 37);
            passwordtextbox.TabIndex = 3;
            // 
            // idtextbox
            // 
            idtextbox.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            idtextbox.Location = new Point(277, 52);
            idtextbox.Name = "idtextbox";
            idtextbox.Size = new Size(150, 37);
            idtextbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 98);
            label2.Name = "label2";
            label2.Size = new Size(114, 29);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 60);
            label1.Name = "label1";
            label1.Size = new Size(155, 29);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 269);
            Controls.Add(groupBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox passwordtextbox;
        private TextBox idtextbox;
        private Button dangnhap;
        private Button cancelbutton;
    }
}
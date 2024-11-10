using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ShowroomAUTO.View
{
    partial class Car
    {

        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBoxColor = new ComboBox();
            textBoxModel = new TextBox();
            textBoxFind = new TextBox();
            comboBoxStatus = new ComboBox();
            comboBoxBrand = new ComboBox();
            textBoxPrice = new TextBox();
            textBoxID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            buttonFind = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxColor);
            panel1.Controls.Add(textBoxModel);
            panel1.Controls.Add(textBoxFind);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(comboBoxBrand);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 209);
            panel1.TabIndex = 0;
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Items.AddRange(new object[] { "Đỏ", "Xanh", "Dương", "Cam", "Vàng", "Trắng", "Đen", "Xám" });
            comboBoxColor.Location = new Point(313, 100);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(151, 28);
            comboBoxColor.TabIndex = 8;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(81, 151);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.PlaceholderText = "Model";
            textBoxModel.Size = new Size(125, 27);
            textBoxModel.TabIndex = 7;
            // 
            // textBoxFind
            // 
            textBoxFind.Location = new Point(501, 117);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.PlaceholderText = "Tìm kiếm";
            textBoxFind.Size = new Size(125, 27);
            textBoxFind.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Còn ", "Hết" });
            comboBoxStatus.Location = new Point(501, 162);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 4;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Items.AddRange(new object[] { "Mez", "Honda", "Toyota", "Mazda", "Ford", "Hyundai", "Suzuki", "Kia\t", "Lexus", "Nissan", "Mercedes" });
            comboBoxBrand.Location = new Point(81, 100);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(151, 28);
            comboBoxBrand.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(501, 70);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Price";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(81, 57);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "ID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 42);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ XE";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonFind);
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 58);
            panel2.TabIndex = 1;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(149, 18);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(94, 29);
            buttonFind.TabIndex = 3;
            buttonFind.Text = "Tìm kiếm";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(649, 16);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(475, 16);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(291, 16);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 183);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Brand";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Model";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 170;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Color";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Car";
            Text = "Car";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private TextBox textBoxFind;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxBrand;
        private TextBox textBoxPrice;
        private TextBox textBoxID;
        private TextBox textBoxModel;
        private Label label1;
        private Panel panel2;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSave;
        private DataGridView dataGridView1;
        private Button buttonFind;
        private ComboBox comboBoxColor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
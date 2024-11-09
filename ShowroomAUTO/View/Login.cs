using ShowroomAUTO.Controller;
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
	public partial class Login : Form
	{
		private EmployeeController EmployeeController = new EmployeeController();
		public Login()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
		private void cancel_button(object sender, EventArgs e)
		{
			this.Close();
		}
		private void loginButton_Click(object sender, EventArgs e)
		{
			string employeeID = idtextbox.Text;
			string password = passwordtextbox.Text;
			bool successful = EmployeeController.Login(employeeID, password);
			if (successful)
			{
				new Employee().Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Sai tài khoản mật khẩu");
			}
		}
	}
}

using ShowroomAUTO.View;

namespace ShowroomAUTO
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.Show();

            this.Hide();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.Show();

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MecYellow mecYellow = new MecYellow();

            mecYellow.Show();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance maintenance = new Maintenance();

            maintenance.Show();
        }

        private void maintenanceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuBaoDuong phieuBao = new PhieuBaoDuong();

            phieuBao.Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car car = new Car();

            car.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            order.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();

            login.Show();
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();

            finance.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();

            login.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            contact.Show();
        }
    }
}
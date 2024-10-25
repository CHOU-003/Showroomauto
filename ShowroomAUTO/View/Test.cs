using ShowroomAUTO.View;

namespace ShowroomAUTO
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Customer customer = new Customer();

            customer.Show();

            this.Hide();
        }
    }
}
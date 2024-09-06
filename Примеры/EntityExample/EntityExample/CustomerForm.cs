namespace EntityExample
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; private set; } = new Customer();

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer)
        {
            InitializeComponent();

            Customer = customer;

            textBoxName.Text = customer.Name;
            numericUpDownAge.Value = customer.Age;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {

            Customer.Name = textBoxName.Text;
            Customer.Age = (int)numericUpDownAge.Value;


            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

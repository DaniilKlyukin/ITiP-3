namespace EntityExample
{
    public partial class BankAccountForm : Form
    {
        public BankAccount BankAccount { get; set; } = new BankAccount();

        public BankAccountForm(IList<Customer> customers)
        {
            InitializeComponent();

            comboBoxCustomer.Items.Clear();

            foreach (var customer in customers)
            {
                comboBoxCustomer.Items.Add(customer);
            }
        }

        public BankAccountForm(IList<Customer> customers, BankAccount bankAccount)
        {
            InitializeComponent();

            BankAccount = bankAccount;

            comboBoxCustomer.Items.Clear();

            foreach (var customer in customers)
            {
                comboBoxCustomer.Items.Add(customer);
            }

            numericUpDownMoney.Value = (decimal)bankAccount.Money;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedIndex == -1)
                return;

            var customer = comboBoxCustomer.SelectedItem as Customer;

            if (customer is null)
                return;

            BankAccount.Customer = customer;

            BankAccount.Money = (double)numericUpDownMoney.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

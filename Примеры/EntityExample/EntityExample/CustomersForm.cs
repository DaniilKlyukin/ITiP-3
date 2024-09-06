namespace EntityExample
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            using ApplicationContext db = new();

            // получаем объекты из бд
            var customers = db.Customers.ToList();

            dataGridView1.DataSource = customers;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var newCustomerForm = new CustomerForm();

            if (newCustomerForm.ShowDialog() != DialogResult.OK ||
                newCustomerForm.Customer is null)
                return;

            var newCustomer = newCustomerForm.Customer;

            using ApplicationContext db = new();
            db.Customers.Add(newCustomer);
            db.SaveChanges();

            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var customersToRemove = new List<Customer>();

                for (var row = 0; row < dataGridView1.SelectedRows.Count; row++)
                {
                    var customer = (Customer)dataGridView1.SelectedRows[row].DataBoundItem;

                    customersToRemove.Add(customer);
                }

                RemoveCustomers(customersToRemove);
            }
        }

        private void RemoveCustomers(IList<Customer> customers)
        {
            using ApplicationContext db = new();

            foreach (var customer in customers)
            {
                db.Customers.Remove(customer);
            }

            db.SaveChanges();
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var customerId = ((Customer)dataGridView1.SelectedRows[0].DataBoundItem).Id;

            using ApplicationContext db = new();

            var customer = db.Customers.SingleOrDefault(x => x.Id == customerId);

            if (customer == null)
                return;

            var customerForm = new CustomerForm(customer);

            if (customerForm.ShowDialog() != DialogResult.OK ||
                customerForm.Customer is null)
                return;

            db.SaveChanges();

            dataGridView1.DataSource = db.Customers.ToList();
        }
    }
}
namespace EntityExample
{
    public partial class BankAccountsForm : Form
    {
        public BankAccountsForm()
        {
            InitializeComponent();

            using ApplicationContext db = new();

            // получаем объекты из бд
            var bankAccounts = db.BankAccounts.ToList();

            dataGridView1.DataSource = bankAccounts;
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            using ApplicationContext db = new();

            var bankAccountForm = new BankAccountForm(db.Customers.ToList());

            if (bankAccountForm.ShowDialog() != DialogResult.OK ||
                bankAccountForm.BankAccount is null)
                return;

            var newBankAccount = bankAccountForm.BankAccount;

            db.BankAccounts.Add(newBankAccount);
            db.SaveChanges();

            dataGridView1.DataSource = db.BankAccounts.ToList();
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var bankAccountId = ((BankAccount)dataGridView1.SelectedRows[0].DataBoundItem).Id;

            using ApplicationContext db = new();

            var bankAccount = db.BankAccounts.SingleOrDefault(x => x.Id == bankAccountId);

            if (bankAccount == null)
                return;

            var bankAccountForm = new BankAccountForm(db.Customers.ToList(), bankAccount);

            if (bankAccountForm.ShowDialog() != DialogResult.OK ||
                bankAccountForm.BankAccount is null)
                return;

            db.SaveChanges();

            dataGridView1.DataSource = db.BankAccounts.ToList();
        }

        private void RemoveBankAccounts(IList<BankAccount> bankAccounts)
        {
            using ApplicationContext db = new();

            foreach (var bankAccount in bankAccounts)
            {
                db.BankAccounts.Remove(bankAccount);
            }

            db.SaveChanges();
            dataGridView1.DataSource = db.BankAccounts.ToList();
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var bankAccountsToRemove = new List<BankAccount>();

                for (var row = 0; row < dataGridView1.SelectedRows.Count; row++)
                {
                    var bankAccount = (BankAccount)dataGridView1.SelectedRows[row].DataBoundItem;

                    bankAccountsToRemove.Add(bankAccount);
                }

                RemoveBankAccounts(bankAccountsToRemove);
            }
        }
    }
}

using ProductsLibrary;

namespace ProductsWinFormsApp
{
    public partial class ProductForm : Form
    {
        public int NAME_MAX_LENGTH = 200;

        public Product? Product { get; private set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;

            if (name.Length > NAME_MAX_LENGTH)
            {
                MessageBox.Show($"Имя не должно быть больше {NAME_MAX_LENGTH} символов");
                return;
            }

            var price = (double)priceNumeric.Value;

            var quantity = (int)quantityNumeric.Value;

            Product = new Product(Guid.NewGuid().ToString(), name, price, quantity);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}

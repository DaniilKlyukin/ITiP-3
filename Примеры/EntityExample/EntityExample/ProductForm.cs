namespace EntityExample
{
    public partial class ProductForm : Form
    {
        public Product Product { get; private set; } = new Product();

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product)
        {
            InitializeComponent();

            Product = product;

            textBoxName.Text = product.Name;
            numericUpDownPrice.Value = (decimal)product.Price;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Product.Name = textBoxName.Text;
            Product.Price = (double)numericUpDownPrice.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

namespace EntityExample
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            using ApplicationContext db = new();

            // получаем объекты из бд
            var products = db.Products.ToList();

            dataGridView1.DataSource = products;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var newProductForm = new ProductForm();

            if (newProductForm.ShowDialog() != DialogResult.OK ||
                newProductForm.Product is null)
                return;

            var newProduct = newProductForm.Product;

            using ApplicationContext db = new();
            db.Products.Add(newProduct);
            db.SaveChanges();

            dataGridView1.DataSource = db.Products.ToList();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var productId = ((Product)dataGridView1.SelectedRows[0].DataBoundItem).Id;

            using ApplicationContext db = new();

            var product = db.Products.SingleOrDefault(x => x.Id == productId);

            if (product == null)
                return;

            var productForm = new ProductForm(product);

            if (productForm.ShowDialog() != DialogResult.OK ||
                productForm.Product is null)
                return;

            db.SaveChanges();

            dataGridView1.DataSource = db.Products.ToList();
        }
        private void RemoveProducts(IList<Product> products)
        {
            using ApplicationContext db = new();

            foreach (var product in products)
            {
                db.Products.Remove(product);
            }

            db.SaveChanges();
            dataGridView1.DataSource = db.Products.ToList();
        }
        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var productsToRemove = new List<Product>();

                for (var row = 0; row < dataGridView1.SelectedRows.Count; row++)
                {
                    var product = (Product)dataGridView1.SelectedRows[row].DataBoundItem;

                    productsToRemove.Add(product);
                }

                RemoveProducts(productsToRemove);
            }
        }
    }
}

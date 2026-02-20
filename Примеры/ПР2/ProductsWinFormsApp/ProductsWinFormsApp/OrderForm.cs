using ProductsLibrary;

namespace ProductsWinFormsApp;

public partial class OrderForm : Form
{
    public int NAME_MAX_LENGTH = 200;

    public Order? Order { get; private set; }

    public OrderForm()
    {
        InitializeComponent();
    }

    private void confirmButton_Click(object sender, EventArgs e)
    {
        var customer = customersComboBox.SelectedItem as Customer;

        if (customer == null)
        {
            MessageBox.Show("Необходимо выбрать покупателя!");
            return;
        }

        Order = new Order(Guid.NewGuid().ToString(), customer);

        var products = addedProductsListBox.Items.Cast<Product>().ToArray();

        foreach (var product in products)
        {
            Order.AddProduct(product);
        }

        DialogResult = DialogResult.OK;

        Close();
    }

    private void OrderForm_Load(object sender, EventArgs e)
    {
        customersComboBox.Items.AddRange(AppContext.Customers.ToArray());

        productsComboBox.Items.AddRange(AppContext.Products.ToArray());
    }

    private void addProductButton_Click(object sender, EventArgs e)
    {
        var product = productsComboBox.SelectedItem as Product;

        addedProductsListBox.Items.Add(product);
    }

    private void removeProductButton_Click(object sender, EventArgs e)
    {
        addedProductsListBox.Items.Remove(addedProductsListBox.SelectedItem);
    }
}

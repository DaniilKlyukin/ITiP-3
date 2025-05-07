using ProductsLibrary;
using System.Text;

namespace ProductsWinFormsApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void productsButton_Click(object sender, EventArgs e)
    {
        var sb = new StringBuilder();

        foreach (var product in AppContext.Products)
        {
            sb.AppendLine(product.GetProductSummary());
        }

        outputTextBox.Text = sb.ToString();
    }

    private void customersButton_Click(object sender, EventArgs e)
    {
        var sb = new StringBuilder();

        foreach (var customer in AppContext.Customers)
        {
            sb.AppendLine(customer.GetCustomerInfo());

            foreach (var order in customer.Orders)
            {
                sb.AppendLine(order.GetOrderSummary());
            }

            sb.AppendLine();
        }

        outputTextBox.Text = sb.ToString();
    }

    private void ordersButton_Click(object sender, EventArgs e)
    {
        var sb = new StringBuilder();

        foreach (var order in AppContext.Orders)
        {
            sb.AppendLine(order.GetOrderSummary());
        }

        outputTextBox.Text = sb.ToString();
    }

    private void addProductButton_Click(object sender, EventArgs e)
    {
        var form = new ProductForm();

        if (form.ShowDialog() == DialogResult.OK && form.Product != null)
        {
            AppContext.Products.Add(form.Product);
        }
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
        var form = new CustomerForm();

        if (form.ShowDialog() == DialogResult.OK && form.Customer != null)
        {
            AppContext.Customers.Add(form.Customer);
        }
    }

    private void addOrderButton_Click(object sender, EventArgs e)
    {
        var form = new OrderForm();

        if (form.ShowDialog() == DialogResult.OK && form.Order != null)
        {
            AppContext.Orders.Add(form.Order);
        }
    }
}

using ProductsLibrary;

namespace ProductsWinFormsApp;

public partial class CustomerForm : Form
{
    public int NAME_MAX_LENGTH = 200;

    public Customer? Customer { get; private set; }

    public CustomerForm()
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

        var email = emailTextBox.Text;

        if (!email.Contains("@"))
        {
            MessageBox.Show($"Неверный адрес эл. почты");
            return;
        }

        var address = addressTextBox.Text;

        if (string.IsNullOrWhiteSpace(address))
        {
            MessageBox.Show($"Неверный адрес");
            return;
        }

        Customer = new Customer(Guid.NewGuid().ToString(), name, email, address);

        DialogResult = DialogResult.OK;

        Close();
    }
}

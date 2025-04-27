using System.Text.RegularExpressions;

namespace RegistrationFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateLogin(txtLogin.Text))
            {
                lblError.Text = "����������� �������!";
                lblError.ForeColor = Color.Green;
                // ����� ����� �������� ������ ���������� ������
            }
        }

        private bool ValidateLogin(string login)
        {
            // ���������� ��������� ��� �������� ������
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,19}$";

            if (string.IsNullOrWhiteSpace(login))
            {
                lblError.Text = "����� �� ����� ���� ������";
                lblError.ForeColor = Color.Red;
                return false;
            }

            if (!Regex.IsMatch(login, pattern))
            {
                lblError.Text = "����� �� ������������� �����������";
                lblError.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }
    }
}
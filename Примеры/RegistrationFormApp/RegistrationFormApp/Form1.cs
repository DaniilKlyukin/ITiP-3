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
                lblError.Text = "–егистраци€ успешна!";
                lblError.ForeColor = Color.Green;
                // «десь можно добавить логику сохранени€ данных
            }
        }

        private bool ValidateLogin(string login)
        {
            // –егул€рное выражение дл€ проверки логина
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,19}$";

            if (string.IsNullOrWhiteSpace(login))
            {
                lblError.Text = "Ћогин не может быть пустым";
                lblError.ForeColor = Color.Red;
                return false;
            }

            if (!Regex.IsMatch(login, pattern))
            {
                lblError.Text = "Ћогин не соответствует требовани€м";
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
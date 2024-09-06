using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using ApplicationContext db = new();

            db.Customers.AddRange(new List<Customer>
            {
                new Customer{Name = "Иван", Age = 25},
                new Customer{Name = "Петр", Age = 35},
                new Customer{Name = "Елена", Age = 23},
                new Customer{Name = "Анна", Age = 40},
            });

            db.Products.AddRange(new List<Product>
            {
                new Product{Name = "Стол", Price = 12000},
                new Product{Name = "Стул", Price = 2500},
                new Product{Name = "ВАЗ 2107", Price = 75000},
                new Product{Name = "Яблоки 1кг", Price = 120},
            });

            db.SaveChanges();

            var customers = db.Customers.ToList();

            db.BankAccounts.AddRange(new List<BankAccount>
            {
                new BankAccount{Customer = customers[0], Money = 10000},
                new BankAccount{Customer = customers[1], Money = 250000},
                new BankAccount{Customer = customers[2], Money = 5000},
                new BankAccount{Customer = customers[3], Money = 1000000},
            });

            db.SaveChanges();

            //Молодые покупатели
            var youngCustomers = db.Customers
                .Where(c => c.Age <= 30)
                .ToList();

            //Могут купить ВАЗ 2107
            var canBuyVAZ = db.BankAccounts
                .Where(b => b.Money >= 75000)
                .Select(b => b.Customer)
                .ToList();

            //Топ по кол-ву денег на счете
            var moneyTop = db.BankAccounts
                .OrderByDescending(b => b.Money)
                .Select(b => new { b.Money, b.Customer });

            //самый дорогой товар
            var mostExpensive = db.Products
                .ToList()
                .MaxBy(p => p.Price);

            //Удаляем бедных }:)
            /* var customersToRemove = db.BankAccounts
                 .Where(b => b.Money <= 1e4)
                 .Select(b => b.Customer)
                 .ToList();*/

            //Не забываем сохранять изменения
            // db.SaveChanges();

            var ba1 = db.BankAccounts.ToList();

            //Добавляем денег
            db.BankAccounts
                .Where(b => b.Money <= 1e4)
                .ToList()
                .ForEach(b =>
                {
                    b.Money *= 2;
                });

            db.SaveChanges();

            var ba2 = db.BankAccounts.ToList();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersForm();

            customersForm.Show();
        }

        private void buttonBankAccounts_Click(object sender, EventArgs e)
        {
            var bankAccountsForm = new BankAccountsForm();

            bankAccountsForm.Show();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductsForm();

            productsForm.Show();
        }
    }
}

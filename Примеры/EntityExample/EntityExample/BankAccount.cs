using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EntityExample
{
    public class BankAccount
    {
        public int Id { get; set; }
        public double Money { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
﻿namespace EntityExample
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public BankAccount? BankAccount { get; set; }
    }
}
using System;

namespace ExpenseManagerPV178.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public TransactionType Type { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Payee { get; set; }

        public Transaction(int id, string owner, TransactionType type, string cat, string date, double amount, string payMethod, string payee)
        {
            Id = id;
            OwnerName = owner;
            Type = type;
            Category = cat;
            Date = date;
            Amount = amount;
            PaymentMethod = payMethod;
            Payee = payee;
        }

        public Transaction() { }
    }
}

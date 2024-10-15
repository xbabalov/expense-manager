using System;

namespace ExpenseManagerPV178.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public double MonthlyIncome { get; set; }
        public double MonthlyExpense { get; set; }
        public double MonthlyBudget { get; set; }
        public User(string name, string pswd, double initialBalance, double mIncome, double mExpense, double budget)
        {
            Username = name;
            Password = pswd;
            Balance = initialBalance;
            MonthlyIncome = mIncome;
            MonthlyExpense = mExpense;
            MonthlyBudget = budget;
        }

        public User() { }
    }
}

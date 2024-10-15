using ExpenseManagerPV178.Data;
using ExpenseManagerPV178.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagerPV178
{
    static class Program
    {
        public static Forms.Main MainPage = new Forms.Main();
        public static User currentUser;
        public static List<User> users = new List<User>();
        public static List<Transaction> transactions = new List<Transaction>();
        public static int transactionCount;
        public static string currency = "€";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadListsAsync();
            Application.Run(MainPage);
        }

        private static async Task LoadListsAsync()
        {
            users = await SqliteAccessUser.LoadUsersAsync();
            transactions = await SqliteAccessTransaction.LoadTransactionsAsync();

            if(transactions.Count > 0)
            {
                transactionCount = transactions.Last().Id + 1;
            } else
            {
                transactionCount = 1;
            }
        }

        public static User FindUser(string username)
        {
            foreach(var user in users){
                if(user.Username == username)
                {
                    return user;
                }
            }
            return null;
        }

        public static List<Transaction> GetUserTransactions(User user)
        {
            var result = new List<Transaction>();
            foreach(var trans in transactions)
            {
                if(trans.OwnerName == user.Username)
                {
                    result.Add(trans);
                }
            }
            return result;
        }
    }
}

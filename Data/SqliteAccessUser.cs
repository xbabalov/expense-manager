using Dapper;
using ExpenseManagerPV178.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManagerPV178.Data
{
    class SqliteAccessUser
    {
        public static async Task<List<User>> LoadUsersAsync()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<User>("select * from User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static async Task SaveUserAsync(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("insert into User (Username, Password, Balance, MonthlyIncome, MonthlyExpense, MonthlyBudget) values (@Username, @Password, @Balance, @MonthlyIncome, @MonthlyExpense, @MonthlyBudget)", user);
            }
        }

        public static async Task UpdateUserAsync(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("update User set Balance = @Balance where Username = @Username", new { Balance = user.Balance, Username = user.Username });
                await cnn.ExecuteAsync("update User set MonthlyIncome = @MonthlyIncome where Username = @Username", new { MonthlyIncome = user.MonthlyIncome, Username = user.Username });
                await cnn.ExecuteAsync("update User set MonthlyExpense = @MonthlyExpense where Username = @Username", new { MonthlyExpense = user.MonthlyExpense, Username = user.Username });
                await cnn.ExecuteAsync("update User set MonthlyBudget = @MonthlyBudget where Username = @Username", new { MonthlyBudget = user.MonthlyBudget, Username = user.Username });
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

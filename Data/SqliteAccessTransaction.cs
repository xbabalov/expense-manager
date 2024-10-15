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
    class SqliteAccessTransaction
    {
        public static async Task<List<Transaction>> LoadTransactionsAsync()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<Transaction>("select * from [Transaction]", new DynamicParameters());
                return output.ToList();
            }
        }

        public static async Task SaveTransactionAsync(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("insert into [Transaction] (Id, OwnerName, Type, Category, Date, Amount, PaymentMethod, Payee) values (@Id, @OwnerName, @Type, @Category, @Date, @Amount, @PaymentMethod, @Payee)", transaction);
            }
        }

        public static async Task DeleteTransactionAsync(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("delete from [Transaction] where Id = @Id", new { Id = id });
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

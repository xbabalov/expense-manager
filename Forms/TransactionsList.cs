using ExpenseManagerPV178.Data;
using ExpenseManagerPV178.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class TransactionsList : Form
    {
        private readonly bool showExpenses;
        private readonly bool showIncomes;

        public TransactionsList(bool exp, bool inc)
        {
            InitializeComponent();
            listView1.FullRowSelect = true;

            showExpenses = exp;
            showIncomes = inc;

            DisplayTransactions();
        }

        private void DisplayTransactions()
        {
            foreach (var trans in Program.transactions)
            {
                if ((trans.Type == TransactionType.Income && showIncomes) ||
                    (trans.Type == TransactionType.Expense && showExpenses))
                {
                    var newItem = new ListViewItem(new string[] { 
                        trans.Id.ToString(), trans.Type.ToString(), 
                        trans.Category, trans.Date, 
                        trans.Amount.ToString() + Program.currency, 
                        trans.PaymentMethod, trans.Payee });
                    listView1.Items.Add(newItem);
                }
            }
        }

        private async Task BtnDelete_ClickAsync(object sender, EventArgs e)
        {
           for(int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                var item = listView1.SelectedItems[i];
                int removeId = int.Parse(item.SubItems[0].Text); 

                await SqliteAccessTransaction.DeleteTransactionAsync(removeId);

                for(int j = 0; j < Program.transactions.Count; j++)
                {
                    if(Program.transactions[j].Id == removeId)
                    {
                        if(Program.transactions[j].Type == TransactionType.Expense)
                        {
                            Program.currentUser.Balance += Program.transactions[j].Amount;
                        } else
                        {
                            Program.currentUser.Balance -= Program.transactions[j].Amount;
                        }

                        Program.transactions.RemoveAt(j);
                        await SqliteAccessUser.UpdateUserAsync(Program.currentUser);
                    }
                }
            }

            Program.MainPage.ChangePanelForm(new TransactionsList(showExpenses, showIncomes));
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            BtnDelete_ClickAsync(sender, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new Home());
        }
    }
}

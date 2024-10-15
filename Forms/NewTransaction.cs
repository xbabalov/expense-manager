using ExpenseManagerPV178.Data;
using ExpenseManagerPV178.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class NewTransaction : Form
    {
        public NewTransaction()
        {
            InitializeComponent();
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {
            comboCategory.Items.Add("Food");
            comboCategory.Items.Add("Transportation");
            comboCategory.Items.Add("Entertainment");
            comboCategory.Items.Add("Beauty and Care");
            comboCategory.Items.Add("Health");
            comboCategory.Items.Add("Children");
            comboCategory.Items.Add("Pets");
            comboCategory.Items.Add("Hobbies");
            comboCategory.Items.Add("Furniture or equipment");
            comboCategory.Items.Add("Others");

            comboPayment.Items.Add("Cash");
            comboPayment.Items.Add("Credit Card");
            comboPayment.Items.Add("Bank Transfer");
        }

        private async Task BtnSave_ClickAsync(object sender, EventArgs e)
        {
            TransactionType type;
            string category = comboCategory.Text;
            DateTime date = monthCalendar1.SelectionStart;
            double? amount;
            string paymentMethod = comboPayment.Text;
            string payee = txtPayee.Text;

            try
            {
                amount = double.Parse(txtAmount.Text);
            } catch (FormatException)
            {
                MessageBox.Show("Amount must be a valid number.");
                return;
            }

            if (radioExpense.Checked)
            {
                type = TransactionType.Expense;
            } else
            {
                type = TransactionType.Income;
            }

            if((!radioExpense.Checked && !radioIncome.Checked) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(paymentMethod) || string.IsNullOrEmpty(payee) || amount == null || amount <= 0 || date == null)
            {
                MessageBox.Show("You have to fill in all information.");
            } else
            {
                Transaction newTrans = new Transaction(Program.transactionCount + 1, Program.currentUser.Username, type, category, date.ToString(), (double)amount, paymentMethod, payee);
                Program.transactionCount++;
                await SqliteAccessTransaction.SaveTransactionAsync(newTrans);
                Program.transactions.Add(newTrans);

                if (radioExpense.Checked)
                {
                    Program.currentUser.Balance -= (double)amount;
                } else
                {
                    Program.currentUser.Balance += (double)amount;
                }

                await SqliteAccessUser.UpdateUserAsync(Program.currentUser);

                Program.MainPage.ChangePanelForm(new Home());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnSave_ClickAsync(sender, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new Home());
        }
    }
}

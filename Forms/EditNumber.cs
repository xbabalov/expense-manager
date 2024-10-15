using ExpenseManagerPV178.Data;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class EditNumber : Form
    {
        private readonly string target;
        public EditNumber(string tar)
        {
            InitializeComponent();
            target = tar;
        }

        private async Task EditTargetNumAsync(string target, double newVal)
        {
            switch (target)
            {
                case "Income":
                    Program.currentUser.MonthlyIncome = newVal;
                    break;
                case "Expense":
                    Program.currentUser.MonthlyExpense = newVal;
                    break;
                case "Budget":
                    Program.currentUser.MonthlyBudget = newVal;
                    break;
            }

            await SqliteAccessUser.UpdateUserAsync(Program.currentUser);
        }

        private async Task BtnConfirm_Click_1Async(object sender, EventArgs e)
        {
            double newVal;
            try
            {
                newVal = double.Parse(txtNewVal.Text);
            } catch (FormatException)
            {
                MessageBox.Show("New value must be a number.");
                return;
            }

            await EditTargetNumAsync(target, newVal);
            Hide();
            Program.MainPage.ChangePanelForm(new Home());
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            BtnConfirm_Click_1Async(sender, e);
        }
    }
}

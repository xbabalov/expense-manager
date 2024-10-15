using ExpenseManagerPV178.Data;
using ExpenseManagerPV178.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class EnterInfoSignIn : Form
    {
        public EnterInfoSignIn()
        {
            InitializeComponent();
        }

        private async Task BtnSignIn_ClickAsync(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtPassword2.Text;

            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("You have to fill in your username.");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("You have to fill in your password.");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Your password must match confirm password.");
                return;
            }
            if (Program.FindUser(username) != null)
            {
                MessageBox.Show("User with this username already exists.");
                return;
            }

            double bilance;
            double mExpense;
            double mIncome;
            double mBudget;
            try
            {
                bilance = double.Parse(txtBalance.Text);
                mExpense = double.Parse(txtExpense.Text);
                mIncome = double.Parse(txtIncome.Text);
                mBudget = double.Parse(txtBudget.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter valid number.");
                return;
            }
   
            User newUser = new User(username, password, bilance, mExpense, mIncome, mBudget);
            await SqliteAccessUser.SaveUserAsync(newUser);
            Program.users.Add(newUser);

            Program.MainPage.ChangePanelForm(new Login()); 
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            BtnSignIn_ClickAsync(sender, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new Login());
        }

        private void CheckIncome_CheckedChanged(object sender, EventArgs e)
        {
            txtIncome.Enabled = true;
        }

        private void CheckExpense_CheckedChanged(object sender, EventArgs e)
        {
            txtExpense.Enabled = true;
        }

        private void CheckBudget_CheckedChanged(object sender, EventArgs e)
        {
            txtBudget.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            showName.Text = Program.currentUser.Username;
            showBilance.Text = Program.currentUser.Balance.ToString() + Program.currency;
            showExpense.Text = Program.currentUser.MonthlyExpense.ToString() + Program.currency;
            showIncome.Text = Program.currentUser.MonthlyIncome.ToString() + Program.currency;
            showLimit.Text = Program.currentUser.MonthlyBudget.ToString() + Program.currency;
        }

        private void BtnEditIncome_Click(object sender, EventArgs e)
        {
            Form editNum = new EditNumber("Income");
            editNum.Show();
        }

        private void BtnEditExpense_Click(object sender, EventArgs e)
        {
            Form editNum = new EditNumber("Expense");
            editNum.Show();
        }

        private void BtnEditBudget_Click(object sender, EventArgs e)
        {
            Form editNum = new EditNumber("Budget");
            editNum.Show();
        }

        private void BtnNewTrans_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new NewTransaction());
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new Login());
        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new TransactionsList(true, false));
        }

        private void BtnInc_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new TransactionsList(false, true));
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new TransactionsList(true, true));
        }
    }
}

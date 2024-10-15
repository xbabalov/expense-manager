using ExpenseManagerPV178.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class EnterInfoLogin : Form
    {
        public EnterInfoLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = Program.FindUser(username);
            if (user == null)
            {
                MessageBox.Show("This user doesn't exist.");
            }
            else if (user.Password != password)
            {
                MessageBox.Show("Invalid password.");
            }
            else
            {
                Program.currentUser = user;
                Program.MainPage.ChangePanelForm(new Home());
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Program.MainPage.ChangePanelForm(new Login());
        }
    }
}

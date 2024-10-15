using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var form = new EnterInfoLogin();
            Program.MainPage.ChangePanelForm(form);
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            var form = new EnterInfoSignIn();
            Program.MainPage.ChangePanelForm(form);
        }
    }
}

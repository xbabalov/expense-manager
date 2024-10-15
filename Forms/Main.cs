using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExpenseManagerPV178.Forms
{
    public partial class Main : Form
    {
        public Form currentForm; 
        public Main()
        {
            InitializeComponent();
            ChangePanelForm(new Login());
        }
    }
}

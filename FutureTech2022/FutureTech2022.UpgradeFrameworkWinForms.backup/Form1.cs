using System;
using System.Windows.Forms;

namespace FutureTech2022.UpgradeFrameworkWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            mainButton.Text = "Clicked by you!";
        }
    }
}
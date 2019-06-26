using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account account = new Account();
        public AccountOperationUi()
        {
            InitializeComponent();
          
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            account.AccountNumber = Convert.ToDouble(accountNoTextBox.Text);
            account.CustomerName = customerNameTextBox.Text;
            MessageBox.Show("Account Successfully Created !");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.CustomerName + " ,Your Account Number : " + account.AccountNumber +
                            " and it's balance: " +account.Amount+ "  taka");
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            account.Amount = Convert.ToDouble(amountTextBox.Text);

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            account.Amount = Convert.ToDouble(amountTextBox.Text);
        }
    }
}

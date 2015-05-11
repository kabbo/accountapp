using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApp
{
    public partial class AccountUI : Form
    {
        public AccountUI()
        {
            InitializeComponent();
        }

        Account account =new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            account.accountNumber = accountNumberTextBox.Text;
            account.customarName = customarNameTextBox.Text;

            account.CreateAccount();
            MessageBox.Show(@"Account is created");

            
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            account.GetDeposit(Convert.ToDouble(amountTextBox.Text));

            MessageBox.Show(@"Deposit successful");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
           
           Boolean isSuccess= account.GetWithdraw(Convert.ToDouble(amountTextBox.Text));

            if (isSuccess)
            {
                MessageBox.Show(@"Withdrawn successful");
            }
            else
            {
                MessageBox.Show(@"Balance is insufficient");
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(account.GetReport());
        }
    }
}

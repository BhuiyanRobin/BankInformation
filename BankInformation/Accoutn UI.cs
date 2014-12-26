using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BankCustomer aCustomer=new BankCustomer();

        void TakeInput()
        {
            aCustomer.name = nameTextBox.Text;
            aCustomer.accountNumber = Convert.ToInt32(numebrTextBox.Text);
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            TakeInput();
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {

            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.GiveDeposite(amount);
            
            MessageBox.Show(amount + " deposited to your account");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            
            
            MessageBox.Show(aCustomer.Withdraw(amount));
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aCustomer.name + " ,your account number :: " + aCustomer.accountNumber +
                            " and your balance is " + aCustomer.amount);
        }


    }
}

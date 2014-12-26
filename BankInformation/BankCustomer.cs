using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInformation
{
    class BankCustomer
    {
        public int accountNumber;
        public string name;
        public double amount;

        public double GiveDeposite(double number)
        {
            amount = number + amount;
            return amount;
        }

        public string Withdraw(double number)
        {
            string mess;
            if (number > amount)
            {
                mess = "cannot be withdrawn your balance is lower";
            }
            else
            {
                amount = amount - number;
                mess = number + " withdrawn from your account";
            }


            return mess;
        }

    }

}

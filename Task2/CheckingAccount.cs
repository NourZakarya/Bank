using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class CheckingAccount:Account
    {
        const double WithdrawalFee = 1.50;

        public CheckingAccount(string name="none", double balance = 0.0):base(name,balance)
        {

        }
        public  new bool Withdraw(double amount)
        {
            base.Withdraw(amount);
           return base.Withdraw(WithdrawalFee); 
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Withdrawal Fee: {WithdrawalFee})";
        }

    }
}

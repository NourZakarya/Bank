using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TrustAccount:SavingsAccount
    {
         double depositeForBonus = 5000.00;
         double bonusAmount = 50.00;
         int maxWithdrawalsPerYear = 3;
         double maxWithdrawalPercentage = 0.20;

        private int withdrawalsThisYear;

        public TrustAccount(string name="none", double balance=0.0, double interestRate=1.0)
            : base(name, balance, interestRate)
        {
            withdrawalsThisYear = 0;
        }

        public new bool Deposit(double amount)
        {
            base.Deposit(amount);
            if (amount >= depositeForBonus)
            {
               return base.Deposit(bonusAmount); 
            }
            return base.Deposit(amount);
        }

        public new bool Withdraw(double amount)
        {
            if (withdrawalsThisYear < maxWithdrawalsPerYear && amount <= balance * maxWithdrawalPercentage)
            {
                withdrawalsThisYear++;
                return base.Withdraw(amount);
               
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Withdrawals This Year: {withdrawalsThisYear})";
        }
    }
}

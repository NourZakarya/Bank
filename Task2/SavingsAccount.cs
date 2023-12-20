using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SavingsAccount:Account
    {
        protected double interestRate;

        public SavingsAccount(string name="none", double balance=0.0, double interestRate=1.0)
            : base(name, balance)
        {
            this.interestRate = interestRate;
        }

        public new bool Deposit(double amount)
        {
            amount = amount * 100 / interestRate;
            return base.Deposit(amount);
           
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Interest Rate: {interestRate:P})";
        }
    }
}

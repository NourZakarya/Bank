using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
        public class Account
        {
            private decimal _balance;
            private string _name;

           // constructor to set value when create object
            public Account(string name="none", decimal startingBalance=default)
            {
                _name = name;
                _balance = startingBalance;
            }


        //public void Deposit(decimal amountToAdd)
        //{

        //    _balance += amountToAdd;
        //}
        public bool Deposit(decimal amountToAdd)
        {
            if (amountToAdd > 0)
            {
                _balance += amountToAdd;
                return true;
            }
            return false;
        }

        //public void withdraw(decimal amount)
        //    {

        //       if (_balance >= amount)
        //         _balance -= amount;
        //      else
        //        Console.WriteLine("Unsuccessful operation");
        //}
        public bool withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {

                _balance -= amount;
                return true;
            }
            return false;
            
        }
        // make Name Read Only Property
        public string Name
            {
                get { return _name; }
            }

            public void Print()
            {
                Console.WriteLine($"Name : {_name} , Balance = {_balance} ");
            }


        }
    

}

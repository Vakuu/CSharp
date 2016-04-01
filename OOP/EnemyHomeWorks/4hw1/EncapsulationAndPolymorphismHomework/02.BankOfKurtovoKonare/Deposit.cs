using System;
using System.Collections.Generic;
namespace _02.BankOfKurtovoKonare
{
    class Deposit : BlankAccount, IWithdraw
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate):
            base(customer, balance, interestRate)
        {

        }


        public override decimal CalculateInterest(int monhts)
        {
            if (this.Balance < 1000 && this.Balance > 0)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateInterest(monhts);
            }
        }

        public void Withdraw(decimal withdrawAmmount)
        {
            this.Balance -= withdrawAmmount;
        }

    }
}

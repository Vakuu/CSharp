using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare.Accounts
{
    using Customers;
    using Interfaces;

    public class DepositAccount : Account, IDepositAccount
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }
        public void Withdraw(decimal ammount)
        {
            if (this.Balance < ammount)
            {
                throw new ArgumentOutOfRangeException("Not enough money in the balance.");
            }
            this.Balance -= ammount;
        }
        public override decimal CalculateInterestForAPeriod(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return this.Balance * (decimal)(1 + (this.InterestRate / 100) * (double)months);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal Rate)
            : base(customer, balance, Rate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return this.Rate = this.Balance * (1 + this.Rate * months);
        }

        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }
    }
}

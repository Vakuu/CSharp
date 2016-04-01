using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    class Loans : Account
    {
        public Loans(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        {
        }
        public override decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance * (1 + this.Rate * months);
            if (months < 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months < 12 && this.Customer == Customer.Company)
            {
                return this.Rate = interest / 2;
            }
            return this.Rate = interest;
        }
    }
}
